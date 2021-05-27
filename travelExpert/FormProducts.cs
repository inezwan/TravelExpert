using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using travelExpert.Models;

namespace travelExpert
{
    public partial class FormProducts : Form
    {
        TravelExpertsContext context;
        public FormProducts()
        {
            context = new TravelExpertsContext();
            InitializeComponent();
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            listBoxProducts.Items.Clear();
            DisplayProducts();
        }
        private void DisplayProducts()
        {
            
            listBoxProducts.DataSource = context.Products.Select(p => p.ProdName).ToList();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (textNewProd!=null&textNewProd.Text!="")
            {
                Product newProduct = new Product()
                {
                    ProdName = textNewProd.Text
                };
                context.Products.Add(newProduct);
                context.SaveChanges();
                DisplayProducts();
                textNewProd.Text = "";
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedItem!=null)
            {
                var remProd = context.Products.Where(p => p.ProdName == listBoxProducts.SelectedItem.ToString()).Single();
                var remProdSup = context.ProductsSuppliers.Where(ps => ps.ProductId == remProd.ProductId).ToList();
                context.Products.Remove(remProd);
                context.SaveChanges();
                DisplayProducts();

            }
        }
    }
}

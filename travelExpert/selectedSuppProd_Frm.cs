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
    public partial class selectedSuppProd_Frm : Form
    {
        TravelExpertsContext context;
        public string[] prodSupp;
        public int supplierID;

        public selectedSuppProd_Frm()
        {
            InitializeComponent();
            context = new TravelExpertsContext();
        }

        private void selectedSuppProd_Frm_Load(object sender, EventArgs e)
        {
            //listBoxProducts.DataSource=context.Products.ToList();
            DisplayAvailableProducts();
        }

        private void DisplayAvailableProducts()
        {
            listBoxProducts.Items.Clear();
            string[] products = context.Products.Select(p => p.ProdName).ToArray();

            int filterProdLength = products.Length;
            for (int i = 0; i < prodSupp.Length; i++)
            {
                for (int j = 0; j < products.Length; j++)
                {
                    if (products[j] == prodSupp[i])
                    {
                        products[j] = "";
                        filterProdLength--;
                    }
                }
            }
            string[] filteredProd = new string[filterProdLength];
            int count = 0;
            foreach (string product in products)
            {
                if (product != "")
                {
                    filteredProd[count] = product;
                    count++;
                }
            }
            listBoxProducts.Items.AddRange(filteredProd);
        }

        private void btnAddSelect_Click(object sender, EventArgs e)
        {
            listBoxAddSelect.Items.Add(listBoxProducts.SelectedItem);
            Object temp = listBoxProducts.SelectedItem;
            listBoxProducts.Items.Remove(temp);
            //attempted to read from listbox to array. datasource does not seem to read out data from listbox
            //string[] myNewProducts=(string[])listBoxAddSelect.DataSource;
            //listBox1.Items.AddRange(myNewProducts);
            ProductsSupplier newProductsSupplier = new ProductsSupplier
            {
                SupplierId = supplierID,
                ProductId = context.Products.Where(p => p.ProdName == (string)temp).Select(p => p.ProductId).ToArray()[0]
            };
            context.ProductsSuppliers.Add(newProductsSupplier);
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            listBoxAddSelect.Items.Clear();
            this.Close();
        }
    }
}

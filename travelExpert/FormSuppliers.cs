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
    public partial class FormSuppliers : Form
    {
        TravelExpertsContext context;
        public FormSuppliers()
        {
            context = new TravelExpertsContext();
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (textNewSup != null & textNewSup.Text != "")
            {
                Supplier newSup = new Supplier()
                {
                    SupName = textNewSup.Text
                };
                context.Suppliers.Add(newSup);
                context.SaveChanges();
                DisplaySuppliers();
                textNewSup.Text = "";
            }
        }

        private void FormSuppliers_Load(object sender, EventArgs e)
        {
            listBoxSuppliers.Items.Clear();
            DisplaySuppliers();
        }
        private void DisplaySuppliers()
        {

            listBoxSuppliers.DataSource = context.Suppliers.Select(s => s.SupName).ToList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBoxSuppliers.SelectedItem != null)
            {
                var remSup = context.Suppliers.Where(s => s.SupName == listBoxSuppliers.SelectedItem.ToString()).Single();
                var remProdSup = context.ProductsSuppliers.Where(ps => ps.SupplierId == remSup.SupplierId).ToList();
                context.Suppliers.Remove(remSup);
                context.SaveChanges();
                DisplaySuppliers();

            }
        }
    }
}

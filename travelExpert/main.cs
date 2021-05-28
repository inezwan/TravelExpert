using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace travelExpert
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void btnAddSuppliers_Click(object sender, EventArgs e)
        {
            FormSupplierProducts formSuppliers = new FormSupplierProducts();
            formSuppliers.ShowDialog();
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            FormProductSuppliers formProducts = new FormProductSuppliers();
            formProducts.ShowDialog();
        }

        private void btnViewPkg_Click(object sender, EventArgs e)
        {
            PackagesForm packagesForm = new PackagesForm();
            packagesForm.ShowDialog();

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            FormProducts formProducts = new FormProducts();
            formProducts.ShowDialog();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            FormSuppliers formSuppliers = new FormSuppliers();
            formSuppliers.ShowDialog();
        }
    }
}

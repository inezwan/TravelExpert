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
    public partial class PackagesForm : Form
    {
        TravelExpertsContext context;
        private Supplier selectedSupplier = new Supplier();
        public string[] pIDs;

        public PackagesForm()
        {
            InitializeComponent();
        }

        private void PackagesForm_Load(object sender, EventArgs e)
        {
            context = new TravelExpertsContext();
            listBoxPackages.DataSource = context.Packages.ToList();
        }

        private void btnPkgProd_Click(object sender, EventArgs e)
        {
            if(listBoxPackages.SelectedItem!=null)
            {
                FormPkgProductscs formPkgProductscs = new FormPkgProductscs()
                { selectedPackage = (Package)listBoxPackages.SelectedItem };
                var r = formPkgProductscs.ShowDialog();
                if (r == DialogResult.OK)
                {
                    MessageBox.Show("Success");
                }
                    };
        }
    }
}

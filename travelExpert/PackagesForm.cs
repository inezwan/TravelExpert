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
        private Package package = new Package();
        public string[] pIDs;
        private PackagesProductsSupplier pckProdSupp = new PackagesProductsSupplier();

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
                    pckProdSupp = formPkgProductscs.newPackagesProductsSupplier;
                    context.PackagesProductsSuppliers.Add(pckProdSupp);

                    context.SaveChanges();
                }
            };
        }

        private void btnAddNewPackage_Click(object sender, EventArgs e)
        {
            FormNewPackage formNewPackage = new FormNewPackage()
            { MyNewPackage = package, 
                AddPackage = true };
            var r = formNewPackage.ShowDialog();
            if (r == DialogResult.OK)
            {
                package = formNewPackage.MyNewPackage;
                context.Packages.Add(package);
                context.SaveChanges();
                 MessageBox.Show("Entry Data Saved!");
                // listBoxPackages.Items.Clear();
                listBoxPackages.DataSource = context.Packages.ToList();
            }
        }

        private void btnEditPackage_Click(object sender, EventArgs e)
        {
            FormNewPackage formNewPackage = new FormNewPackage()
            { MyNewPackage = (Package)listBoxPackages.SelectedItem,
            AddPackage = false
            
            };
            
            var r = formNewPackage.ShowDialog();
            if (r == DialogResult.OK)
            {
                package = formNewPackage.MyNewPackage;
                context.Packages.Update(package);
                context.SaveChanges();
                MessageBox.Show("Entry Data Saved!");
                // listBoxPackages.Items.Clear();
                listBoxPackages.DataSource = context.Packages.ToList();
            }
        }
        private void btnRemovePackage_Click(object sender, EventArgs e)
        {
            if (listBoxPackages.SelectedItem != null) 
            {
                package = (Package)listBoxPackages.SelectedItem;
                //var myPkg=context.Packages.Where(p)
                var pkgProdSup = context.PackagesProductsSuppliers.Where(pps => pps.PackageId == package.PackageId).ToList();
                //var pkgSupp=context.ProductsSuppliers.Join(pkgProdSup,)
                context.Packages.Remove(package);
                context.SaveChanges(true);
                listBoxPackages.DataSource = context.Packages.ToList();
            }
        }
    }
}

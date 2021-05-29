using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
            context = new TravelExpertsContext();
            InitializeComponent();
        }

        private void PackagesForm_Load(object sender, EventArgs e)
        {
            DisplayPackages();
        }

        private void DisplayPackages()
        {
            lblPkgHeader.Text= "Id".PadRight(5) + "Name".PadRight(20) + "Description".PadRight(50) + "Start Date".PadRight(25) + "End Date".PadRight(25)
                + "Base Price".PadRight(15) + "Commission".PadRight(5);
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
                try
                {
                    package = formNewPackage.MyNewPackage;
                    context.Packages.Add(package);
                    context.SaveChanges();
                    MessageBox.Show("Entry Data Saved!");
                    // listBoxPackages.Items.Clear();
                    listBoxPackages.DataSource = context.Packages.ToList();
                }
                catch (DbUpdateException ex)
                {
                    HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }

            }
        }

        private void btnEditPackage_Click(object sender, EventArgs e)
        {
            if (listBoxPackages.SelectedItem != null)
            {
                FormNewPackage formNewPackage = new FormNewPackage()
                {
                    MyNewPackage = (Package)listBoxPackages.SelectedItem,
                    AddPackage = false

                };

                var r = formNewPackage.ShowDialog();
                if (r == DialogResult.OK)
                {
                    try
                    {
                        package = formNewPackage.MyNewPackage;
                        context.Packages.Update(package);
                        context.SaveChanges();
                        MessageBox.Show("Entry Data Saved!");
                        // listBoxPackages.Items.Clear();
                        DisplayPackages();
                    }
                    catch (DbUpdateConcurrencyException ex)
                    {
                        HandleConcurrencyError(ex);
                    }
                    catch (DbUpdateException ex)
                    {
                        HandleDatabaseError(ex);
                    }
                    catch (Exception ex)
                    {
                        HandleGeneralError(ex);
                    }

                }
            }
            else
            { MessageBox.Show("Please select a package", "Select Package"); }
        }
        private void btnRemovePackage_Click(object sender, EventArgs e)
        {
            if (listBoxPackages.SelectedItem != null) 
            {
                try
                {
                    package = (Package)listBoxPackages.SelectedItem;
                    //var myPkg=context.Packages.Where(p)
                    var pkgProdSup = context.PackagesProductsSuppliers.Where(pps => pps.PackageId == package.PackageId).ToList();
                    //var pkgSupp=context.ProductsSuppliers.Join(pkgProdSup,)
                    context.Packages.Remove(package);
                    context.SaveChanges(true);
                    DisplayPackages();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    HandleConcurrencyError(ex);
                }
                catch (DbUpdateException ex)
                {
                    HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
            }
        }
        //3 functions defined below to handle database exceptions
        private void HandleConcurrencyError(DbUpdateConcurrencyException ex)
        {
            ex.Entries.Single().Reload();

            var state = context.Entry(package).State;
            if (state == EntityState.Detached)
            {
                MessageBox.Show("Another user has deleted that package.",
                    "Concurrency Error");
            }
            else
            {
                string message = "Another user has updated that package.\n" +
                    "The current database values will be displayed.";
                MessageBox.Show(message, "Concurrency Error");
            }
            this.DisplayPackages();
        }

        private void HandleDatabaseError(DbUpdateException ex)
        {
            string errorMessage = "";
            var sqlException = (SqlException)ex.InnerException;
            foreach (SqlError error in sqlException.Errors)
            {
                errorMessage += "ERROR CODE:  " + error.Number + " " +
                                error.Message + "\n";
            }
            MessageBox.Show(errorMessage);
        }

        private void HandleGeneralError(Exception ex)
        {
            MessageBox.Show(ex.Message, ex.GetType().ToString());
        }
    }
}

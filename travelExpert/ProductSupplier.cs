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
    public partial class ProductSupplier : Form
    {
        TravelExpertsContext context;
        public string[] SupplierProduct;
        public int productID;
        public int productSupplierID;
        public ProductSupplier()
        {
            context = new TravelExpertsContext();
            InitializeComponent();
        }

        private void DisplayAvailableSuppliers()
        {
            listBoxAllSupplier.Items.Clear();
            string[] suppliers = context.Suppliers.Select(s => s.SupName).ToArray();

            int filterSupplierLength = suppliers.Length;
            for (int i = 0; i < SupplierProduct.Length; i++)
            {
                for (int j = 0; j < suppliers.Length; j++)
                {
                    if (suppliers[j] == SupplierProduct[i])
                    {
                        suppliers[j] = "";
                        filterSupplierLength--;
                    }
                }
            }
            string[] filteredSupplier = new string[filterSupplierLength];
            int count = 0;
            foreach (string supplier in suppliers)
            {
                if (supplier != "")
                {
                    filteredSupplier[count] = supplier;
                    count++;
                }
            }
            listBoxAllSupplier.Items.AddRange(filteredSupplier);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //context.SaveChanges();
            listBoxSelectedSupplier.Items.Clear();
            this.Close();
        }

        private void ProductSupplier_Load(object sender, EventArgs e)
        {
            DisplayAvailableSuppliers();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            //Adds selected item to list box on the right and removes it from listbox on the left
            listBoxSelectedSupplier.Items.Add(listBoxAllSupplier.SelectedItem);
            Object temp = listBoxAllSupplier.SelectedItem;
            listBoxAllSupplier.Items.Remove(temp);
            ProductsSupplier newProductsSupplier = new ProductsSupplier
            {
                ProductId = productID ,
                SupplierId = context.Suppliers.Where(s => s.SupName == (string)temp).Select(s => s.SupplierId).ToArray()[0]
            };
            context.ProductsSuppliers.Add(newProductsSupplier);
            context.SaveChanges();
            //productSupplierID = newProductsSupplier.ProductSupplierId;
            int SupplierId = context.Suppliers.Where(s => s.SupName == (string)temp).Select(s => s.SupplierId).ToArray()[0];
            productSupplierID = context.ProductsSuppliers.Where(p => p.ProductId == productID & p.SupplierId == SupplierId).Select(s => s.ProductSupplierId).ToArray()[0];


        }

        private void btnRemoveSupplier_Click(object sender, EventArgs e)
        {
            //Removes selected item from list box on the right and adds it to listbox on the left
            listBoxAllSupplier.Items.Add(listBoxSelectedSupplier.SelectedItem);
            Object temp = listBoxSelectedSupplier.SelectedItem;
            listBoxSelectedSupplier.Items.Remove(temp);

            int SupplierId = context.Suppliers.Where(s => s.SupName == (string)temp).Select(s => s.SupplierId).ToArray()[0];

            productSupplierID = context.ProductsSuppliers.Where(p => p.ProductId == productID & p.SupplierId == SupplierId).Select(s => s.ProductSupplierId).ToArray()[0];
            context.ProductsSuppliers.Remove(context.ProductsSuppliers.Find(productSupplierID));
            context.SaveChanges();
            
        }

    }
}

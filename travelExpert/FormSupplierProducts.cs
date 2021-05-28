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
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace travelExpert
{
    public partial class FormSupplierProducts : Form
    {
        TravelExpertsContext context;
        private Supplier selectedSupplier = new Supplier();
        public string [] pIDs;
        public FormSupplierProducts()
        {
            InitializeComponent();
        }

        private void DisplayProducts()
        {
            //lblHeader.Text = "ProductCode".PadRight(25) + "Name".PadRight(35) + "Version".PadRight(10) + "ReleaseDate".PadRight(10);
            context = new TravelExpertsContext();
            listBoxSuppliers.DataSource = context.Suppliers.ToList();
            

//            Object[] cIds = context.Customers.Select(c => (Object)c.CustomerId).ToArray();
//            customerIdCBox.Items.AddRange(cIds);

//            var invoices =
//invoiceList.Join(customerList, i => i.CustomerID, c => c.CustomerID,
//(i, c) => new { c.Name, i.InvoiceDate, i.InvoiceTotal }).Where(ci => ci.InvoiceTotal > 150).OrderBy(ci => ci.Name).ThenBy(ci => ci.InvoiceDate)
//.Select(ci => new { ci.Name, ci.InvoiceTotal });

        }

        private void FormSuppliers_Load(object sender, EventArgs e)
        {
            DisplayProducts();
            DisplayAvailableProducts();
        }

        private void listBoxSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxProducts.Items.Clear();
            selectedSupplier = (Supplier)listBoxSuppliers.SelectedItem;


            //Object[] pIDs = context.Suppliers.Join(context.ProductsSuppliers, s => s.SupplierId, p => p.SupplierId, (s, p) => new { p.ProductId, s.SupplierId })
            //    .Where(ps => ps.SupplierId == selectedSupplier.SupplierId).Select(ps => new { ps.ProductId, ps.SupplierId }).ToArray();

           pIDs = context.Suppliers.Join(context.ProductsSuppliers, s => s.SupplierId, p => p.SupplierId, (s, p) => new { p.ProductId, s.SupplierId })
                .Join(context.Products, ps => ps.ProductId, p => p.ProductId, (ps, p) => new { ps.ProductId, p.ProdName,ps.SupplierId }).Where(ps => ps.SupplierId == selectedSupplier.SupplierId).Select(p=>p.ProdName).ToArray();
            
                listBoxProducts.Items.AddRange(pIDs);
            DisplayAvailableProducts();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            //ListBox mainListBoxSuppProd = new ListBox();
            //mainListBoxSuppProd.DataSource = context.Products.ToList();
            //selectedSuppProd_Frm suppProd_Frm = new selectedSuppProd_Frm()
            //{ prodSupp = pIDs,
            //supplierID=selectedSupplier.SupplierId};
            //suppProd_Frm.ShowDialog();


            listBoxProducts.Items.Add(comboBoxProducts.SelectedItem);
            Object temp = comboBoxProducts.SelectedItem;
            comboBoxProducts.Items.Remove(temp);
            ProductsSupplier newProductsSupplier = new ProductsSupplier
            {
                ProductId = context.Products.Where(p => p.ProdName == (string)temp).Select(p => p.ProductId).ToArray()[0],
                SupplierId = selectedSupplier.SupplierId
            };
            context.ProductsSuppliers.Add(newProductsSupplier);
            context.SaveChanges();


            listBoxProducts.Items.Clear();
            
            
            selectedSupplier = (Supplier)listBoxSuppliers.SelectedItem;


            //Object[] pIDs = context.Suppliers.Join(context.ProductsSuppliers, s => s.SupplierId, p => p.SupplierId, (s, p) => new { p.ProductId, s.SupplierId })
            //    .Where(ps => ps.SupplierId == selectedSupplier.SupplierId).Select(ps => new { ps.ProductId, ps.SupplierId }).ToArray();

            pIDs = context.Suppliers.Join(context.ProductsSuppliers, s => s.SupplierId, p => p.SupplierId, (s, p) => new { p.ProductId, s.SupplierId })
                 .Join(context.Products, ps => ps.ProductId, p => p.ProductId, (ps, p) => new { ps.ProductId, p.ProdName, ps.SupplierId }).Where(ps => ps.SupplierId == selectedSupplier.SupplierId).Select(p => p.ProdName).ToArray();

            listBoxProducts.Items.AddRange(pIDs);





        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedItem!=null)
            {
                //ProductsSupplier removeProductsSupplier = new ProductsSupplier()
                //{
                //    SupplierId = selectedSupplier.SupplierId,
                //    ProductId = context.Products.Where(p => p.ProdName == (string)listBoxProducts.SelectedItem).Select(p => p.ProductId).ToArray()[0]
                //};
                int pID = context.Products.Where(p => p.ProdName == (string)listBoxProducts.SelectedItem).Select(p => p.ProductId).ToArray()[0];
                ProductsSupplier removeProductsSupplier = context.ProductsSuppliers.Where(s => s.SupplierId == selectedSupplier.SupplierId).Where(p => p.ProductId == pID).ToArray()[0];
                context.ProductsSuppliers.Remove(removeProductsSupplier);
                context.SaveChanges();
                listBoxProducts.Items.Clear();
                selectedSupplier = (Supplier)listBoxSuppliers.SelectedItem;


                //Object[] pIDs = context.Suppliers.Join(context.ProductsSuppliers, s => s.SupplierId, p => p.SupplierId, (s, p) => new { p.ProductId, s.SupplierId })
                //    .Where(ps => ps.SupplierId == selectedSupplier.SupplierId).Select(ps => new { ps.ProductId, ps.SupplierId }).ToArray();

                pIDs = context.Suppliers.Join(context.ProductsSuppliers, s => s.SupplierId, p => p.SupplierId, (s, p) => new { p.ProductId, s.SupplierId })
                     .Join(context.Products, ps => ps.ProductId, p => p.ProductId, (ps, p) => new { ps.ProductId, p.ProdName, ps.SupplierId }).Where(ps => ps.SupplierId == selectedSupplier.SupplierId).Select(p => p.ProdName).ToArray();

                listBoxProducts.Items.AddRange(pIDs);
                DisplayAvailableProducts();

            }
        }

        private void DisplayAvailableProducts()
        {
            comboBoxProducts.Items.Clear();
            string[] products = context.Products.Select(p => p.ProdName).ToArray();

            int filterProdLength = products.Length;
            for (int i = 0; i < pIDs.Length; i++)
            {
                for (int j = 0; j < products.Length; j++)
                {
                    if (products[j] == pIDs[i])
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
            comboBoxProducts.Items.AddRange(filteredProd);
        }
    }
}

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
    public partial class FormProductSuppliers : Form
    {
        TravelExpertsContext context;
        private Product selectedProduct = new Product();
        public string[] SupplierArray;
        public FormProductSuppliers()
        {
            InitializeComponent();
        }

        
        private void DisplayProducts()
        {
            context = new TravelExpertsContext();
            listBoxProducts.DataSource = context.Products.Select(p=>p.ProdName).ToList();
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            DisplayProducts();
            DisplaySuppliersCombo();
            
        }

        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxSuppliers.Items.Clear();
            if (listBoxProducts.SelectedItem!=null)
            {
                displaySuppliers();
                DisplaySuppliersCombo();
            }
        }

        private void displaySuppliers()
        {
            selectedProduct = context.Products.Where(p => p.ProdName == (string)listBoxProducts.SelectedItem).ToArray()[0];
            SupplierArray = context.Products.Join(context.ProductsSuppliers, p => p.ProductId, s => s.ProductId, (p, s) => new { p.ProductId, s.SupplierId })
                .Join(context.Suppliers, ps => ps.SupplierId, s => s.SupplierId, (ps, p) => new { ps.SupplierId, p.SupName, ps.ProductId }).Where(ps => ps.ProductId == selectedProduct.ProductId).Select(s => s.SupName).ToArray();
            listBoxSuppliers.Items.AddRange(SupplierArray);
        }

        private void DisplaySuppliersCombo()
        {
            //comboBoxSuppliers.DataSource = allProducts;
            //comboBoxProducts.DisplayMember = "SupName";
            //comboBoxProducts.ValueMember = "SupId";

            comboBoxSuppliers.Items.Clear();
            string[] suppliers = context.Suppliers.Select(s => s.SupName).ToArray();

            int filterSupplierLength = suppliers.Length;
            for (int i = 0; i < SupplierArray.Length; i++)
            {
                for (int j = 0; j < suppliers.Length; j++)
                {
                    if (suppliers[j] == SupplierArray[i])
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
            comboBoxSuppliers.Items.AddRange(filteredSupplier);
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            //ProductSupplier productSupplier = new ProductSupplier()
            //{
            //    SupplierProduct= SupplierArray,
            //    productID=selectedProduct.ProductId
            //};
            //productSupplier.ShowDialog();

            listBoxSuppliers.Items.Add(comboBoxSuppliers.SelectedItem);
            Object temp = comboBoxSuppliers.SelectedItem;
            comboBoxSuppliers.Items.Remove(temp);
            ProductsSupplier newProductsSupplier = new ProductsSupplier
            {
                ProductId = selectedProduct.ProductId,
                SupplierId = context.Suppliers.Where(s => s.SupName == (string)temp).Select(s => s.SupplierId).ToArray()[0]
            };
            context.ProductsSuppliers.Add(newProductsSupplier);
            context.SaveChanges();

            listBoxSuppliers.Items.Clear();
            displaySuppliers();
        }

        private void btnRemoveSupplier_Click(object sender, EventArgs e)
        {
            int supplierId = context.Suppliers.Where(s => s.SupName == (string)listBoxSuppliers.SelectedItem).Select(s => s.SupplierId).ToArray()[0];
            int productId = context.Products.Where(p => p.ProdName == (string)listBoxProducts.SelectedItem).Select(s => s.ProductId).ToArray()[0];
            int productSupplierID = context.ProductsSuppliers.Where(p => p.ProductId == productId & p.SupplierId == supplierId).Select(s => s.ProductSupplierId).ToArray()[0];
            context.ProductsSuppliers.Remove(context.ProductsSuppliers.Find(productSupplierID));
            context.SaveChanges();
            listBoxSuppliers.Items.Clear();
            displaySuppliers();
            DisplaySuppliersCombo();
        }





        //private void btnAddProduct_Click(object sender, EventArgs e)
        //{
        //    //ListBox mainListBoxSuppProd = new ListBox();
        //    //mainListBoxSuppProd.DataSource = context.Products.ToList();
        //    selectedSuppProd_Frm suppProd_Frm = new selectedSuppProd_Frm()
        //    {
        //        prodSupp = pIDs,
        //        supplierID = selectedSupplier.SupplierId
        //    };
        //    suppProd_Frm.ShowDialog();
        //    listBoxProducts.Items.Clear();
        //    selectedSupplier = (Supplier)listBoxSuppliers.SelectedItem;


        //    //Object[] pIDs = context.Suppliers.Join(context.ProductsSuppliers, s => s.SupplierId, p => p.SupplierId, (s, p) => new { p.ProductId, s.SupplierId })
        //    //    .Where(ps => ps.SupplierId == selectedSupplier.SupplierId).Select(ps => new { ps.ProductId, ps.SupplierId }).ToArray();

        //    pIDs = context.Suppliers.Join(context.ProductsSuppliers, s => s.SupplierId, p => p.SupplierId, (s, p) => new { p.ProductId, s.SupplierId })
        //         .Join(context.Products, ps => ps.ProductId, p => p.ProductId, (ps, p) => new { ps.ProductId, p.ProdName, ps.SupplierId }).Where(ps => ps.SupplierId == selectedSupplier.SupplierId).Select(p => p.ProdName).ToArray();

        //    listBoxProducts.Items.AddRange(pIDs);





        //}

        //private void btnRemove_Click(object sender, EventArgs e)
        //{
        //    if (listBoxProducts.SelectedItem != null)
        //    {

        //        int pID = context.Products.Where(p => p.ProdName == (string)listBoxProducts.SelectedItem).Select(p => p.ProductId).ToArray()[0];
        //        ProductsSupplier removeProductsSupplier = context.ProductsSuppliers.Where(s => s.SupplierId == selectedSupplier.SupplierId).Where(p => p.ProductId == pID).ToArray()[0];
        //        context.ProductsSuppliers.Remove(removeProductsSupplier);
        //        context.SaveChanges();
        //        listBoxProducts.Items.Clear();
        //        selectedSupplier = (Supplier)listBoxSuppliers.SelectedItem;



        //        pIDs = context.Suppliers.Join(context.ProductsSuppliers, s => s.SupplierId, p => p.SupplierId, (s, p) => new { p.ProductId, s.SupplierId })
        //             .Join(context.Products, ps => ps.ProductId, p => p.ProductId, (ps, p) => new { ps.ProductId, p.ProdName, ps.SupplierId }).Where(ps => ps.SupplierId == selectedSupplier.SupplierId).Select(p => p.ProdName).ToArray();

        //        listBoxProducts.Items.AddRange(pIDs);




    }
}

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
    public partial class FormSuppliers : Form
    {
        TravelExpertsContext context;
        private Supplier selectedSupplier = new Supplier();
        public FormSuppliers()
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
        }

        private void listBoxSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxProducts.Items.Clear();
            selectedSupplier = (Supplier)listBoxSuppliers.SelectedItem;


            //Object[] pIDs = context.Suppliers.Join(context.ProductsSuppliers, s => s.SupplierId, p => p.SupplierId, (s, p) => new { p.ProductId, s.SupplierId })
            //    .Where(ps => ps.SupplierId == selectedSupplier.SupplierId).Select(ps => new { ps.ProductId, ps.SupplierId }).ToArray();

            Object[] pIDs = context.Suppliers.Join(context.ProductsSuppliers, s => s.SupplierId, p => p.SupplierId, (s, p) => new { p.ProductId, s.SupplierId })
                .Join(context.Products, ps => ps.ProductId, p => p.ProductId, (ps, p) => new { ps.ProductId, p.ProdName,ps.SupplierId }).Where(ps => ps.SupplierId == selectedSupplier.SupplierId).Select(p=>p.ProdName).ToArray();
            
                listBoxProducts.Items.AddRange(pIDs);
        }
    }
}

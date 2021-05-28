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
    public partial class FormPkgProductscs : Form
    {
        public TravelExpertsContext context;
        public Package selectedPackage = new Package();
        //public object[] products;
        public Supplier[] suppliers;
        public string[] prodSupp;
        public PackagesProductsSupplier newPackagesProductsSupplier;
        public int selectedProductId;

        public FormPkgProductscs()
        {
            InitializeComponent();
            context = new TravelExpertsContext();
        }

        private void FormPkgProductscs_Load(object sender, EventArgs e)
        {


            var products = context.Packages.Join(context.PackagesProductsSuppliers, p => p.PackageId, pp => pp.PackageId, (p, pp) => new { p.PackageId, pp.ProductSupplierId }).Where(p => p.PackageId == selectedPackage.PackageId)
                 .Join(context.ProductsSuppliers, pps => pps.ProductSupplierId, ps => ps.ProductSupplierId, (pps, ps) => new { ps.Product, ps.Supplier }).Select(ps => new { ps.Product.ProdName, ps.Supplier.SupName, ps.Product.ProductId }).ToArray();
            //suppliers = context.Packages.Join(context.PackagesProductsSuppliers, p => p.PackageId, pp => pp.PackageId, (p, pp) => new { p.PackageId, pp.ProductSupplierId }).Where(p => p.PackageId == selectedPackage.PackageId)
            //    .Join(context.ProductsSuppliers, pps => pps.ProductSupplierId, ps => ps.ProductSupplierId, (pps, ps) => new { ps.Product, ps.Supplier }).Select(ps => ps.Supplier).ToArray();

            //for (int i = 0; i < products.Length; i++)
            //{ prodSupp[0] = products[0].ProdName + " " + suppliers[0].SupName; }
            //context.Products.Join(context.ProductsSuppliers, p => p.ProductId, s => s.ProductId, (p, s) => new { p.ProductId, s.SupplierId })
            //.Join(context.Suppliers, ps => ps.SupplierId, s => s.SupplierId, (ps, p) => new { ps.SupplierId, p.SupName, ps.ProductId }).Where(ps => ps.ProductId == selectedProduct.ProductId).Select(s => s.SupName).ToArray();
            //listBoxPkgProd.Items.AddRange(products);
            List<Product> allProducts = context.Products.ToList();
            listBoxPkgProd.Items.Add("Product Name".PadRight(20) + "Supplier Name".PadRight(30)+"\n");
            foreach (var product in products)
            {
                listBoxPkgProd.Items.Add(product.ProdName.PadRight(20) + product.SupName.PadRight(30));
                Product aProduct = context.Products.Find(product.ProductId);
                if (allProducts.Contains(aProduct))
                { allProducts.Remove(aProduct); }

            }

            comboBoxProducts.DataSource = allProducts;
            comboBoxProducts.DisplayMember = "ProdName";
            comboBoxProducts.ValueMember = "ProductId";
            //if (comboBoxProducts.SelectedItem != null)

            //{
            //    listBoxSelectSupp.DataSource = context.ProductsSuppliers.Where(ps => ps.ProductId == Convert.ToInt32(comboBoxProducts.SelectedValue)).ToList();
            //}

        }

        private void comboBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listBoxSelectSupp.Items.Clear();
            Product selectedProd = (Product)comboBoxProducts.SelectedItem;
            selectedProductId = selectedProd.ProductId;

            listBoxSelectSupp.DataSource = context.ProductsSuppliers.Where(ps => ps.ProductId ==selectedProductId).Join(context.Suppliers,p=>p.SupplierId,s=>s.SupplierId, (p,s)=>new Supplier{SupName=s.SupName, SupplierId=s.SupplierId}).ToList();
           
            //listBoxSelectSupp.Items.Add("Hello");
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            Supplier selectSupplier=(Supplier)listBoxSelectSupp.SelectedItem;
            var selectedProdSupp = context.ProductsSuppliers.Where(ps => ps.ProductId == selectedProductId).Where(ps => ps.SupplierId == selectSupplier.SupplierId).Single();
            //Where(ps => ps.SupplierId == selectSupplier.SupplierId)
            int selectedProductSupplierId = selectedProdSupp.ProductSupplierId;
            newPackagesProductsSupplier = new PackagesProductsSupplier
            {
                PackageId = selectedPackage.PackageId,
                ProductSupplierId = selectedProductSupplierId
            };


            listBoxPkgProd.Items.Add(comboBoxProducts.SelectedItem.ToString().PadRight(20) + listBoxSelectSupp.SelectedItem.ToString().PadRight(30));
            DialogResult = DialogResult.OK;
        }
    }
}

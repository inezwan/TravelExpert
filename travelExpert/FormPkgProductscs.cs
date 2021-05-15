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
        public Product[] products;
        public Supplier[] suppliers;
        public string[,] prodSupp;

        public FormPkgProductscs()
        {
            InitializeComponent();
        }

        private void FormPkgProductscs_Load(object sender, EventArgs e)
        {
            context = new TravelExpertsContext();
            products = context.Packages.Join(context.PackagesProductsSuppliers, p => p.PackageId, pp => pp.PackageId, (p, pp) => new { p.PackageId, pp.ProductSupplierId }).Where(p => p.PackageId == selectedPackage.PackageId)
                .Join(context.ProductsSuppliers, pps => pps.ProductSupplierId, ps => ps.ProductSupplierId, (pps, ps) => new { ps.Product, ps.Supplier }).Select(ps=>ps.Product).ToArray();
            suppliers = context.Packages.Join(context.PackagesProductsSuppliers, p => p.PackageId, pp => pp.PackageId, (p, pp) => new { p.PackageId, pp.ProductSupplierId }).Where(p => p.PackageId == selectedPackage.PackageId)
                .Join(context.ProductsSuppliers, pps => pps.ProductSupplierId, ps => ps.ProductSupplierId, (pps, ps) => new { ps.Product, ps.Supplier }).Select(ps => ps.Supplier).ToArray();

            for (int i=0; i<products.Length;i++)
                for(int j=0;j<suppliers.Length;j++)
                { if (j == 0)
                        prodSupp[i, j] = products[i].ProdName;
                    if (j == 1)
                        prodSupp[i, j] = suppliers[i].SupName;
                            }
            //context.Products.Join(context.ProductsSuppliers, p => p.ProductId, s => s.ProductId, (p, s) => new { p.ProductId, s.SupplierId })
            //.Join(context.Suppliers, ps => ps.SupplierId, s => s.SupplierId, (ps, p) => new { ps.SupplierId, p.SupName, ps.ProductId }).Where(ps => ps.ProductId == selectedProduct.ProductId).Select(s => s.SupName).ToArray();
            listBoxPkgProd.Items.AddRange(prodSupp);
        }
    }
}

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
        public FormSuppliers()
        {
            InitializeComponent();
        }

        private void DisplayProducts()
        {
            //lblHeader.Text = "ProductCode".PadRight(25) + "Name".PadRight(35) + "Version".PadRight(10) + "ReleaseDate".PadRight(10);
            context = new TravelExpertsContext();
            listBoxSuppliers.DataSource = context.Suppliers.ToList();

        }

        private void FormSuppliers_Load(object sender, EventArgs e)
        {
            DisplayProducts();
        }
    }
}

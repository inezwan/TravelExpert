using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace travelExpert
{
    public partial class FormNewPackage : Form
    {
        
        public FormNewPackage()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtPackageName.Text = "";
            startDateTimePicker.Value = DateTime.Today;
            endDateTimePicker.Value = DateTime.Today;
            txtDescription.Text = "";
            txtBasePrice.Text = "";
            txtComission.Text = "";
        }

        private void FormNewPackage_Load(object sender, EventArgs e)
        {

        }
    }
}

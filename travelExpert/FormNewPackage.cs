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
    public partial class FormNewPackage : Form
    {
        public Package MyNewPackage { get; set; }
        public bool AddPackage { get; set; }
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
            if (AddPackage == false)
            {
                txtPackageID.Text = MyNewPackage.PackageId.ToString();
                txtPackageName.Text = MyNewPackage.PkgName;
                startDateTimePicker.Value = Convert.ToDateTime(MyNewPackage.PkgStartDate);
                endDateTimePicker.Value = Convert.ToDateTime(MyNewPackage.PkgEndDate);
                txtDescription.Text = MyNewPackage.PkgDesc;
                txtBasePrice.Text = MyNewPackage.PkgBasePrice.ToString("C2");
                txtComission.Text = MyNewPackage.PkgAgencyCommission.ToString(); // How to display the currency (C2)????
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (AddPackage)
            {
                MyNewPackage = new Package()
                {
                    PkgName = txtPackageName.Text,
                    PkgStartDate = (startDateTimePicker.Value),
                    PkgEndDate = (endDateTimePicker.Value),
                    PkgDesc = txtDescription.Text,
                    PkgBasePrice = Convert.ToDecimal(txtBasePrice.Text),
                    PkgAgencyCommission = Convert.ToDecimal(txtComission.Text)
                };
            } 
            else
            {
                MyNewPackage.PkgName = txtPackageName.Text;
                MyNewPackage.PkgStartDate = (startDateTimePicker.Value);
                MyNewPackage.PkgEndDate = (endDateTimePicker.Value);
                MyNewPackage.PkgDesc = txtDescription.Text;
                MyNewPackage.PkgBasePrice = Convert.ToDecimal(txtBasePrice.Text.Split("$")[1]);

                MyNewPackage.PkgAgencyCommission = Convert.ToDecimal(txtComission.Text);
            }
                
            DialogResult = DialogResult.OK;
        }
    }
}

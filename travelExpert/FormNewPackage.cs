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
            if (IsValidData())
            {
                if (AddPackage)
                    MyNewPackage = new Package();
                LoadInputData();
                DialogResult = DialogResult.OK;
            }


            //{
            //    PkgName = txtPackageName.Text,
            //    PkgStartDate = (startDateTimePicker.Value),
            //    PkgEndDate = (endDateTimePicker.Value),
            //    PkgDesc = txtDescription.Text,
            //    PkgBasePrice = Convert.ToDecimal(txtBasePrice.Text),
            //    PkgAgencyCommission = Convert.ToDecimal(txtComission.Text)
            //};

            //else
            //{

            //    MyNewPackage.PkgName = txtPackageName.Text;
            //    MyNewPackage.PkgStartDate = (startDateTimePicker.Value);
            //    MyNewPackage.PkgEndDate = (endDateTimePicker.Value);
            //    MyNewPackage.PkgDesc = txtDescription.Text;
            //    MyNewPackage.PkgBasePrice = Convert.ToDecimal(txtBasePrice.Text.Split("$")[1]);

            //    MyNewPackage.PkgAgencyCommission = Convert.ToDecimal(txtComission.Text);
            //}


        }

        private void LoadInputData()
        {
            MyNewPackage.PkgName = txtPackageName.Text;
            MyNewPackage.PkgStartDate = (startDateTimePicker.Value);
            MyNewPackage.PkgEndDate = (endDateTimePicker.Value);
            MyNewPackage.PkgDesc = txtDescription.Text;
            if (Decimal.TryParse(txtBasePrice.Text, out _))
                MyNewPackage.PkgBasePrice = Convert.ToDecimal(txtBasePrice.Text);
            else
            { MyNewPackage.PkgBasePrice = Convert.ToDecimal(txtBasePrice.Text.Split("$")[1]); }

            MyNewPackage.PkgAgencyCommission = Convert.ToDecimal(txtComission.Text);
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            foreach (Control x in this.Controls)
            { if (x is TextBox & x!=txtPackageID)
                {
                    errorMessage += Validator.IsPresent(x.Text, x.Tag.ToString());
                }
            }
            errorMessage += Validator.IsDecimal(txtBasePrice.Text, txtBasePrice.Tag.ToString());
            errorMessage += Validator.IsDecimal(txtComission.Text, txtComission.Tag.ToString());
            if (errorMessage=="")
                errorMessage += Validator.IsLessThanBase(txtComission.Text, txtBasePrice.Text, txtComission.Tag.ToString());
            errorMessage += Validator.CheckDate(startDateTimePicker.Value, endDateTimePicker.Value);

            //errorMessage += Validator.IsPresent(txtCode.Text, txtCode.Tag.ToString());
            //errorMessage += Validator.IsMoreThanNumber(txtCode.Text, txtCode.Tag.ToString(), 10);
            //errorMessage += Validator.IsPresent(txtName.Text, txtName.Tag.ToString());
            //errorMessage += Validator.IsMoreThanNumber(txtName.Text, txtName.Tag.ToString(), 50);
            //errorMessage += Validator.IsPresent(txtVersion.Text, txtVersion.Tag.ToString());
            //errorMessage += Validator.IsDecimal(txtVersion.Text, txtVersion.Tag.ToString());
            //errorMessage += Validator.IsDecimalLength(txtVersion.Text, txtVersion.Tag.ToString());
            //errorMessage += Validator.IsPresent(txtDate.Text, txtDate.Tag.ToString());
            //errorMessage += Validator.IsDate(txtDate.Text, txtDate.Tag.ToString());


            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }
    }
   
}

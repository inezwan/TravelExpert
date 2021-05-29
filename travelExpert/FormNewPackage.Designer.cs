
namespace travelExpert
{
    partial class FormNewPackage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblPackageName = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.lblCommission = new System.Windows.Forms.Label();
            this.txtPackageID = new System.Windows.Forms.TextBox();
            this.txtPackageName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.txtComission = new System.Windows.Forms.TextBox();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Package ID";
            // 
            // lblPackageName
            // 
            this.lblPackageName.AutoSize = true;
            this.lblPackageName.Location = new System.Drawing.Point(58, 99);
            this.lblPackageName.Name = "lblPackageName";
            this.lblPackageName.Size = new System.Drawing.Size(107, 20);
            this.lblPackageName.TabIndex = 1;
            this.lblPackageName.Text = "Package Name";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(58, 232);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(76, 20);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(58, 281);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(70, 20);
            this.lblEndDate.TabIndex = 3;
            this.lblEndDate.Text = "End Date";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(58, 347);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(85, 20);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description";
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Location = new System.Drawing.Point(58, 497);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(76, 20);
            this.lblBasePrice.TabIndex = 5;
            this.lblBasePrice.Text = "Base Price";
            // 
            // lblCommission
            // 
            this.lblCommission.AutoSize = true;
            this.lblCommission.Location = new System.Drawing.Point(58, 555);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(90, 20);
            this.lblCommission.TabIndex = 6;
            this.lblCommission.Text = "Commission";
            // 
            // txtPackageID
            // 
            this.txtPackageID.Location = new System.Drawing.Point(167, 27);
            this.txtPackageID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPackageID.Name = "txtPackageID";
            this.txtPackageID.ReadOnly = true;
            this.txtPackageID.Size = new System.Drawing.Size(243, 27);
            this.txtPackageID.TabIndex = 7;
            // 
            // txtPackageName
            // 
            this.txtPackageName.Location = new System.Drawing.Point(167, 99);
            this.txtPackageName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPackageName.Multiline = true;
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.Size = new System.Drawing.Size(243, 97);
            this.txtPackageName.TabIndex = 8;
            this.txtPackageName.Tag = "Package Name";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(167, 347);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(243, 115);
            this.txtDescription.TabIndex = 9;
            this.txtDescription.Tag = "Package description";
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Location = new System.Drawing.Point(167, 497);
            this.txtBasePrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(243, 27);
            this.txtBasePrice.TabIndex = 10;
            this.txtBasePrice.Tag = "Base Price";
            // 
            // txtComission
            // 
            this.txtComission.Location = new System.Drawing.Point(167, 555);
            this.txtComission.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtComission.Name = "txtComission";
            this.txtComission.Size = new System.Drawing.Size(243, 27);
            this.txtComission.TabIndex = 11;
            this.txtComission.Tag = "Commission";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(167, 232);
            this.startDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(243, 27);
            this.startDateTimePicker.TabIndex = 12;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(167, 281);
            this.endDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(243, 27);
            this.endDateTimePicker.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(167, 623);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 31);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(325, 623);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 31);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormNewPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 676);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.txtComission);
            this.Controls.Add(this.txtBasePrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtPackageName);
            this.Controls.Add(this.txtPackageID);
            this.Controls.Add(this.lblCommission);
            this.Controls.Add(this.lblBasePrice);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblPackageName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormNewPackage";
            this.Text = "FormNewPackage";
            this.Load += new System.EventHandler(this.FormNewPackage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPackageName;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.Label lblCommission;
        private System.Windows.Forms.TextBox txtPackageID;
        private System.Windows.Forms.TextBox txtPackageName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.TextBox txtComission;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
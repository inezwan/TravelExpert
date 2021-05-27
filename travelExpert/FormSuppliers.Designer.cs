
namespace travelExpert
{
    partial class FormSuppliers
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.textNewSup = new System.Windows.Forms.TextBox();
            this.listBoxSuppliers = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnAddProduct);
            this.groupBox1.Controls.Add(this.textNewSup);
            this.groupBox1.Controls.Add(this.listBoxSuppliers);
            this.groupBox1.Location = new System.Drawing.Point(65, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 498);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Suppliers";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(173, 425);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(143, 40);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove Supplier";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(322, 368);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(112, 38);
            this.btnAddProduct.TabIndex = 2;
            this.btnAddProduct.Text = "Add Supplier";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // textNewSup
            // 
            this.textNewSup.Location = new System.Drawing.Point(30, 368);
            this.textNewSup.Name = "textNewSup";
            this.textNewSup.Size = new System.Drawing.Size(254, 27);
            this.textNewSup.TabIndex = 1;
            // 
            // listBoxSuppliers
            // 
            this.listBoxSuppliers.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxSuppliers.FormattingEnabled = true;
            this.listBoxSuppliers.ItemHeight = 18;
            this.listBoxSuppliers.Location = new System.Drawing.Point(30, 26);
            this.listBoxSuppliers.Name = "listBoxSuppliers";
            this.listBoxSuppliers.Size = new System.Drawing.Size(319, 328);
            this.listBoxSuppliers.TabIndex = 0;
            // 
            // FormSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 548);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSuppliers";
            this.Text = "FormSuppliers";
            this.Load += new System.EventHandler(this.FormSuppliers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox textNewSup;
        private System.Windows.Forms.ListBox listBoxSuppliers;
    }
}
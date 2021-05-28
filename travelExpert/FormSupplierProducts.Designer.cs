
namespace travelExpert
{
    partial class FormSupplierProducts
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
            this.listBoxSuppliers = new System.Windows.Forms.ListBox();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblSuppliers = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblRemove = new System.Windows.Forms.Label();
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBoxSuppliers
            // 
            this.listBoxSuppliers.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxSuppliers.FormattingEnabled = true;
            this.listBoxSuppliers.ItemHeight = 18;
            this.listBoxSuppliers.Location = new System.Drawing.Point(57, 76);
            this.listBoxSuppliers.Name = "listBoxSuppliers";
            this.listBoxSuppliers.Size = new System.Drawing.Size(412, 292);
            this.listBoxSuppliers.TabIndex = 0;
            this.listBoxSuppliers.SelectedIndexChanged += new System.EventHandler(this.listBoxSuppliers_SelectedIndexChanged);
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 18;
            this.listBoxProducts.Location = new System.Drawing.Point(534, 76);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(299, 292);
            this.listBoxProducts.TabIndex = 1;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(726, 400);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(107, 58);
            this.btnAddProduct.TabIndex = 2;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(563, 479);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(107, 29);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblSuppliers
            // 
            this.lblSuppliers.AutoSize = true;
            this.lblSuppliers.Location = new System.Drawing.Point(57, 32);
            this.lblSuppliers.Name = "lblSuppliers";
            this.lblSuppliers.Size = new System.Drawing.Size(73, 20);
            this.lblSuppliers.TabIndex = 4;
            this.lblSuppliers.Text = "Suppliers:";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(534, 32);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(69, 20);
            this.lblProduct.TabIndex = 5;
            this.lblProduct.Text = "Products:";
            // 
            // lblRemove
            // 
            this.lblRemove.Location = new System.Drawing.Point(491, 435);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(229, 76);
            this.lblRemove.TabIndex = 11;
            this.lblRemove.Text = "Please select the Product from the listbox that you wish to remove:";
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(491, 404);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(229, 28);
            this.comboBoxProducts.TabIndex = 10;
            // 
            // FormSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 560);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblRemove);
            this.Controls.Add(this.comboBoxProducts);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblSuppliers);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.listBoxProducts);
            this.Controls.Add(this.listBoxSuppliers);
            this.Name = "FormSuppliers";
            this.Text = "FormSuppliers";
            this.Load += new System.EventHandler(this.FormSuppliers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSuppliers;
        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblSuppliers;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblRemove;
        private System.Windows.Forms.ComboBox comboBoxProducts;
    }
}
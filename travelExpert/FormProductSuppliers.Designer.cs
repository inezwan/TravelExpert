
namespace travelExpert
{
    partial class FormProductSuppliers
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
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.btnRemoveSupplier = new System.Windows.Forms.Button();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblSuppliers = new System.Windows.Forms.Label();
            this.comboBoxSuppliers = new System.Windows.Forms.ComboBox();
            this.lblRemove = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxSuppliers
            // 
            this.listBoxSuppliers.FormattingEnabled = true;
            this.listBoxSuppliers.ItemHeight = 20;
            this.listBoxSuppliers.Location = new System.Drawing.Point(364, 78);
            this.listBoxSuppliers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxSuppliers.Name = "listBoxSuppliers";
            this.listBoxSuppliers.Size = new System.Drawing.Size(514, 364);
            this.listBoxSuppliers.TabIndex = 0;
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 20;
            this.listBoxProducts.Location = new System.Drawing.Point(46, 78);
            this.listBoxProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(265, 364);
            this.listBoxProducts.TabIndex = 1;
            this.listBoxProducts.SelectedIndexChanged += new System.EventHandler(this.listBoxProducts_SelectedIndexChanged);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Location = new System.Drawing.Point(755, 460);
            this.btnAddSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(123, 31);
            this.btnAddSupplier.TabIndex = 4;
            this.btnAddSupplier.Text = "Add Supplier";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // btnRemoveSupplier
            // 
            this.btnRemoveSupplier.Location = new System.Drawing.Point(739, 508);
            this.btnRemoveSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveSupplier.Name = "btnRemoveSupplier";
            this.btnRemoveSupplier.Size = new System.Drawing.Size(139, 31);
            this.btnRemoveSupplier.TabIndex = 5;
            this.btnRemoveSupplier.Text = "Remove Supplier";
            this.btnRemoveSupplier.UseVisualStyleBackColor = true;
            this.btnRemoveSupplier.Click += new System.EventHandler(this.btnRemoveSupplier_Click);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(46, 35);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(69, 20);
            this.lblProduct.TabIndex = 7;
            this.lblProduct.Text = "Products:";
            // 
            // lblSuppliers
            // 
            this.lblSuppliers.AutoSize = true;
            this.lblSuppliers.Location = new System.Drawing.Point(364, 35);
            this.lblSuppliers.Name = "lblSuppliers";
            this.lblSuppliers.Size = new System.Drawing.Size(73, 20);
            this.lblSuppliers.TabIndex = 6;
            this.lblSuppliers.Text = "Suppliers:";
            // 
            // comboBoxSuppliers
            // 
            this.comboBoxSuppliers.FormattingEnabled = true;
            this.comboBoxSuppliers.Location = new System.Drawing.Point(364, 460);
            this.comboBoxSuppliers.Name = "comboBoxSuppliers";
            this.comboBoxSuppliers.Size = new System.Drawing.Size(374, 28);
            this.comboBoxSuppliers.TabIndex = 8;
            // 
            // lblRemove
            // 
            this.lblRemove.Location = new System.Drawing.Point(364, 491);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(369, 58);
            this.lblRemove.TabIndex = 9;
            this.lblRemove.Text = "Please select the Supplier from the listbox that you wish to remove:";
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 552);
            this.Controls.Add(this.lblRemove);
            this.Controls.Add(this.comboBoxSuppliers);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblSuppliers);
            this.Controls.Add(this.btnRemoveSupplier);
            this.Controls.Add(this.btnAddSupplier);
            this.Controls.Add(this.listBoxProducts);
            this.Controls.Add(this.listBoxSuppliers);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormProducts";
            this.Text = "FormProducts";
            this.Load += new System.EventHandler(this.FormProducts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSuppliers;
        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Button btnRemoveSupplier;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblSuppliers;
        private System.Windows.Forms.ComboBox comboBoxSuppliers;
        private System.Windows.Forms.Label lblRemove;
    }
}

namespace travelExpert
{
    partial class main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddSuppliers = new System.Windows.Forms.Button();
            this.btnAddProducts = new System.Windows.Forms.Button();
            this.btnViewPkg = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddSuppliers
            // 
            this.btnAddSuppliers.Location = new System.Drawing.Point(93, 93);
            this.btnAddSuppliers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddSuppliers.Name = "btnAddSuppliers";
            this.btnAddSuppliers.Size = new System.Drawing.Size(189, 56);
            this.btnAddSuppliers.TabIndex = 1;
            this.btnAddSuppliers.Text = "Supplier Products";
            this.btnAddSuppliers.UseVisualStyleBackColor = true;
            this.btnAddSuppliers.Click += new System.EventHandler(this.btnAddSuppliers_Click);
            // 
            // btnAddProducts
            // 
            this.btnAddProducts.Location = new System.Drawing.Point(93, 149);
            this.btnAddProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Size = new System.Drawing.Size(189, 54);
            this.btnAddProducts.TabIndex = 2;
            this.btnAddProducts.Text = "Product Suppliers";
            this.btnAddProducts.UseVisualStyleBackColor = true;
            this.btnAddProducts.Click += new System.EventHandler(this.btnAddProducts_Click);
            // 
            // btnViewPkg
            // 
            this.btnViewPkg.Location = new System.Drawing.Point(93, 35);
            this.btnViewPkg.Name = "btnViewPkg";
            this.btnViewPkg.Size = new System.Drawing.Size(189, 58);
            this.btnViewPkg.TabIndex = 3;
            this.btnViewPkg.Text = "View Packages";
            this.btnViewPkg.UseVisualStyleBackColor = true;
            this.btnViewPkg.Click += new System.EventHandler(this.btnViewPkg_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(93, 211);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(189, 54);
            this.btnProducts.TabIndex = 4;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Location = new System.Drawing.Point(93, 273);
            this.btnSuppliers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(189, 54);
            this.btnSuppliers.TabIndex = 5;
            this.btnSuppliers.Text = "Suppliers";
            this.btnSuppliers.UseVisualStyleBackColor = true;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 406);
            this.Controls.Add(this.btnSuppliers);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnViewPkg);
            this.Controls.Add(this.btnAddProducts);
            this.Controls.Add(this.btnAddSuppliers);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "main";
            this.Text = "main";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddSuppliers;
        private System.Windows.Forms.Button btnAddProducts;
        private System.Windows.Forms.Button btnViewPkg;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnSuppliers;
    }
}


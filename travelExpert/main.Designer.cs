
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAddSuppliers = new System.Windows.Forms.Button();
            this.btnAddProducts = new System.Windows.Forms.Button();
            this.btnViewPkg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 56);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 27);
            this.textBox1.TabIndex = 0;
            // 
            // btnAddSuppliers
            // 
            this.btnAddSuppliers.Location = new System.Drawing.Point(83, 216);
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
            this.btnAddProducts.Location = new System.Drawing.Point(83, 272);
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
            this.btnViewPkg.Location = new System.Drawing.Point(83, 158);
            this.btnViewPkg.Name = "btnViewPkg";
            this.btnViewPkg.Size = new System.Drawing.Size(189, 58);
            this.btnViewPkg.TabIndex = 3;
            this.btnViewPkg.Text = "View Packages";
            this.btnViewPkg.UseVisualStyleBackColor = true;
            this.btnViewPkg.Click += new System.EventHandler(this.btnViewPkg_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 406);
            this.Controls.Add(this.btnViewPkg);
            this.Controls.Add(this.btnAddProducts);
            this.Controls.Add(this.btnAddSuppliers);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "main";
            this.Text = "main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAddSuppliers;
        private System.Windows.Forms.Button btnAddProducts;
        private System.Windows.Forms.Button btnViewPkg;
    }
}


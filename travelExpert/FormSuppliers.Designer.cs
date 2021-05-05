
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
            this.listBoxSuppliers = new System.Windows.Forms.ListBox();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxSuppliers
            // 
            this.listBoxSuppliers.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxSuppliers.FormattingEnabled = true;
            this.listBoxSuppliers.ItemHeight = 18;
            this.listBoxSuppliers.Location = new System.Drawing.Point(50, 41);
            this.listBoxSuppliers.Name = "listBoxSuppliers";
            this.listBoxSuppliers.Size = new System.Drawing.Size(299, 310);
            this.listBoxSuppliers.TabIndex = 0;
            this.listBoxSuppliers.SelectedIndexChanged += new System.EventHandler(this.listBoxSuppliers_SelectedIndexChanged);
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 18;
            this.listBoxProducts.Location = new System.Drawing.Point(420, 41);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(299, 310);
            this.listBoxProducts.TabIndex = 1;
            // 
            // FormSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxProducts);
            this.Controls.Add(this.listBoxSuppliers);
            this.Name = "FormSuppliers";
            this.Text = "FormSuppliers";
            this.Load += new System.EventHandler(this.FormSuppliers_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSuppliers;
        private System.Windows.Forms.ListBox listBoxProducts;
    }
}
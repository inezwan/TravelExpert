
namespace travelExpert
{
    partial class FormPkgProductscs
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
            this.listBoxPkgProd = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxPkgProd
            // 
            this.listBoxPkgProd.FormattingEnabled = true;
            this.listBoxPkgProd.ItemHeight = 20;
            this.listBoxPkgProd.Location = new System.Drawing.Point(63, 21);
            this.listBoxPkgProd.Name = "listBoxPkgProd";
            this.listBoxPkgProd.Size = new System.Drawing.Size(592, 144);
            this.listBoxPkgProd.TabIndex = 0;
            // 
            // FormPkgProductscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxPkgProd);
            this.Name = "FormPkgProductscs";
            this.Text = "FormPkgProductscs";
            this.Load += new System.EventHandler(this.FormPkgProductscs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPkgProd;
    }
}

namespace travelExpert
{
    partial class PackagesForm
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
            this.listBoxPackages = new System.Windows.Forms.ListBox();
            this.btnPkgProd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxPackages
            // 
            this.listBoxPackages.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxPackages.FormattingEnabled = true;
            this.listBoxPackages.ItemHeight = 18;
            this.listBoxPackages.Location = new System.Drawing.Point(40, 25);
            this.listBoxPackages.Name = "listBoxPackages";
            this.listBoxPackages.Size = new System.Drawing.Size(1359, 202);
            this.listBoxPackages.TabIndex = 0;
            // 
            // btnPkgProd
            // 
            this.btnPkgProd.Location = new System.Drawing.Point(650, 279);
            this.btnPkgProd.Name = "btnPkgProd";
            this.btnPkgProd.Size = new System.Drawing.Size(194, 59);
            this.btnPkgProd.TabIndex = 1;
            this.btnPkgProd.Text = "View/Edit Package Products";
            this.btnPkgProd.UseVisualStyleBackColor = true;
            this.btnPkgProd.Click += new System.EventHandler(this.btnPkgProd_Click);
            // 
            // PackagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 450);
            this.Controls.Add(this.btnPkgProd);
            this.Controls.Add(this.listBoxPackages);
            this.Name = "PackagesForm";
            this.Text = "PackagesForm";
            this.Load += new System.EventHandler(this.PackagesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPackages;
        private System.Windows.Forms.Button btnPkgProd;
    }
}
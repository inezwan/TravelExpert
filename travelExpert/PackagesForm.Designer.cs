
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
            this.btnAddNewPackage = new System.Windows.Forms.Button();
            this.btnEditPackage = new System.Windows.Forms.Button();
            this.btnRemovePackage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxPackages
            // 
            this.listBoxPackages.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxPackages.FormattingEnabled = true;
            this.listBoxPackages.ItemHeight = 14;
            this.listBoxPackages.Location = new System.Drawing.Point(35, 19);
            this.listBoxPackages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPackages.Name = "listBoxPackages";
            this.listBoxPackages.Size = new System.Drawing.Size(1190, 144);
            this.listBoxPackages.TabIndex = 0;
            // 
            // btnPkgProd
            // 
            this.btnPkgProd.Location = new System.Drawing.Point(644, 209);
            this.btnPkgProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPkgProd.Name = "btnPkgProd";
            this.btnPkgProd.Size = new System.Drawing.Size(170, 44);
            this.btnPkgProd.TabIndex = 1;
            this.btnPkgProd.Text = "View/Edit Package Products";
            this.btnPkgProd.UseVisualStyleBackColor = true;
            this.btnPkgProd.Click += new System.EventHandler(this.btnPkgProd_Click);
            // 
            // btnAddNewPackage
            // 
            this.btnAddNewPackage.Location = new System.Drawing.Point(116, 209);
            this.btnAddNewPackage.Name = "btnAddNewPackage";
            this.btnAddNewPackage.Size = new System.Drawing.Size(129, 44);
            this.btnAddNewPackage.TabIndex = 2;
            this.btnAddNewPackage.Text = "Add New Package";
            this.btnAddNewPackage.UseVisualStyleBackColor = true;
            this.btnAddNewPackage.Click += new System.EventHandler(this.btnAddNewPackage_Click);
            // 
            // btnEditPackage
            // 
            this.btnEditPackage.Location = new System.Drawing.Point(283, 209);
            this.btnEditPackage.Name = "btnEditPackage";
            this.btnEditPackage.Size = new System.Drawing.Size(129, 44);
            this.btnEditPackage.TabIndex = 3;
            this.btnEditPackage.Text = "Edit Package";
            this.btnEditPackage.UseVisualStyleBackColor = true;
            this.btnEditPackage.Click += new System.EventHandler(this.btnEditPackage_Click);
            // 
            // btnRemovePackage
            // 
            this.btnRemovePackage.Location = new System.Drawing.Point(453, 209);
            this.btnRemovePackage.Name = "btnRemovePackage";
            this.btnRemovePackage.Size = new System.Drawing.Size(129, 44);
            this.btnRemovePackage.TabIndex = 4;
            this.btnRemovePackage.Text = "RemovePackage";
            this.btnRemovePackage.UseVisualStyleBackColor = true;
            this.btnRemovePackage.Click += new System.EventHandler(this.btnRemovePackage_Click);
            // 
            // PackagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 338);
            this.Controls.Add(this.btnRemovePackage);
            this.Controls.Add(this.btnEditPackage);
            this.Controls.Add(this.btnAddNewPackage);
            this.Controls.Add(this.btnPkgProd);
            this.Controls.Add(this.listBoxPackages);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PackagesForm";
            this.Text = "PackagesForm";
            this.Load += new System.EventHandler(this.PackagesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPackages;
        private System.Windows.Forms.Button btnPkgProd;
        private System.Windows.Forms.Button btnAddNewPackage;
        private System.Windows.Forms.Button btnEditPackage;
        private System.Windows.Forms.Button btnRemovePackage;
    }
}
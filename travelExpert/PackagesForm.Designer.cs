
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
            this.lblPkgHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxPackages
            // 
            this.listBoxPackages.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxPackages.FormattingEnabled = true;
            this.listBoxPackages.ItemHeight = 18;
            this.listBoxPackages.Location = new System.Drawing.Point(40, 52);
            this.listBoxPackages.Name = "listBoxPackages";
            this.listBoxPackages.Size = new System.Drawing.Size(1359, 220);
            this.listBoxPackages.TabIndex = 0;
            // 
            // btnPkgProd
            // 
            this.btnPkgProd.Location = new System.Drawing.Point(736, 279);
            this.btnPkgProd.Name = "btnPkgProd";
            this.btnPkgProd.Size = new System.Drawing.Size(194, 59);
            this.btnPkgProd.TabIndex = 1;
            this.btnPkgProd.Text = "View/Edit Package Products";
            this.btnPkgProd.UseVisualStyleBackColor = true;
            this.btnPkgProd.Click += new System.EventHandler(this.btnPkgProd_Click);
            // 
            // btnAddNewPackage
            // 
            this.btnAddNewPackage.Location = new System.Drawing.Point(133, 279);
            this.btnAddNewPackage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddNewPackage.Name = "btnAddNewPackage";
            this.btnAddNewPackage.Size = new System.Drawing.Size(147, 59);
            this.btnAddNewPackage.TabIndex = 2;
            this.btnAddNewPackage.Text = "Add New Package";
            this.btnAddNewPackage.UseVisualStyleBackColor = true;
            this.btnAddNewPackage.Click += new System.EventHandler(this.btnAddNewPackage_Click);
            // 
            // btnEditPackage
            // 
            this.btnEditPackage.Location = new System.Drawing.Point(323, 279);
            this.btnEditPackage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditPackage.Name = "btnEditPackage";
            this.btnEditPackage.Size = new System.Drawing.Size(147, 59);
            this.btnEditPackage.TabIndex = 3;
            this.btnEditPackage.Text = "Edit Package";
            this.btnEditPackage.UseVisualStyleBackColor = true;
            this.btnEditPackage.Click += new System.EventHandler(this.btnEditPackage_Click);
            // 
            // btnRemovePackage
            // 
            this.btnRemovePackage.Location = new System.Drawing.Point(518, 279);
            this.btnRemovePackage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemovePackage.Name = "btnRemovePackage";
            this.btnRemovePackage.Size = new System.Drawing.Size(147, 59);
            this.btnRemovePackage.TabIndex = 4;
            this.btnRemovePackage.Text = "RemovePackage";
            this.btnRemovePackage.UseVisualStyleBackColor = true;
            this.btnRemovePackage.Click += new System.EventHandler(this.btnRemovePackage_Click);
            // 
            // lblPkgHeader
            // 
            this.lblPkgHeader.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPkgHeader.Location = new System.Drawing.Point(38, 22);
            this.lblPkgHeader.Name = "lblPkgHeader";
            this.lblPkgHeader.Size = new System.Drawing.Size(1361, 30);
            this.lblPkgHeader.TabIndex = 5;
            this.lblPkgHeader.Text = "label1";
            // 
            // PackagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 451);
            this.Controls.Add(this.lblPkgHeader);
            this.Controls.Add(this.btnRemovePackage);
            this.Controls.Add(this.btnEditPackage);
            this.Controls.Add(this.btnAddNewPackage);
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
        private System.Windows.Forms.Button btnAddNewPackage;
        private System.Windows.Forms.Button btnEditPackage;
        private System.Windows.Forms.Button btnRemovePackage;
        private System.Windows.Forms.Label lblPkgHeader;
    }
}
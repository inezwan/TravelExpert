
namespace travelExpert
{
    partial class ProductSupplier
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
            this.listBoxAllSupplier = new System.Windows.Forms.ListBox();
            this.listBoxSelectedSupplier = new System.Windows.Forms.ListBox();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.btnRemoveSupplier = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxAllSupplier
            // 
            this.listBoxAllSupplier.FormattingEnabled = true;
            this.listBoxAllSupplier.ItemHeight = 15;
            this.listBoxAllSupplier.Location = new System.Drawing.Point(58, 112);
            this.listBoxAllSupplier.Name = "listBoxAllSupplier";
            this.listBoxAllSupplier.Size = new System.Drawing.Size(158, 214);
            this.listBoxAllSupplier.TabIndex = 0;
            // 
            // listBoxSelectedSupplier
            // 
            this.listBoxSelectedSupplier.FormattingEnabled = true;
            this.listBoxSelectedSupplier.ItemHeight = 15;
            this.listBoxSelectedSupplier.Location = new System.Drawing.Point(364, 112);
            this.listBoxSelectedSupplier.Name = "listBoxSelectedSupplier";
            this.listBoxSelectedSupplier.Size = new System.Drawing.Size(180, 214);
            this.listBoxSelectedSupplier.TabIndex = 1;
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Location = new System.Drawing.Point(233, 180);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(75, 23);
            this.btnAddSupplier.TabIndex = 2;
            this.btnAddSupplier.Text = ">>";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // btnRemoveSupplier
            // 
            this.btnRemoveSupplier.Location = new System.Drawing.Point(233, 236);
            this.btnRemoveSupplier.Name = "btnRemoveSupplier";
            this.btnRemoveSupplier.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveSupplier.TabIndex = 3;
            this.btnRemoveSupplier.Text = "<<";
            this.btnRemoveSupplier.UseVisualStyleBackColor = true;
            this.btnRemoveSupplier.Click += new System.EventHandler(this.btnRemoveSupplier_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(168, 359);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(345, 359);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ProductSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemoveSupplier);
            this.Controls.Add(this.btnAddSupplier);
            this.Controls.Add(this.listBoxSelectedSupplier);
            this.Controls.Add(this.listBoxAllSupplier);
            this.Name = "ProductSupplier";
            this.Text = "ProductSupplier";
            this.Load += new System.EventHandler(this.ProductSupplier_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAllSupplier;
        private System.Windows.Forms.ListBox listBoxSelectedSupplier;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Button btnRemoveSupplier;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
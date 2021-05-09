
namespace travelExpert
{
    partial class selectedSuppProd_Frm
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
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.btnAddSelect = new System.Windows.Forms.Button();
            this.listBoxAddSelect = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 20;
            this.listBoxProducts.Location = new System.Drawing.Point(90, 51);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(271, 264);
            this.listBoxProducts.TabIndex = 0;
            // 
            // btnAddSelect
            // 
            this.btnAddSelect.Location = new System.Drawing.Point(399, 104);
            this.btnAddSelect.Name = "btnAddSelect";
            this.btnAddSelect.Size = new System.Drawing.Size(94, 29);
            this.btnAddSelect.TabIndex = 1;
            this.btnAddSelect.Text = ">";
            this.btnAddSelect.UseVisualStyleBackColor = true;
            this.btnAddSelect.Click += new System.EventHandler(this.btnAddSelect_Click);
            // 
            // listBoxAddSelect
            // 
            this.listBoxAddSelect.FormattingEnabled = true;
            this.listBoxAddSelect.ItemHeight = 20;
            this.listBoxAddSelect.Location = new System.Drawing.Point(509, 56);
            this.listBoxAddSelect.Name = "listBoxAddSelect";
            this.listBoxAddSelect.Size = new System.Drawing.Size(253, 244);
            this.listBoxAddSelect.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(90, 339);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(671, 58);
            this.listBox1.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(385, 409);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // selectedSuppProd_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listBoxAddSelect);
            this.Controls.Add(this.btnAddSelect);
            this.Controls.Add(this.listBoxProducts);
            this.Name = "selectedSuppProd_Frm";
            this.Text = "selectedSuppProd_Frm";
            this.Load += new System.EventHandler(this.selectedSuppProd_Frm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.Button btnAddSelect;
        private System.Windows.Forms.ListBox listBoxAddSelect;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSave;
    }
}
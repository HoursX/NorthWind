namespace B12017051082
{
    partial class AddProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LbProID = new System.Windows.Forms.Label();
            this.TbProName = new System.Windows.Forms.TextBox();
            this.TbUnitPrice = new System.Windows.Forms.TextBox();
            this.CbxSuppliers = new System.Windows.Forms.ComboBox();
            this.CbxCategories = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CheckDisc = new System.Windows.Forms.CheckBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "产品编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "产品名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "供应商：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "种类：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "单价：";
            // 
            // LbProID
            // 
            this.LbProID.AutoSize = true;
            this.LbProID.Location = new System.Drawing.Point(102, 32);
            this.LbProID.Name = "LbProID";
            this.LbProID.Size = new System.Drawing.Size(53, 12);
            this.LbProID.TabIndex = 5;
            this.LbProID.Text = "自动生成";
            // 
            // TbProName
            // 
            this.TbProName.Location = new System.Drawing.Point(102, 65);
            this.TbProName.Name = "TbProName";
            this.TbProName.Size = new System.Drawing.Size(232, 21);
            this.TbProName.TabIndex = 6;
            // 
            // TbUnitPrice
            // 
            this.TbUnitPrice.Location = new System.Drawing.Point(102, 183);
            this.TbUnitPrice.Name = "TbUnitPrice";
            this.TbUnitPrice.Size = new System.Drawing.Size(232, 21);
            this.TbUnitPrice.TabIndex = 7;
            // 
            // CbxSuppliers
            // 
            this.CbxSuppliers.FormattingEnabled = true;
            this.CbxSuppliers.Location = new System.Drawing.Point(102, 104);
            this.CbxSuppliers.Name = "CbxSuppliers";
            this.CbxSuppliers.Size = new System.Drawing.Size(232, 20);
            this.CbxSuppliers.TabIndex = 8;
            // 
            // CbxCategories
            // 
            this.CbxCategories.FormattingEnabled = true;
            this.CbxCategories.Location = new System.Drawing.Point(102, 143);
            this.CbxCategories.Name = "CbxCategories";
            this.CbxCategories.Size = new System.Drawing.Size(232, 20);
            this.CbxCategories.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "折扣";
            // 
            // CheckDisc
            // 
            this.CheckDisc.AutoSize = true;
            this.CheckDisc.Location = new System.Drawing.Point(140, 236);
            this.CheckDisc.Name = "CheckDisc";
            this.CheckDisc.Size = new System.Drawing.Size(15, 14);
            this.CheckDisc.TabIndex = 11;
            this.CheckDisc.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(259, 231);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 12;
            this.BtnSave.Text = "保存";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 358);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.CheckDisc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CbxCategories);
            this.Controls.Add(this.CbxSuppliers);
            this.Controls.Add(this.TbUnitPrice);
            this.Controls.Add(this.TbProName);
            this.Controls.Add(this.LbProID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LbProID;
        private System.Windows.Forms.TextBox TbProName;
        private System.Windows.Forms.TextBox TbUnitPrice;
        private System.Windows.Forms.ComboBox CbxSuppliers;
        private System.Windows.Forms.ComboBox CbxCategories;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox CheckDisc;
        private System.Windows.Forms.Button BtnSave;
    }
}
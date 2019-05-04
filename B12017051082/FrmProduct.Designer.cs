namespace B12017051082
{
    partial class FrmProduct
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LbCategories = new System.Windows.Forms.Label();
            this.CbxCategories = new System.Windows.Forms.ComboBox();
            this.LbSuppliers = new System.Windows.Forms.Label();
            this.CbxSuppliers = new System.Windows.Forms.ComboBox();
            this.LbProductName = new System.Windows.Forms.Label();
            this.TbProductName = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.DGVShowInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVShowInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 366);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(672, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LbCategories
            // 
            this.LbCategories.AutoSize = true;
            this.LbCategories.Location = new System.Drawing.Point(13, 13);
            this.LbCategories.Name = "LbCategories";
            this.LbCategories.Size = new System.Drawing.Size(65, 12);
            this.LbCategories.TabIndex = 1;
            this.LbCategories.Text = "所属类别：";
            // 
            // CbxCategories
            // 
            this.CbxCategories.FormattingEnabled = true;
            this.CbxCategories.Location = new System.Drawing.Point(72, 10);
            this.CbxCategories.Name = "CbxCategories";
            this.CbxCategories.Size = new System.Drawing.Size(121, 20);
            this.CbxCategories.TabIndex = 2;
            // 
            // LbSuppliers
            // 
            this.LbSuppliers.AutoSize = true;
            this.LbSuppliers.Location = new System.Drawing.Point(200, 13);
            this.LbSuppliers.Name = "LbSuppliers";
            this.LbSuppliers.Size = new System.Drawing.Size(53, 12);
            this.LbSuppliers.TabIndex = 3;
            this.LbSuppliers.Text = "供应商：";
            // 
            // CbxSuppliers
            // 
            this.CbxSuppliers.FormattingEnabled = true;
            this.CbxSuppliers.Location = new System.Drawing.Point(247, 10);
            this.CbxSuppliers.Name = "CbxSuppliers";
            this.CbxSuppliers.Size = new System.Drawing.Size(121, 20);
            this.CbxSuppliers.TabIndex = 4;
            // 
            // LbProductName
            // 
            this.LbProductName.AutoSize = true;
            this.LbProductName.Location = new System.Drawing.Point(375, 13);
            this.LbProductName.Name = "LbProductName";
            this.LbProductName.Size = new System.Drawing.Size(65, 12);
            this.LbProductName.TabIndex = 5;
            this.LbProductName.Text = "商品名称：";
            // 
            // TbProductName
            // 
            this.TbProductName.Location = new System.Drawing.Point(433, 10);
            this.TbProductName.Name = "TbProductName";
            this.TbProductName.Size = new System.Drawing.Size(109, 21);
            this.TbProductName.TabIndex = 6;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(423, 37);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 7;
            this.BtnSearch.Text = "搜索";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(504, 37);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(75, 23);
            this.BtnDel.TabIndex = 8;
            this.BtnDel.Text = "删除";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(585, 37);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 9;
            this.BtnAdd.Text = "新增";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // DGVShowInfo
            // 
            this.DGVShowInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVShowInfo.Location = new System.Drawing.Point(0, 66);
            this.DGVShowInfo.Name = "DGVShowInfo";
            this.DGVShowInfo.RowTemplate.Height = 23;
            this.DGVShowInfo.Size = new System.Drawing.Size(672, 297);
            this.DGVShowInfo.TabIndex = 10;
            this.DGVShowInfo.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVShowInfo_CellMouseDoubleClick);
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 388);
            this.Controls.Add(this.DGVShowInfo);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TbProductName);
            this.Controls.Add(this.LbProductName);
            this.Controls.Add(this.CbxSuppliers);
            this.Controls.Add(this.LbSuppliers);
            this.Controls.Add(this.CbxCategories);
            this.Controls.Add(this.LbCategories);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmProduct";
            this.Text = "FrmProduct";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVShowInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label LbCategories;
        private System.Windows.Forms.ComboBox CbxCategories;
        private System.Windows.Forms.Label LbSuppliers;
        private System.Windows.Forms.ComboBox CbxSuppliers;
        private System.Windows.Forms.Label LbProductName;
        private System.Windows.Forms.TextBox TbProductName;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView DGVShowInfo;
    }
}
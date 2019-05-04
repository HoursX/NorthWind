using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B12017051082
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if(DGVShowInfo.SelectedRows.Count > 0)
            {
                if(MessageBox.Show("确认删除这行数据吗？","警告", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //获取主键
                    string productID = DGVShowInfo.SelectedRows[0].Cells["ProductID"].Value.ToString();
                    string checkSql = "select * from [Order Details] where ProductID = '" + productID + "'";
                    
                    if(DBHelper.ExcuteExist(checkSql))
                    {
                        MessageBox.Show("已出售商品不允许删除！");
                        return;
                    }
                    else
                    {
                        string sql = "delete from Products where ProductID ='" + productID + "'";
                        int cnt = DBHelper.ExecuteNonQuery(sql);
                        MessageBox.Show(cnt > 0 ? "删除成功！" : "删除出错！");
                        BtnSearch.PerformClick();
                    }
                   
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的行！");
            }
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            {
                string sql = "select ProductID,ProductName,CompanyName,CategoryName,UnitPrice,Discontinued from Products " +
                    "left join Suppliers on Products.SupplierID = Suppliers.SupplierID " +
                    "left join Categories on Products.CategoryID = Categories.CategoryID";
                DGVShowInfo.DataSource = DBHelper.ExecuteReaderDataTable(sql);
            }

            {
                //绑定类别
                string sql = "select CategoryID, CategoryName from Categories";
                DataTable table = DBHelper.ExecuteReaderDataTable(sql);
                DBHelper.BindCombo(CbxCategories, table, "CategoryID", "CategoryName", true);
            }

            {
                //绑定供应商
                string sql = "select SupplierID, CompanyName from Suppliers";
                DataTable table = DBHelper.ExecuteReaderDataTable(sql);
                DBHelper.BindCombo(CbxSuppliers, table, "SupplierID", "CompanyName", true);
            }
            this.DGVShowInfo.AllowUserToAddRows = false;
            this.DGVShowInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.DGVShowInfo.MultiSelect = false;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select ProductID,ProductName,CompanyName,CategoryName,UnitPrice,Discontinued from Products " +
                    "left join Suppliers on Products.SupplierID = Suppliers.SupplierID " +
                    "left join Categories on Products.CategoryID = Categories.CategoryID " +
                    "where 1 = 1 ";
            if (CbxCategories.SelectedIndex > 0)
                sql += "and Products.CategoryID = " + CbxCategories.SelectedValue.ToString();
            if (CbxSuppliers.SelectedIndex > 0)
                sql += "and Products.SupplierID = " + CbxSuppliers.SelectedValue.ToString();
            if (TbProductName.Text.Trim() != "")
                sql += "and ProductName like '%" + TbProductName.Text.Trim().Replace("'", "''") + "%'";
            DGVShowInfo.DataSource = DBHelper.ExecuteReaderDataTable(sql);



        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddProduct fm = new AddProduct();
            fm.SetValue("", "Insert");
            if (fm.ShowDialog() == DialogResult.OK)
            {
                this.BtnSearch.PerformClick();
            }
        }

        private void DGVShowInfo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                string productID = DGVShowInfo.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
                AddProduct fm = new AddProduct();
                fm.SetValue(productID, "Update");
                if(fm.ShowDialog() == DialogResult.OK)
                {
                    this.BtnSearch.PerformClick();
                }
            }
        }
    }
}

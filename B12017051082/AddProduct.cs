using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace B12017051082
{
    public partial class AddProduct : Form
    {
        private string productID;
        private string opMode;
        public AddProduct()
        {
            InitializeComponent();
        }
        public void SetValue(string productID, string opMode)
        {
            this.productID = productID;
            this.opMode = opMode;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(opMode == "Insert")
                {
                    string sql = @"insert into Products(ProductName,
                                                        SupplierID,
                                                        CategoryID,
                                                        UnitPrice,
                                                        Discontinued)
                                               values('{0}',
                                                    '{1}',
                                                    '{2}',
                                                    '{3}',
                                                    '{4}'
                                                    )";
                    sql = string.Format(sql, TbProName.Text.Trim(),
                                            CbxSuppliers.SelectedValue,
                                            CbxCategories.SelectedValue,
                                            TbUnitPrice.Text.Trim(),
                                            CheckDisc.Checked
                                       );
                    DBHelper.ExecuteNonQuery(sql);
                }
                if (opMode == "Update")
                {
                    string sql = @"update Products set ProductName = '{0}',
                                                        SupplierID = '{1}',
                                                        CategoryID = '{2}',
                                                        UnitPrice = '{3}',
                                                        Discontinued = '{4}' where ProductID = '{5}'";
                    sql = string.Format(sql, TbProName.Text.Trim(),
                                            CbxSuppliers.SelectedValue,
                                            CbxCategories.SelectedValue,
                                            TbUnitPrice.Text.Trim(),
                                            CheckDisc.Checked,
                                            LbProID.Text
                                       );
                    DBHelper.ExecuteNonQuery(sql);
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
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
            if(opMode == "Update")
            {
                string sql = "select * from Products where ProductID ='" + productID + "'";
                DataRow row = DBHelper.ExecuteReaderDataRow(sql);
                LbProID.Text = row["ProductID"].ToString();
                TbProName.Text = row["ProductName"].ToString();
                CbxSuppliers.SelectedValue = row["SupplierID"].ToString();
                CbxCategories.SelectedValue = row["CategoryID"].ToString();
                TbUnitPrice.Text = row["UnitPrice"].ToString();
                CheckDisc.Checked = Convert.ToBoolean(row["Discontinued"]);
            }
        }
    }
}

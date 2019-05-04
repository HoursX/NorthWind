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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if(CheckLogin())
            {
                MessageBox.Show("登陆成功！");
                this.Hide();
                Form fm = new FrmProduct();
                fm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("登陆失败，请检查姓名是否正确！");
            }
        }
        private bool CheckLogin()
        {
            bool result = false;
            SqlConnection conn = new SqlConnection();
            string sql = string.Format(@"select * from Employees where FirstName = '{0}' and LastName = '{1}'", TbFirstName.Text.Trim(), TbLastName.Text.Trim());
            try
            {
                conn.ConnectionString = DBHelper.GetConnstr();
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                if (comm.ExecuteReader().HasRows) result = true;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return result;
#pragma warning disable CS0162 // 检测到无法访问的代码
            return result;
#pragma warning restore CS0162 // 检测到无法访问的代码
        }
    }
}

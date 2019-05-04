using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace B12017051082
{
    class DBHelper
    {
        /// <summary>
        /// 获取连接字符串
        /// </summary>
        /// <returns></returns>
        public static string GetConnstr()
        {
            //return ConfigurationManager.ConnectionStrings["school"].ToString();
            return ConfigurationManager.ConnectionStrings["constr"].ToString();
        }
        /// <summary>
        /// 执行sql语句并返回受影响的行数
        /// </summary>
        /// <param name="sql">要查询的语句</param>
        /// <param name="paraList">变量列表Sqlparameters(可选)</param>
        /// <param name="commType">要查询语句的类型</param>
        /// <returns>返回受影响的行数</returns>
        public static int ExecuteNonQuery(string sql, List<SqlParameter> paraList = null, CommandType commType = CommandType.Text)
        {
            //int cut = 0;
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = DBHelper.GetConnstr();
                conn.Open();
                SqlCommand comm = new SqlCommand()
                {
                    Connection = conn,
                    CommandType = commType,
                    CommandText = sql,
                    CommandTimeout = 600,
                };
                if(paraList != null)
                {
                    foreach (var para in paraList)
                    {
                        comm.Parameters.Add(para);
                    }
                }
                return comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return -1;
            }
        }
        /// <summary>
        /// 连接数据库
        /// </summary>
        /// <returns>成功返回1，已打开返回0，其他返回2，异常返回-1</returns>
        public static int Connection()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.ConnectionString = DBHelper.GetConnstr();
                    conn.Open();
                    return 1;
                }
                else if (conn.State == ConnectionState.Open)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }
        /// <summary>
        /// 用来绑定下拉菜单ComboBox
        /// </summary>
        /// <param name="cb">需要绑定的ComboBox名字</param>
        /// <param name="table">被绑定的表单</param>
        /// <param name="valueField">被绑定的表单的实际值</param>
        /// <param name="displayField">被绑定表单的显示值</param>
        /// <param name="hasTip">是否有"请选择"提示</param>
        public static void BindCombo(ComboBox cb, DataTable table, string valueField, string displayField, bool hasTip)
        {
            if (hasTip)
            {
                DataRow row = table.NewRow();
                row[valueField] = "0";
                row[displayField] = "请选择";
                table.Rows.InsertAt(row, 0);
            }
            cb.ValueMember = valueField;
            cb.DisplayMember = displayField;
            cb.DataSource = table;
        }
        /// <summary>
        /// 离线查询数据DataTable(返回表)
        /// </summary>
        /// <param name="sql">要查询的语句</param>
        /// <param name="paraList">变量列表Sqlparameters(可选)</param>
        /// <param name="commType">要查询语句的类型</param>
        /// <returns>返回查询得到的DataTable</returns>
        public static DataTable ExecuteReaderDataTable(string sql, List<SqlParameter> paraList = null, CommandType commType = CommandType.Text)
        {
            //DataSet data = new DataSet();
            try
            {
                SqlConnection conn = new SqlConnection
                {
                    ConnectionString = DBHelper.GetConnstr(),
                };
                SqlCommand comm = new SqlCommand
                {
                    CommandText = sql,
                    CommandType = commType,
                    Connection = conn,
                    CommandTimeout = 600,
                };
                if (paraList != null)
                {
                    foreach (var para in paraList)
                    {
                        comm.Parameters.Add(para);
                    }
                }
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comm);
                DataTable table = new DataTable();
                sqlDataAdapter.Fill(table);
                return table;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// 离线查询数据DataTable(返回表的第一行DataRow)
        /// </summary>
        /// <param name="sql">要查询的语句</param>
        /// <param name="paraList">变量列表Sqlparameters(可选)</param>
        /// <param name="commType">要查询语句的类型</param>
        /// <returns>返回查询结果的第一行DataRow</returns>
        public static DataRow ExecuteReaderDataRow(string sql, List<SqlParameter> paraList = null, CommandType commType = CommandType.Text)
        {
            DataTable data = DBHelper.ExecuteReaderDataTable(sql, paraList, commType);
            return (data.Rows.Count > 0) ? data.Rows[0] : null;
        }
        /// <summary>
        /// 查询语句是否存在
        /// </summary>
        /// <param name="sql">要查询的语句</param>
        /// <param name="paraList">变量列表Sqlparameters(可选)</param>
        /// <param name="commType">要查询语句的类型</param>
        /// <returns>返回bool值</returns>
        public static bool ExcuteExist(string sql, List<SqlParameter> paraList = null, CommandType commType = CommandType.Text)
        {
            DataTable data = DBHelper.ExecuteReaderDataTable(sql, paraList, commType);
            return (data.Rows.Count > 0)? true : false;
        }
    }
}

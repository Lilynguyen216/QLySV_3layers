using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLySV_3layers
{
    public class Database
    {
        private string connectString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLySV;Integrated Security=True;TrustServerCertificate=True";
        private SqlConnection con;
        /*private string sql;*/
        private DataTable dt;
        private SqlCommand cmd;

        public Database()
        {
            try
            {
                con = new SqlConnection(connectString);
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("connected failed: " + ex.Message);
            }
        }

        public DataTable SelectData(string sql, List<CustomParameters> lstPara)
        {
            try
            {
                /*sql = "exec SelectAllSinhVien";*/
                cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach(var para in lstPara)
                {
                    cmd.Parameters.AddWithValue(para.key, para.value);
                }
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu: ", ex.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public DataRow Select(string sql)
        {
            try
            {
                cmd = new SqlCommand(sql, con);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt.Rows[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi load thông tin chi tiết" + ex.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public int ExeCute(string sql, List<CustomParameters> lstPara)
        {
            try
            {
                cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (var p in lstPara)
                {
                    cmd.Parameters.AddWithValue(p.key, p.value);
                }
                var rs = cmd.ExecuteNonQuery();
                return (int)rs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi thực thi câu lệnh" + ex.Message);
                return -100;
            }
            finally
            {
                con.Close();
            }
        }
    }
}

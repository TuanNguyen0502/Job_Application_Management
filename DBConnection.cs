using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Application_Management
{
    public class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        public DBConnection()
        {
        }

        /*
        public DataTable LoadEmployerInfor()
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format($"SELECT ");
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtperson = new DataTable();
                adapter.Fill(dtperson);
                return dtperson;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        */

        public void Execute(string sqlStr)
        {
            try
            {
                // Ket noi
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("That bai" + ex);
            }
            finally
            {
                conn.Close();
            }

            //LoadDataGridView();
        }
    }
}

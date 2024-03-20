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
        //SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        readonly string conStr = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Jobs_Management;Integrated Security=True";
        string sqlQuery;
        public DBConnection()
        {
        }

        public void ExecuteWriteData(string sqlStr, SqlParameter[] lstParam)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    // Ket noi
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.Parameters.AddRange(lstParam);
                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Successful !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error !\n" + ex.Message);
                }
            }
        }
        public void ExecuteWriteData(string sqlStr)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    // Ket noi
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Successful !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error !\n" + ex.Message);
                }
            }
        }
        public SqlDataReader ExecuteReaderData(string sqlStr)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return reader;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Read error\n"+ex.Message);
                }
            }
            return null;
        }
    }
}

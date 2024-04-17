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

        // 
        public List<Dictionary<string, object>> GetUserFromDB(string sqlStr)
        {
            List<Dictionary<string, object>> resultList = new List<Dictionary<string, object>>();
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Dictionary<string, object> rowData = new Dictionary<string, object>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                rowData.Add(reader.GetName(i), reader.GetValue(i).ToString());
                            }
                            resultList.Add(rowData);
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Read error\n" + ex.Message);
                }
            }
            return resultList;
        }

        // Các phương thức để đọc và ghi dữ liệu từ cơ sở dữ liệu mysql server
        public void ExecuteDeleteData(string sqlStr, SqlParameter[] lstParam)
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
                        MessageBox.Show("Delete data successful !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error !\n" + ex.Message);
                }
            }
        }
        public void ExecuteDeleteData(string sqlStr)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    // Ket noi
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Delete data Successful !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error !\n" + ex.Message);
                }
            }
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
                        MessageBox.Show("Write data successful !");
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
                        MessageBox.Show("Write data Successful !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error !\n" + ex.Message);
                }
            }
        }
        public bool ExecuteDeleteDataCheck(string sqlStr, SqlParameter[] lstParam)
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
                        return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error !\n" + ex.Message);
                }
                return false;
            }
        }
        public bool ExecuteDeleteDataCheck(string sqlStr)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    // Ket noi
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error !\n" + ex.Message);
                }
                return false;
            }
        }
        public bool ExecuteWriteDataCheck(string sqlStr, SqlParameter[] lstParam)
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
                        return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error !\n" + ex.Message);
                }
                return false;
            }
        }
        public bool ExecuteWriteDataCheck(string sqlStr)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    // Ket noi
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error !\n" + ex.Message);
                }
                return false;
            }
        }

        public string ExecuteReaderCount(string sqlStr)
        {
            string result = "0";
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            result = reader.GetInt32(0).ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Read error\n" + ex.Message);
                }
            }
            return result;
        }

        public List<Dictionary<string, object>> ExecuteReaderData(string sqlStr)
        {
            List<Dictionary<string, object>> resultList = new List<Dictionary<string, object>>();
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Dictionary<string, object> rowData = new Dictionary<string, object>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                rowData.Add(reader.GetName(i), reader.GetValue(i));
                            }
                            resultList.Add(rowData);
                        } 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Read error\n"+ex.Message);
                }
            }
            return resultList;
        }

        public List<Dictionary<string, object>> ExecuteReaderData(string sqlStr, SqlParameter[] lstParam)
        {
            List<Dictionary<string, object>> resultList = new List<Dictionary<string, object>>();
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.Parameters.AddRange(lstParam);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Dictionary<string, object> rowData = new Dictionary<string, object>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                rowData.Add(reader.GetName(i), reader.GetValue(i));
                            }
                            resultList.Add(rowData);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Read error\n"+ex.Message);
                }
            }
            return resultList;
        }
        public string ExecuteScalar(string sqlStr, SqlParameter[] lstParam)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.Parameters.AddRange(lstParam);
                    SqlDataReader reader = cmd.ExecuteReader();
                    string res = "";
                    if (reader.Read())
                    {
                        res = reader.GetString(0);
                    }
                    else
                    {
                        MessageBox.Show("No rows found");
                    }
                    return res;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Read error\n"+ex.Message);
                    return null;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public static class HelperDB
    {
        static SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-GDJOSL0P\MANPHAM;Initial Catalog=QL_NHAHANG;Integrated Security=True");

        public static bool BackupDatabase(string fileName)
        {
            string database = con.Database.ToString();
            try
            {
                if (fileName == string.Empty)
                {
                    return false;
                }
                else
                {
                    string cmd = "BACKUP DATABASE [" + database + "] TO DISK='" + fileName + "\\" + "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

                    using (SqlCommand command = new SqlCommand(cmd, con))
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }
                        command.ExecuteNonQuery();
                        con.Close();
                        return true;
                    }
                }

            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public static bool RostoreDatabase(string path)
        {
            string database = con.Database.ToString();
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            try
            {
                string sqlStmt2 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand bu2 = new SqlCommand(sqlStmt2, con);
                bu2.ExecuteNonQuery();

                string sqlStmt3 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + path + "'WITH REPLACE;";
                SqlCommand bu3 = new SqlCommand(sqlStmt3, con);
                bu3.ExecuteNonQuery();

                string sqlStmt4 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand bu4 = new SqlCommand(sqlStmt4, con);
                bu4.ExecuteNonQuery();

                con.Close();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}

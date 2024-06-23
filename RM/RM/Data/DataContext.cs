using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraEditors.Frames;
using RM.Logger;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Data
{
    public class DataContext
    {
        public static readonly string conString = "Server=localhost;Database=RM;Persist Security Info=True;User Id=sa;Password=8bfw,jvvd;";
        public static SqlConnection con =new SqlConnection(conString);

        //Methord to check user validation

        public static bool IsValidUser(string user,string pass)
        {
            bool isValid = false;
            string query = @"SELECT * FROM users WHERE username=@user and uPass=@pass";
            DataTable dt = new DataTable();

            try
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.Add(new SqlParameter("@user", SqlDbType.VarChar, 50)).Value = user;
                command.Parameters.Add(new SqlParameter("@pass", SqlDbType.VarChar, 10)).Value = pass;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                con.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    isValid = true;
                }
                else
                {
                    new Log(logLevel: "INFO", message: "invalid username or password", source: MethodBase.GetCurrentMethod().DeclaringType.Name);
                }
            }
            catch (Exception ex)
            {
                new Log(logLevel: "ERROR", message: ex.Message, source: MethodBase.GetCurrentMethod().DeclaringType.Name);
            }
            finally
            {
                con.Close();
            }

            return isValid;
        }
    }
}

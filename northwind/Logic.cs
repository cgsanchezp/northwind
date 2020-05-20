using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace northwindDesktop
{
    class Logic
    {
        SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ConnectionString);
        public bool validateUser(string UserName, string UserPass)
        {

            if (sqlcon.State == ConnectionState.Closed)
            {

                string sql = "SELECT count(id) FROM UserLogin WHERE username = '" + UserName + "' AND CONVERT(VARCHAR(MAX),  DecryptByPassphrase('nothwind',userpassword)) = '"+UserPass+"'";

                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                sqlcon.Open();

                int strResult = (int)cmd.ExecuteScalar();
                sqlcon.Close();

                if (strResult == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            return false;
        }
    }
}

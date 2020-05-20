using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace northwindWeb.Models
{
    public class CustomerModel
    {


        public string setTitulo()
        {
            return "Desarrollo web";
        }
        public DataTable FillGrtidView()
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-COKCL6I;Initial Catalog=northwind;Integrated Security=true;
");
            DataTable dt = new DataTable();

            if (sqlcon.State == ConnectionState.Closed)
            {
               
                string sql = "select * from customer";
                SqlCommand cmd;
                cmd = new SqlCommand(sql, sqlcon);
                sqlcon.Open();

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                
                sda.Fill(dt);
            }
            return dt;
        }
    }
}
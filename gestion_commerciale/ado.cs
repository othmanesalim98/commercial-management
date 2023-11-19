using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace gestion_commerciale
{
    class ado
    {

        //declaration des objets sql
        public static SqlConnection con = new SqlConnection(@"Data Source=SALIM-PC\SQLEXPRESS;Initial Catalog=gestion_commerce1;Integrated Security=True");
        public static SqlCommand cmd = new SqlCommand("", con);
        //public static SqlDataReader dr;
        public static SqlDataAdapter da = new SqlDataAdapter();
        public static DataTable dt;



        //declaration de la methode execute requette
        public static DataTable execute_req(string req)
        {
            dt = new DataTable();

            da = new SqlDataAdapter(req, con);
            da.Fill(dt);
            return dt;

        }
        //declaration de la methode Exceuter_scalar
        public static object Exceuter_scalar(string requet)
        {

            con.Open();
            cmd.CommandText = requet;
            object obj = cmd.ExecuteScalar();
            con.Close();
            return obj;
        }
    }
}

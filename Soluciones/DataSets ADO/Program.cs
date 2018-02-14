using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSets_ADO
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["nombreConnectionString"].ConnectionString;

            using(SqlConnection sql=new SqlConnection(connectionString))
            {
                using(SqlCommand cmd=new SqlCommand("sp_buscar_todo", sql))
                {
                    //El DataSet se usa cuando la consulta retorna varias tablas, DataSet es un conjunto de DataTable
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    sql.Open();
                    da.Fill(ds);

                    //Como acceder a un Datable
                    var dt0 = ds.Tables[1];
                }
            }
            Console.Read();
        }
    }
}

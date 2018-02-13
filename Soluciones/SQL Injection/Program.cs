using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Injection
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new SqlConnectionStringBuilder();
            builder.DataSource = "DESKTOP-HEKH212";
            builder.InitialCatalog = "Prueba2";
            builder.IntegratedSecurity = false;
            builder.UserID = "AndresK2";
            builder.Password = "941215";

            var connectionString = builder.ToString();

            Console.WriteLine("Introduzca el Id del Pais: ");
            var valor = Console.ReadLine();

            //Query Vulnerable
            var query = "select * from Personas where IdPais=" + valor;

            var query2 = "select * from Personas where IdPais=@IdPais";

            Console.WriteLine(query);

            using(SqlConnection sql= new SqlConnection(connectionString))
            {
                using(SqlCommand cmd=new SqlCommand(query2, sql))
                {
                    //Esta es la forma segura de agregar un parametro a la consulta
                    cmd.Parameters.Add(new SqlParameter("@IdPais", valor));

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    sql.Open();
                    da.Fill(dt);

                }
            }
        }
    }
}

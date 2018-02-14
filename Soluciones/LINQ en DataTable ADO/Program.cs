using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_en_DataTable_ADO
{
    class Program
    {
        static void Main(string[] args)
        {
            var personas = ObtenerPersonas(5);

            //Filtrar
            var mayoresDe20 = personas.AsEnumerable().Where(x => x.Field<int>("Edad") > 20).AsDataView();

            //Ordenar
            var ordenar = personas.AsEnumerable().OrderByDescending(x => x.Field<string>("Nombre")).AsDataView();

            //Proyectar
            var resultados = personas.AsEnumerable().Select(x => new
            {
                Nombre = x.Field<string>("Nombre"),
                Edad=x.Field<int>("Edad")
            });

            foreach (var objeto in resultados)
            {
                Console.WriteLine($"Nombre {objeto.Nombre} tiene {objeto.Edad} años");
            }

            Console.Read();

        }

        static DataTable ObtenerPersonas(int IdPais)
        {
            var query = "select * from Personas where IdPais=@IdPais";

            var connectionString = ConfigurationManager.ConnectionStrings["nombreConnectionString"].ConnectionString;

            using(SqlConnection sql=new SqlConnection(connectionString))
            {
                using(SqlCommand cmd=new SqlCommand(query,sql))
                {
                    cmd.Parameters.Add(new SqlParameter("@IdPais", IdPais));

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    sql.Open();
                    da.Fill(dt);
                    return dt;
                }
            }
            
        }
    }
}

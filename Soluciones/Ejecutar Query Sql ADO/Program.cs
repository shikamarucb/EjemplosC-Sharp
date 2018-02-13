using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecutar_Query_Sql_ADO
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["cualquierNombre"].ConnectionString;

            var IdPais = 5;

            var query = @"select *
                        from Personas
                        where IdPais = @IdPais";

            //Console.WriteLine(query);

            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, sql))
                {
                    //Reemplaza @IdPais por el valor de la varible IdPais
                    cmd.Parameters.AddWithValue("@IdPais", IdPais);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    sql.Open();
                    da.Fill(dt);
                }
            }

            /*
             * ESTE QUERY ES SUCEPTIBLE A UN ATAQUE DE INYECCION DE CODIGO SQL!!!!!
             * 
            var query = @"select *
                        from Personas
                        where IdPais = " + IdPais;
            
             

            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                using(SqlCommand cmd = new SqlCommand(query, sql))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    sql.Open();
                    da.Fill(dt);
                }
            }
            
            */

        }
    }
}

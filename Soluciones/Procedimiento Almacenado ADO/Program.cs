using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procedimiento_Almacenado_ADO
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["cualquierNombre"].ConnectionString;

            var IdPais = 2;

            //Console.WriteLine(query);

            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_buscar_persona", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Reemplaza @IdPais por el valor de la varible IdPais //@IdPais corresponde a la declaracion de 
                    //la variable @IdPais en el procedimiento almacenado
                    cmd.Parameters.AddWithValue("@IdPais", IdPais);

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    sql.Open();
                    da.Fill(dt);
                }
            }
        }
    }
}

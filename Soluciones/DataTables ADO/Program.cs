using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTables_ADO
{
    class Program
    {
        static void Main(string[] args)
        {
            var miDataTable = new DataTable();

            //Agregar columnas
            miDataTable.Columns.Add("Nombre", typeof(string));
            miDataTable.Columns.Add("Edad", typeof(int));

            //Agregar filas
            miDataTable.Rows.Add(new object[] { "Felipe", 23 });

            //Borrar datos
            miDataTable.Clear();

            var personas = ObtenerPersonas(1);

            foreach(DataRow dataRow in personas.Rows)
            {
                //Columna Nombre en la BD
                Console.WriteLine(dataRow["Nombre"]);
            }

            //Selecciona las personas donde Edad sea igual a 12
            var filas = personas.Select("Edad=12");

            //Selecciona los valores donde la edad sea igual a 12 y despues suma toda la columna edad
            var resultado = personas.Compute("Sum(edad)","Edad=12");

            //Para ver mas ejemplos de operaciones ver el siguiente link:
            //http://www.csharp-examples.net/dataview-rowfilter/

            Console.Read();

        }

        static DataTable ObtenerPersonas(int IdPais)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["cualquierNombre"].ConnectionString;


            //Console.WriteLine(query);

            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_buscar_persona", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Reemplaza @IdPais por el valor de la varible IdPais //@IdPais corresponde a la declaracion de 
                    //la variable @IdPais en el procedimiento almacenado
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

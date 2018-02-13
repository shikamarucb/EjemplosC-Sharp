using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transacciones_ADO
{
    class Program
    {
        static void Main(string[] args)
        {
            var IdPais = 5;

            var builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"DESKTOP-HEKH212";
            builder.InitialCatalog = "Prueba2";
            builder.IntegratedSecurity = false;
            builder.UserID = "AndresK2";
            builder.Password = "941215";

            var connectionString = builder.ToString();

            try
            {
                using (SqlConnection sql = new SqlConnection(connectionString))
                {
                    //Abre la conexion a la BD
                    sql.Open();

                    //comienza la transaccion
                    var transaction = sql.BeginTransaction();

                    using (SqlCommand cmd = new SqlCommand("sp_insertar_persona", sql, transaction))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@IdPais", IdPais));
                        cmd.Parameters.Add(new SqlParameter("@Nombre", "Alexander"));
                        cmd.Parameters.Add(new SqlParameter("@Edad", 41));

                        cmd.ExecuteNonQuery();
                    }

                    //Si se lanza la excepcion, no se completa la transaccion
                    //throw new Exception();


                    //Aca hay que elegir si se completa la transaccion o se deshace(commit o rollback)

                    //transaction.Rollback();

                    transaction.Commit();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.Read();

            

        }
    }
}

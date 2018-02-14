using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeOut_ADO
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["nombreConnectionString"].ConnectionString;


            try
            {
                using (SqlConnection sql = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_buscar_todo", sql))
                    {
                        int x = 1;

                        //Si la ejecucion del procedimiento almacenado dura mas de "x" segundos arroja una excepcion
                        //Si el valor del CommandTimeout es 0, quiere decir que no tiene limite de espera
                        cmd.CommandTimeout = x;

                        DataSet ds = new DataSet();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);

                        


                        sql.Open();
                        da.Fill(ds);
                    }
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

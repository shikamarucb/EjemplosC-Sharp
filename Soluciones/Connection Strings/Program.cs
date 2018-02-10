using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"DESKTOP-HEKH212";
            builder.InitialCatalog = "Prueba2";

            //para usar windows authentication poner true y quitar UserID y Password
            builder.IntegratedSecurity = false;
            builder.UserID = "AndresK2";
            builder.Password = "941215";

            var connectionString = builder.ToString();*/

            var connectionString = ConfigurationManager.ConnectionStrings["cualquierNombre"].ConnectionString;

            using(SqlConnection sql = new SqlConnection(connectionString))
            {
                sql.Open();
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_out
{
    class Program
    {
        static void Main(string[] args)
        {
            //antes de C# 7
            DateTime dt;
            if(DateTime.TryParse("2012-12-12",out dt))
            {
                //Parse correcto
            }
            else
            {
                //Parse incorrecto
            }

            //despues de C# 7

            if (DateTime.TryParse("2012-12-12", out DateTime dt2))
            {
                //Parse correcto
            }
            else
            {
                //Parse incorrecto
            }

            Console.Read();
        }
    }
}

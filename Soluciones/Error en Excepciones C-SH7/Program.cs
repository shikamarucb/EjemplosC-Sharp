using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error_en_Excepciones_C_SH7
{
    class Program
    {
        static void Main(string[] args)
        {
            int dividir(int a, int b) => (b != 0) ? a / b : throw new Exception("Division entre cero");

            dividir(5, 2);
            dividir(5, 0);

            Console.Read();
        }
    }
}

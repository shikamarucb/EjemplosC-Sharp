using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[5];

            for (int i = 0; i < 5; i++)
            {
                n[i] = new Random(i).Next(1000);
            }

            //usar los breakpoint para observar lo que esta pasando

            Array.Resize<int>(ref n, 12);
            Array.Resize<int>(ref n, 4);
        }
    }
}

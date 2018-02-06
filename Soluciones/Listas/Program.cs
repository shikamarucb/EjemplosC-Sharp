using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 3, 5, 2, -6, 90, 234 ,4,7,9,23,1,1};

            numbers.Add(0);

            numbers.Remove(1);
            numbers.RemoveAt(0);
            numbers.RemoveAt(numbers.Count - 1);

            numbers.Insert(0, 34);
            numbers.Insert(numbers.Count, 43);

            var primerElemento = numbers[0];
            var ultimoElemento = numbers[numbers.Count-1];


            Console.WriteLine("\nFin del Programa");
            Console.Read();
        }
    }
}

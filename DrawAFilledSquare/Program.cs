using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSquare(n);
        }

        private static void PrintSquare(int n)
        {
            PrintHeaderRow(n);
            for (int i = 1; i < n - 1; i++)
            {
                PrintMiddleRow(n);
            }
            PrintHeaderRow(n);
        }

        private static void PrintMiddleRow(int n)
        {
            Console.Write('-');
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }

        private static void PrintHeaderRow(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }
    }
}

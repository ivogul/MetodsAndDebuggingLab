using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int multiply = GetMultiplyEvensByOdds(n);
            Console.WriteLine(multiply);
        }

        private static int GetMultiplyEvensByOdds(int n)
        {
            int sumOfOdds = GetSumOfOdds(n);
            int sumOfEvens = GetSumOfEvens(n);
            return sumOfOdds * sumOfEvens;
        }

        private static int GetSumOfOdds(int n)
        {
            int sum = 0;
            while (Math.Abs(n) > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }

        private static int GetSumOfEvens(int n)
        {
            int sum = 0;
            while (Math.Abs(n) > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }

    }
}

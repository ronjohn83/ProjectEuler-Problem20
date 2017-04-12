using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum());
            Console.ReadLine();
        }

        private static BigInteger Factorial(BigInteger n)
        {


            if (n == 0)
                return 1;


            return n * Factorial(n - 1);
            //int n = 100;
            //BigInteger fact = 1;

            //while (n >= 1)
            //{
            //    fact = fact * n;
            //    n--;
            //}
            //return fact;
        }

        private static BigInteger Sum()
        {
            BigInteger sum = 0;
            BigInteger factorial = (BigInteger)Factorial(100);
            char[] digitsArray = factorial.ToString().ToCharArray();

            foreach (var digit in digitsArray)
            {
                sum += Int32.Parse(digit.ToString());
            }

            return sum;
        }
    }
}

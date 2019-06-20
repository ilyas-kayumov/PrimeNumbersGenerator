using System;
using System.Collections.Generic;

namespace PrimeNumbersGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Invalid arguments number");
                return;
            }

            if (int.TryParse(args[0], out int primeNumbersCount))
            {
                var primeNumbers = GetPrimeNumbers(primeNumbersCount);

                foreach (var n in primeNumbers)
                {
                    Console.Write($"{n} ");
                }
            }
            else
            {
                Console.WriteLine("Invalid argument");
            }
        }

        private static IEnumerable<int> GetPrimeNumbers(int primeNumbersCount)
        {
            int i = 0, number = 1;

            while (i < primeNumbersCount)
            {
                var isPrime = true;

                for (var k = 2; k < number; k++)
                {
                    if (number % k == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    yield return number;
                    i++;
                }

                number++;
            }
        }
    }
}

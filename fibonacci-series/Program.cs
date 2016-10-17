using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci_series
{
    class Program
    {
        static void Main(string[] args)
        {
            Output15FibonacciNumbers();
        }

        static void Output15FibonacciNumbers()
        {
            int firstNumber = 0;
            int secondNumber = 1;
            int newNumber = 0;

            Console.WriteLine("Please enter either 0 or 1 as the first number of the Fibonacci series");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);

            for(var i = 0; i < 12; i++)
            {
                newNumber = firstNumber + secondNumber;

                Console.WriteLine(newNumber);

                firstNumber = secondNumber;

                secondNumber = newNumber;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_FizzBuzz_01102016
{
    class Program
    {
        static void Main(string[] args)
        {
            // This code will play the Fizz Buzz game.
            // A number is selected to be "fizz" and another number to be "buzz".
            // Players will also choose a number to count to.
            // Players (in this case, the computer) displays numbers in order, until a number is reached
            // that is divisible by "fizz".  If the number is divisible by "fizz" then "fizz" is stated.
            // If a number that is divisible by "buzz" is reached, then "buzz" is stated.
            // If the number is divisible by both "fizz" and "buzz", then "fizz buzz" is stated.

            // 01/16/2016 Modified to work in CodeEval

            string line = "3 5 10";
            string[] splitLine = line.Split(new char[] { ' ' }); 

            int userFizz = int.Parse(splitLine[0]);
            int userBuzz = int.Parse(splitLine[1]);
            int countTo = int.Parse(splitLine[2]);

            for (int i = 1; i <= countTo; i++)
            {
                if (i % userFizz == 0)
                {
                    Console.Write("F");
                }
                if (i % userBuzz == 0)
                {
                    Console.Write("B");
                }
                if ((i % userFizz != 0) && (i % userBuzz != 0))
                {
                    Console.Write(i);
                }
                Console.Write(" ");
            }

        }
    }
}

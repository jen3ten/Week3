using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3___ArrayPractice2_01182016
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studentAges = new int[5];
            studentAges[0] = 25;
            studentAges[1] = 12;
            studentAges[2] = 18;
            studentAges[3] = 23;
            studentAges[4] = 20;

            int counter;
            int youngestStudent = 1000;
            for (counter = 0; counter < (studentAges.Length - 1); counter++)
            {
                if (studentAges[counter] < youngestStudent)
                {
                    youngestStudent = studentAges[counter];
                }
            }
            Console.WriteLine($"Youngest student is {youngestStudent}");
            Console.WriteLine();
            
        }
    }
}

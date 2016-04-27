using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_ArrayPractice_01182016
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            //Console.WriteLine(daysOfWeek[1]);
            Console.WriteLine($".Length of daysOfWeek array is {daysOfWeek.Length}");
            Console.WriteLine();

            //Alternative declaration and intialization
            //string[] daysOfWeek = new string[7];
            //daysOfWeek[0] = "Sunday";
            //Console.WriteLine(daysOfWeek[0]);

            //Using "new" declare and initialize array of student ages
            int[] studentAges = new int[5];
            studentAges[0] = 25;
            studentAges[1] = 12;
            studentAges[2] = 18;
            studentAges[3] = 23;
            studentAges[4] = 20;

            //Print out the youngest students age
            Console.WriteLine($"The youngest student is {studentAges[1]} years old.");
            Console.WriteLine();

            //Declare and initialize  array of chars that spells your last name.  Print the length.
            char[] lastNameChar = { 'E', 'v', 'a', 'n', 's' };
            Console.WriteLine($"My last name is {lastNameChar.Length} characters long.");
            Console.WriteLine();

            //String array
            string[] someStrings = { "pen", "dog", "pencil", "kitten", "corvette", "my father" };
            Console.WriteLine($"The second to last element in this array is {someStrings[(someStrings.Length) - 2]}.");
            Console.WriteLine();

            string[] birthMonths = { "October", "July", "October", "May" };
            Console.Write("The index for month 'October' in array 'birthMonths' is ");
            Console.WriteLine(Array.IndexOf(birthMonths, "October"));
            Console.WriteLine();

            //String array of first names. Find and print index of one of the names.
            string[] firstName = { "Jen", "Bob", "Delaney", "Sarah", "Ally", "Mark" };
            Console.Write("What is the index for 'Bob'? ");
            Console.WriteLine(Array.IndexOf(firstName, "Bob"));
            Console.WriteLine();
            //int index = firstName.IndexOf("Bob");  This only works for strings, not arrays
            //Console.WriteLine(index);

            int[] numbers = { 2, 5, 9, 4, 3, 4, 6, 5 };
            Console.Write("The last index of the number 4 is: ");
            Console.WriteLine(Array.LastIndexOf(numbers, 4));
            Console.WriteLine();

            int[] luckyNumbers = { 7, 21, 14, 8, 4, 7, 21, 50, 2, 14, 4, 50 };
            Console.Write("The last index of lucky number 7 is: ");
            Console.WriteLine(Array.LastIndexOf(luckyNumbers, 7));
            Console.WriteLine();

            Array.Reverse(numbers);
            for (int num = 0; num < (numbers.Length - 1); num++)
            {
                Console.WriteLine(numbers[num]);
            }
            Console.WriteLine();

            char[] alpha = { 'a', 'b', 'c', 'e', 'f', 'g', 'x', 'y', 'z' };
            Console.Write("The value of the first element of the array is: ");
            Console.WriteLine(alpha[0]);
            Array.Reverse(alpha);
            Console.Write("The array was reversed.  The value of the first element is: ");
            Console.WriteLine(alpha[0]);
            Console.WriteLine();

            int[] moreNums = { 2, 5, 8, 4, 3, 4, 6, 5 };
            Array.Sort(moreNums);
            for (int index = 0; index < moreNums.Length - 1; index++)
            {
                Console.Write(moreNums[index] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Array.Sort(firstName);
            for (int index = 0; index < firstName.Length; index++)
            {
                Console.Write(firstName[index] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"The first student is {firstName[0]}.");
            Console.WriteLine($"The last student is {firstName[firstName.Length - 1]}.");
            Console.WriteLine();

            int counter = 0;
            int[] favNum = new int[10];
            do
            {
                Console.Write("What is your favorite number? ");
                favNum[counter] = int.Parse(Console.ReadLine());
                counter++;
            } while (counter < 10);
            Array.Sort(favNum);
            Console.Write("The smallest favorite number is: ");
            Console.WriteLine(favNum[0]);
            Console.Write("The largest favorite number is: ");
            Console.WriteLine(favNum[favNum.Length - 1]);
            Console.WriteLine();
        }
    }
}

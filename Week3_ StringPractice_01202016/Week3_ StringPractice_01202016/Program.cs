using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3__StringPractice_01202016
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Enter a name.  Write each character of the name on a separate line.
            Console.Write("Please enter a name: ");
            string name = Console.ReadLine();
            for (int index = 0; index < name.Length; index++)
            {
                Console.WriteLine(name[index]);
            }
            Console.WriteLine();*/

            /*Eliminates loop bracket because only one line of code in loop; sets string length to a variable
            //for efficiency
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            int wordLength = word.Length;
            for (int i = 0; i < wordLength; i++)
                Console.WriteLine(word[i]);
            Console.WriteLine();*/

            /*Favorite movie.
            Console.Write("What is your favorite movie? ");
            string movie = Console.ReadLine();
            Console.WriteLine($"\aYour favorite movie is \"{movie}\"");
            Console.WriteLine();
            */

            /*Favorite book.
            Console.Write("Hello!\a What is your favorite book? ");
            string book = Console.ReadLine();
            Console.WriteLine($"\"{book}\" is my favorite book too!\a\a");
            Console.WriteLine();
            */

            /*Write tab, first name, new line, last name
            Console.WriteLine("Hello, my name is \n\tJennifer\n\tEvans.");
            Console.WriteLine("Your\nname\nis\nsomething\nelse.");
            Console.WriteLine();
            */
            /*
            string word = "Hello";
            string word2 = "HElLo";
            Console.WriteLine(word.Equals(word2));
            Console.WriteLine(word.Equals(word2,StringComparison.CurrentCultureIgnoreCase));
            Console.WriteLine();*/

            /*Do lower case letters come before upper case?
            //This did not work for char data type; it returned the number 32
            string lowerLetter = "a";
            string upperLetter = "A";
            Console.WriteLine(lowerLetter.CompareTo(upperLetter));
            Console.WriteLine();*/

            /*What about plural words?
            string singular = "cat";
            string plural = "cats";
            Console.WriteLine(singular.CompareTo(plural));
            Console.WriteLine();*/

            /*Compare two names
            Console.Write("Enter a name: ");
            string friend1 = Console.ReadLine();
            Console.Write("Enter a second name: ");
            string friend2 = Console.ReadLine();
            int compareValue = friend1.CompareTo(friend2);
            switch (compareValue)
            {
                case -1:
                    Console.WriteLine($"{ friend1} comes before {friend2}");
                    break;
                case 1:
                    Console.WriteLine($"{ friend2} comes before {friend1}");
                    break;
                case 0:
                    Console.WriteLine($"{ friend1} is the same as {friend2}");
                    break;
            }
            Console.WriteLine();*/

            /*int letterCompare = string.Compare("a", "A", false);
            Console.WriteLine(letterCompare);*/

            /*
            Console.WriteLine(string.Concat("Hi", " ", "my name is ", "Jen"));
            Console.WriteLine("Hi" + " " + "my name is " + "Jen");*/

            /*
            Console.WriteLine("hEllo 56!".ToUpper());

            string pass1 = "password", pass2 = "PASSword", pass3 = "PaSsWoRd";
            if (pass1.ToUpper() == "PASSWORD" && pass2.ToUpper() == "PASSWORD" && pass3.ToUpper() == "PASSWORD")
            {
                Console.WriteLine("Your password matches.");
            }
            */

            /*Remove html tags from string
            string removeTags = "<p>This is remaining <a href=\"#\">text</a>. I'd like to keep it.</p>";
            for(int openArrow = 0; openArrow < removeTags.Length; openArrow++)
            {
                openArrow = removeTags.IndexOf("<", openArrow);
                int closeArrow = removeTags.IndexOf(">", openArrow);
                int length = closeArrow - openArrow + 1;
                removeTags = removeTags.Remove(openArrow, length);
            } 
            Console.WriteLine(removeTags);*/

            Console.Write("Do you want to run the code again? (enter <y> if yes): ");
            string runAgain = Console.ReadLine();
            if (runAgain == "y")
            {
                Main(args);
            }
        }   
    }
}

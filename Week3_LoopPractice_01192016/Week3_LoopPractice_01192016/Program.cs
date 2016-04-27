using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_LoopPractice_01192016
{
    class Program
    {
        static void Main(string[] args)
        {
            //Favorite foods
            string[] favFoods = { "pizza", "spaghetti", "chicken mikhani", "lasagna", "ice cream" };
            foreach(string food in favFoods)
            {
                Console.WriteLine($"I like {food}.");
            }
        }
    }
}

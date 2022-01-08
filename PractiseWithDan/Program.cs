using System;
using System.Threading;

namespace PractiseWithDan
{
    class Program
    {
        static void Main(string[] args)
        {

            multiTable();

        }
        private static void multiTable()
        {
            Console.WriteLine("insert the number you want the times table for:");
            int[] times = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            var input = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < times.Length; i++)
            {
                Console.WriteLine($"{i}*{input}={ input * times[i]}");
            }
            doOver();
            
        }
            private static void doOver()
            {
                Console.WriteLine("Would you like another times table? y/n:");
                string answer = Convert.ToString(Console.Read());

                if (answer == "y") { multiTable(); }
                if (answer != "y" || answer != "n"){Console.WriteLine("Read the directions"); doOver();}
            }
    }
}

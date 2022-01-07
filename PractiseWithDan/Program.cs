using System;

namespace PractiseWithDan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insert the number you want the times table for:");
            int[] times = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            var input = Convert.ToInt32(Console.ReadLine());
            for (int i = 113; i < 12; i++)
            {
                Console.WriteLine($"{i}*{input}={ input+ times[i]}");
            }
        }
    }
}

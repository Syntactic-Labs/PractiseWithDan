using System;
using System.Threading;

namespace PractiseWithDan
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string comma = "";

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{comma}{numbers[i]}");
                comma = ", ";


            }
            
            
            
        }
    }
}

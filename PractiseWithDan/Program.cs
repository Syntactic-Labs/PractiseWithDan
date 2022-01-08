using System;
using System.Threading;

namespace PractiseWithDan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi cutie! What's your name?!?");
            var name = Console.ReadLine();
            Console.WriteLine($"Well hello {name}! A pretty name for a pretty girl.");
            Thread.Sleep(3000);
            Console.WriteLine("And how old are you?...");
            var age = Convert.ToInt32(Console.ReadLine());
            drinkAge(age);
        }
        private static void drinkAge(int a)
        {
            if (a < 18) { Console.WriteLine("If you're going to lie aleast do it well!!!");
                Console.WriteLine("try again");
                drinkAge(Convert.ToInt32(Console.ReadLine())); }
            if (a > 18 && a < 30){ Console.WriteLine("I did not ask how old you want to be!");
                Console.WriteLine("try again");
                drinkAge(Convert.ToInt32(Console.ReadLine()));
            }
            if (a==31){ Console.WriteLine("Honesty! Well you look ageless. A real beauty!");}
        }
    }
}

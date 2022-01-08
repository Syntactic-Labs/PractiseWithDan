using System;

namespace PractiseWithDan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The average of four numbers");

            Console.WriteLine("Num 1: ");
            var num1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Num 2: ");
            var num2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Num 3: ");
            var num3 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Num 4: ");
            var num4 = Convert.ToDecimal(Console.ReadLine());
            avg(num1, num2, num3, num4);

        }
        private static void avg(decimal a, decimal b, decimal c, decimal d)
        {
            Console.WriteLine((a+b+c+d)/4);
        }
    }
}

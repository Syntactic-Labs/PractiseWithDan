using System;

namespace PractiseWithDan
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var pyd="#";
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(pyd);
                pyd += "#";
            }*/

            /*for (int i = 1; i < 100; i++)
            {
                var result = "";
                if (i % 3 == 0){ result += "Fizz"; }
                if (i % 5 == 0){ result += "Buzz"; }
                if (result == ""){ result += i; }
                Console.WriteLine(result);
            }
            */
            //var size = 10;

            //for (int i = 0; i < size; i++)
            //{
            //    var result = "";
            //    for (int L = 0; L < size; L++)
            //    {
            //        if ((i+L)%2==0){ result += "O"; }
            //        if ((i+L) % 2==1){ result += "X"; }

            //    }
            //    Console.WriteLine(result);
            //}

            int[] Fred = { 1, 2, 3, 4, 5, 56 };


            for (int i = 0; i < Fred.Length; i++)
            {
                Console.WriteLine($"{Fred[i]},");
            }
            

        }
    }
}

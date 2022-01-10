using System;
using C = System.Console;
using System.Threading;

namespace PractiseWithDan
{
    class Program
    {
        static void Main(string[] args)
        {   //C.WriteLine("Insert the number you want the times table for:");
            //MultiTable();
            var stringEx = "This is only a test!";
            C.WriteLine(stringEx.ToLower());
            var pie = Math.PI;
            C.WriteLine(Math.Abs(pie));
            for (int i = 0; i < 100; i++)
            {
                if (i%2!=0)
                {
                    C.WriteLine(i);
                }

            }
            
            

        }
        //private static void MultiTable()
        //{   int[] times = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        //    var input = C.ReadLine();
        //    if (Int32.TryParse(input, out var number )) {
        //        C.Clear();
        //        C.WriteLine($"You choose: {input}");
        //        for (int i = 0; i < times.Length; i++) 
        //        { C.WriteLine($"{i}*{number}={ number * times[i]}"); }
        //        DoOver();
        //    } else {
        //        C.Clear();
        //        C.WriteLine("!!!Pick a real number!!!");
        //        MultiTable();
        //    }
        //}
        //private static void DoOver()
        //{   C.WriteLine("Would you like another times table? y/n:");
        //    string answer = C.ReadLine();
        //    if (answer == "y") { C.Clear(); C.WriteLine("Insert the number you want the times table for:"); MultiTable(); }
        //    if (answer != "y" && answer != "n") { C.Clear(); C.WriteLine("Read the directions"); DoOver();}
        //}



    }
}

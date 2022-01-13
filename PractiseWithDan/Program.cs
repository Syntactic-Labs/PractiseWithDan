using System;
using C = System.Console;
using System.Threading;
using System.Collections.Generic;

namespace PractiseWithDan
{
    class Program
    {
        static void Main(string[] args)
        {   //C.WriteLine("Insert the number you want the times table for:");
            //MultiTable();
            var pracLine = "I am going to reverse the order of these words.";
            C.WriteLine($"pracLine: {pracLine}");
            var res = "";
            List<string> wordsList = new List<string>();
            string[] words = pracLine.Split(new[] { " " }, StringSplitOptions.None);
            for (int i = words.Length - 1; i >= 0; i--)
            {
                res += words[i] + " ";
            }
            wordsList.Add(res);
            foreach (var w in wordsList)
            {
                C.WriteLine($"Reverse: {w}");
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

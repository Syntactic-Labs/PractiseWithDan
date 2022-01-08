using System;
using System.Threading;

namespace PractiseWithDan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(stringRemove("Michael",3));
        }
        private static string stringRemove(string str, int num) {
            return str.Remove(num, 3);
        }
    }
}

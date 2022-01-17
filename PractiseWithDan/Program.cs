using System;
using C = System.Console;
using System.Threading;
using System.Collections.Generic;
using System.IO;

namespace PractiseWithDan
{
    class Program
    {
        static void Main(string[] args)
        {
            Books book = new("Lord of the Rings", "Jk Rowling", 25, 350, true);
            Books book1 = new("Fly", "Someguy", 42, 826, true);
            book1.Print();
            book.Print();
        }
        
    }
}

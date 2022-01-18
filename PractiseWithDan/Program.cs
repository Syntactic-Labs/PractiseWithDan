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
            Books book = new(title: "Fly", author: "Someguy", inventory: 42, pages: 826, inStock: true);
            Books book1 = new(title:"Fly", author:"Someguy", inventory: 42, pages:826, inStock:true);
            Books book2 = new(title: "Fly", author: "Someguy", inventory: 42, pages: 826, inStock: true);
            Books book3 = new(title: "Fly", author: "Someguy", inventory: 42, pages: 826, inStock: true);
            Books book4 = new(title: "Fly", author: "Someguy", inventory: 42, pages: 826, inStock: true);
            Books[] list = { book, book1, book2, book3, book4, };
            foreach (var b in list)
            {
                b.Print();
            }

        }

    }
}

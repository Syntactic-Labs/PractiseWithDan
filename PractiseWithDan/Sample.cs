using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseWithDan
{
    class Books
    {
        private static int NextId = 1;
        public int Id { get; set; } = 1;
        public string Title { get; set; }
        public string Author { get; set; }
        public int Inventory { get; set; } = 0;
        public int Pages { get; set; }
        public bool InStock { get; set; }
        
        public Books() { }
        public Books(string title, string author, int inventory, int pages, bool inStock)
        {  
            this.Id = NextId++;
            this.Title = title;
            this.Author = author;
            this.Inventory = inventory;
            this.Pages = pages;
            this.InStock = inStock;
        }
        public void Print()
        {
            Console.WriteLine($"Id:{this.Id} | Title:{this.Title} | Author:{this.Author} | Inventory:{this.Inventory} | Pages:{this.Pages} | InStock:{this.InStock}");
            Console.WriteLine("");
        }
    }
}

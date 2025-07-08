using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.MVC
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool IsAvailable { get; set; } = true;

        public Book() { }

        public Book(string title, string author, string isbn, bool isAvalible)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            IsAvailable = isAvalible;
        }
    }
}

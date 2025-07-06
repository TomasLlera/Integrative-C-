using System;
using System.Collections.Generic;
using Models.MVC;
using Repository;
using Views;

namespace Controllers
{
    public class BookController
    {
        public List<Book> LoadBook() => BookView.CreateBook();
        public void ShowBook(List<Book> book) => BookView.ShowBook(book);
    }
}

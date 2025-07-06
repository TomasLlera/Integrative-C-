using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.MVC;

namespace Views
{
    public class BookView
    {
        public static List<Book> CreateBook()
        {
            List<Book> list = new List<Book>();
            string input;
            do
            {
                try
                {
                    Console.WriteLine("=== ADD A NEW BOOK ===\n");

                    Console.WriteLine("→ Title       : ");
                    string title = UserView.ValidInput(true);

                    Console.WriteLine("→ Author      : ");
                    string author = UserView.ValidInput(true);

                    Console.WriteLine("→ ISBN        : ");
                    string isbn = UserView.ValidInput(true);

                    Console.WriteLine("→ Available? (y/n): ");
                    string availability = Console.ReadLine().Trim().ToLower();
                    bool available = (availability == "y");

                    list.Add(new Book(title, author, isbn, available));
                }
                catch (Exception e) 
                {
                    Console.WriteLine($"[ERROR] The book can´t be created.{e.Message}");
                    return null;
                }
                Console.WriteLine("Do you wanna add another book? (y/n)");
                input = Console.ReadLine().ToLower();

            }while (input == "y");
            return list;
        }

        public static void ShowBook(List<Book> books)
        {
            Console.WriteLine("╔════╦════════════════════════════════╦════════════════════╦══════════════╦═══════════════╗");
            Console.WriteLine("║ #  ║ Title                          ║ Author             ║ ISBN         ║ Status        ║");
            Console.WriteLine("╠════╬════════════════════════════════╬════════════════════╬══════════════╬═══════════════╣");

            for (int i = 0; i < books.Count; i++)
            {
                string status = books[i].IsAvailable ? "Available" : "Not Available";
                Console.WriteLine($"║ {i,-2} ║ {books[i].Title,-30} ║ {books[i].Author,-18} ║ {books[i].ISBN,-12} ║ {status} ║");
            }

            Console.WriteLine("╚════╩════════════════════════════════╩════════════════════╩══════════════╩═══════════════╝");
        }
    }
}
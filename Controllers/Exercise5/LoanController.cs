using System;
using System.Collections.Generic;
using Models.MVC;
using Views;
using Repository;

namespace Controllers
{
    public class LoanController
    {
        private List<Loan> loanList = new List<Loan>();
        private List<Book> bookList = new List<Book>();
        public BookController bController;
        public UserController uController;

        public LoanController()
        {
            bController = new BookController();
            uController = new UserController();
            LoadLoans();
            LoadBooks();
        }

        public void LoadLoans() => loanList = Repository<Loan>.ObtenerTodos("loans");
        public void SaveLoans() => Repository<Loan>.GuardarLista("loans", loanList);
        public void LoadBooks() => bookList = Repository<Book>.ObtenerTodos("books");
        public void SaveBooks() => Repository<Book>.GuardarLista("books", bookList);

        public void CreateBook()
        {
            var books = bController.LoadBook(); 
            if (books == null || books.Count == 0)
            {
                LoanView.ShowMsg("[ERROR] No books were created.");
                return;
            }

            bookList.AddRange(books); 
            SaveBooks();
            LoanView.ShowMsg("Books saved successfully.");
        }
        public void ShowBookList()
        {
            LoanView.ShowMsg("-------------------------------------- Book List ---------------------------------------");

            if (bookList.Count == 0)
            {
                LoanView.ShowMsg("[ERROR] The book list is empty.");
                return;
            }

            bController.ShowBook(bookList); 
        }
        public void ListAvailableBooks()
        {
            var availableBooks = bookList.FindAll(b => b.IsAvailable);

            if (availableBooks.Count == 0)
            {
                LoanView.ShowMsg("[INFO] No books available at the moment.");
                return;
            }

            LoanView.ShowMsg("-------------------------------- Available Books --------------------------------");
            bController.ShowBook(availableBooks);
        }
        public void LendBook()
        {
            ListAvailableBooks();

            if (!bookList.Exists(b => b.IsAvailable))
                return;

            Console.WriteLine("Enter the index of the book to lend:");
            if (!int.TryParse(Console.ReadLine(), out int index) || index < 0 || index >= bookList.Count || !bookList[index].IsAvailable)
            {
                LoanView.ShowMsg("[ERROR] Invalid selection.");
                return;
            }

            Book selectedBook = bookList[index];
            User user = uController.LoadUser();

            Loan newLoan = new Loan
            {
                User = user,
                Book = bookList[index],
                LoanDate = DateTime.Now
            };

            selectedBook.IsAvailable = false;
            loanList.Add(newLoan);

            SaveLoans();
            SaveBooks();

            LoanView.ShowMsg("Book loaned successfully!");
        }
        public void ReturnBook()
        {
            if (loanList.Count == 0)
            {
                LoanView.ShowMsg("[INFO] There are no active loans.");
                return;
            }

            for (int i = 0; i < loanList.Count; i++)
            {
                Loan loan = loanList[i];
                var book = loan.Book; 
                string status = $"{loan.User.Name} - {book.Title} (ISBN: {book.ISBN})";
                Console.WriteLine($"[{i}] {status}");
            }

            Console.WriteLine("Enter the index of the loan to return:");
            if (!int.TryParse(Console.ReadLine(), out int index) || index < 0 || index >= loanList.Count)
            {
                LoanView.ShowMsg("[ERROR] Invalid selection.");
                return;
            }

            Book returnedBook = loanList[index].Book;
            returnedBook.IsAvailable = true;

            loanList.RemoveAt(index);

            SaveBooks();
            SaveLoans();

            LoanView.ShowMsg("Book returned successfully!");
        }
        public void ShowLoans()
        {
            if (loanList.Count == 0)
            {
                LoanView.ShowMsg("[INFO] No active loans.");
                return;
            }

            LoanView.ShowMsg("\n╔════════════════════════════════════════════════════════════════════╗");
            LoanView.ShowMsg("║                             Active Loans                           ║");
            LoanView.ShowMsg("╠════════════════════════════════════════════════════════════════════╣");

            foreach (var loan in loanList)
            {
                var book = loan.Book;
                Console.WriteLine("║       User : {0,-20} Book : {1,-25} ║", loan.User.Name, book.Title);
                Console.WriteLine("║       ISBN : {0,-15} Loan Date : {1,-15}           ║", book.ISBN, loan.LoanDate.ToShortDateString());
                Console.WriteLine("╠════════════════════════════════════════════════════════════════════╣");
            }

            LoanView.ShowMsg("╚════════════════════════════════════════════════════════════════════╝");
        }
    }
}
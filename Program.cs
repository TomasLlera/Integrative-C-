using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;
using Classes._3;
using Classes._4;
using Interfaces._3;
using Controllers;
using Models.MVC;
using Views;

namespace TP_INTEGRADOR_1
{
    internal class Program
    {
        static void Main(string[] arg)
        {
            PrincipalMenu();
        }
        public static void PrincipalMenu()
        {
            bool salida = false;

            do
            {
                Console.Clear();
                Console.WriteLine("=== EXERCISE MANAGEMENT MENU ===");
                Console.WriteLine("1. Fundaments of POO");
                Console.WriteLine("2. Inheritance and Polymorphism");
                Console.WriteLine("3. SOLID principles");
                Console.WriteLine("4. CRUD + JSON + Repository");
                Console.WriteLine("5. Proyect Final MVC");
                Console.WriteLine("0. Exit");
                Console.Write("Select an option: ");

                try
                {
                    char opc = Console.ReadKey().KeyChar;
                    Console.Clear();

                    switch (opc)
                    {
                        case '1':
                            Exercise1();
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            break;
                        case '2':
                            Exercise2();
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            break;
                        case '3':
                            Exercise3();
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            break;
                        case '4':
                            Exercise4();
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            break;
                        case '5':
                            Exercise5();
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            break;
                        case '0':
                            Console.WriteLine("Exiting the program...");
                            salida = true;
                            break;
                        default:
                            Console.WriteLine("[ERROR] Invalid option. Try again.");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (FormatException fe)
                {
                    Console.WriteLine($"[FORMAT ERROR] {fe.Message}");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[UNEXPECTED ERROR] {ex.Message}");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }

            } while (!salida);
        }

        public static void Exercise1()
        {
            Console.WriteLine(new string('=', 50));
            try
            {
                Citizen citizen = new Citizen("Juan Carlos", "54587755", 69);
                Console.WriteLine(citizen.Greet());
                Console.WriteLine(citizen.IsAdult());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] The citizen can´t be created.{ex.Message}");
            }

            Console.WriteLine(new string('=', 50));
        }
        public static void Exercise2()
        {
            Console.WriteLine(new string('=', 50));

            Animal miPerro = new Dog("Scooby");
            Animal miGato = new Cat("MaoMao");

            Console.WriteLine(miPerro.MakeSound());
            Console.WriteLine(miGato.MakeSound());

            Console.WriteLine(miPerro.Presentation());
            Console.WriteLine(miGato.Presentation());

            Console.WriteLine(new string('=', 50));
        }
        public static void Exercise3()
        {
            Console.WriteLine(new string('=', 50));

            var calculator = new InvoiceCalculator();
            calculator.CalculateTotal();

            IDigitalPrinter printer = new PDFPrinter();
            printer.PrintInvoice();

            var saver = new InvoiceSaver();
            saver.SaveToFile();

            Console.WriteLine(new string('=', 50));
        }
        public static void Exercise4()
        {
            ProductCRUD crud = new ProductCRUD();
            bool salida = false;

            do
            {
                Console.Clear();
                Console.WriteLine("=== PRODUCT MANAGEMENT MENU ===");
                Console.WriteLine("1. Add New Product");
                Console.WriteLine("2. Show All Products");
                Console.WriteLine("3. Modify Product");
                Console.WriteLine("4. Delete Product");
                Console.WriteLine("0. Exit");
                Console.Write("Select an option: ");

                try
                {
                    char opc = Console.ReadKey().KeyChar;
                    Console.Clear();

                    switch (opc)
                    {
                        case '1':
                            crud.CreateProduct();
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            break;
                        case '2':
                            crud.ShowProducts();
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            break;
                        case '3':
                            crud.ModifyProduct();
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            break;
                        case '4':
                            crud.DeleteProduct();
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            break;
                        case '0':
                            Console.WriteLine("Exiting the program...");
                            salida = true;
                            break;
                        default:
                            Console.WriteLine("[ERROR] Invalid option. Try again.");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (FormatException fe)
                {
                    Console.WriteLine($"[FORMAT ERROR] {fe.Message}");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[UNEXPECTED ERROR] {ex.Message}");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }

            } while (!salida);
        }
        public static void Exercise5()
        {
            LoanController controller = new LoanController();
            controller.LoadLoans();
            controller.LoadBooks();

            bool exit = false;
            do
            {
                Console.Clear();
                Console.WriteLine("=========== Library System ===========");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Show All Books");
                Console.WriteLine("3. List Available Books");
                Console.WriteLine("4. Lend Book");
                Console.WriteLine("5. Return Book");
                Console.WriteLine("6. Show Active Loans");
                Console.WriteLine("7. Exit");
                Console.WriteLine("Select an option:");

                try
                {
                    char option = Console.ReadKey().KeyChar;
                    Console.Clear();

                    switch (option)
                    {
                        case '1':
                            controller.CreateBook();
                            break;
                        case '2':
                            controller.ShowBookList();
                            break;
                        case '3':
                            controller.ListAvailableBooks();
                            break;
                        case '4':
                            controller.LendBook();
                            break;
                        case '5':
                            controller.ReturnBook();
                            break;
                        case '6':
                            controller.ShowLoans();
                            break;
                        case '7':
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("[ERROR] Invalid option. Try again.");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"[ERROR] Unexpected error: {e.Message}");
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            } while (!exit);
        }
    }
}

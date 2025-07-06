using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.MVC;

namespace Views
{
    public class UserView
    {
        public static User CreateUser()
        {
            Console.WriteLine("=== ADD A NEW USER ===\n");

            Console.WriteLine("→ Name  : ");
            string name = ValidInput(true);

            Console.WriteLine("→ Email : ");
            string email = ValidInput(false, true);

            return new User(name, email);
        }

        public static void ShowUser(User user)
        {
            Console.WriteLine("╔════════════════════════════╗");
            Console.WriteLine("║         USER INFO          ║");
            Console.WriteLine("╠════════════════════════════╣");
            Console.WriteLine($"║ Name : {user.Name.PadRight(20)}║");
            Console.WriteLine($"║ Email: {user.Email.PadRight(20)}║");
            Console.WriteLine("╚════════════════════════════╝");
        }

        public static string ValidInput(bool IsString = false, bool IsMail = false)
        {
            string input;
            bool isValid = false;

            do
            {
                input = Console.ReadLine();
                if (IsString && !string.IsNullOrWhiteSpace(input))
                    isValid = true;
                else if (IsMail && input.Contains("@"))
                    isValid = true;
                else
                    Console.WriteLine("[ERROR] Invalid input. Try again.");
            } while (!isValid);

            return input;
        }
    }
}
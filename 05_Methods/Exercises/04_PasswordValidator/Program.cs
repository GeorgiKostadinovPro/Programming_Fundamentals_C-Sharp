using System;
using System.Linq;

namespace _04_PasswordValidator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string password = Console.ReadLine();

            IsValid(password);
        }

        private static void IsValid(string password)
        {
            bool isValid = true;

            if (password.Length < 6 || password.Length > 10)
            {
                isValid = false;
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (password.Any(c => !char.IsLetterOrDigit(c)))
            {
                isValid = false;
                Console.WriteLine( "Password must consist only of letters and digits");
            }

            if (password.Count(c => char.IsDigit(c)) < 2)
            {
                isValid = false;
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
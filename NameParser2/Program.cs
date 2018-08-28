using System;
using NameParser2.Names;

namespace NameParser2
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = new FirstName();
            firstName.GetName();
            firstName.PrintName();

            
            Console.WriteLine("What is your last name?");
            var lastName = Console.ReadLine();
            var lastNameWithSpaces = "";

            foreach (var letter in lastName.ToUpper())
            {
                lastNameWithSpaces += letter + "";
            }

            Console.WriteLine(lastNameWithSpaces.Trim());

            Console.WriteLine("Do you have a middle name? (y/n)");
            var hasMiddleName = Console.ReadLine();
            var middleName = "";

            if (hasMiddleName == "y")
            {
                Console.WriteLine("What is it?");
                middleName = Console.ReadLine();
                var i = 0;

                foreach (var letter in middleName)
                {
                    Console.WriteLine(letter.ToString().PadLeft(++i));
                }
            }
            else
            {
                Console.WriteLine($"{firstName}, that is the saddest thing i have ever heard.");
            }
            Console.WriteLine($"Goodbye {firstName} {middleName} {lastName}. Press enter to exit.");
            Console.ReadLine();
        }
    }
}

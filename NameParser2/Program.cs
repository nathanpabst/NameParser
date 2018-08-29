using System;
using NameParser2.Names;

namespace NameParser2
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = new FirstName();
            var lastName = new LastName();
            var middleName = new MiddleName(firstName);

            firstName.GetName();
            firstName.PrintName();

            lastName.GetName();
            lastName.PrintName();

            middleName.GetName();
            middleName.PrintName();


            Console.WriteLine($"Goodbye {firstName.Name} {middleName.Name} {lastName.Name}. Press enter to exit.");
            Console.ReadLine();


        }
    }
}

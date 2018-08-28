using System;
using System.Collections.Generic;
using System.Text;

namespace NameParser2.Names
{
    class MiddleName
    {
        public string Name { get; private set; } = "";


        public void GetName(string firstName)
        {
            if (userHasMiddleName())
            {
                Console.WriteLine("What is it?");
                Name = Console.ReadLine();           
            }
            else
            {
                Console.WriteLine($"{firstName}, that is the saddest thing i have ever heard.");
            }
        }

        bool userHasMiddleName()
        {
            Console.WriteLine("Do you have a middle name? (y/n)");
            var hasMiddleName = Console.ReadLine();

            return hasMiddleName == "y";
        }

        public void PrintName()
        {
            var i = 0;
            foreach (var letter in Name)
            {
                Console.WriteLine(letter.ToString().PadLeft(++i));
            }
        }
        
    }
}

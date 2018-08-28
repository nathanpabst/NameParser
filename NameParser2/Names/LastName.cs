using System;
using System.Collections.Generic;
using System.Text;

namespace NameParser2.Names
{
    class LastName
    {
        public string Name { get; private set; }

        public void GetName()
        {
            Console.WriteLine("What is your last name?");
            Name = Console.ReadLine();
        }

        public void PrintName()
        {
            var lastNameWithSpaces = "";

            foreach (var letter in Name.ToUpper())
            {
                lastNameWithSpaces += letter + "";
            }

            Console.WriteLine(lastNameWithSpaces.Trim());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace NameParser2.Names
{
    class FirstName
    {
        private string _firstName;

        public void GetName()
        {
            Console.WriteLine("What is your first name?");
            _firstName = Console.ReadLine();

        }

        public void PrintName()
        {

            foreach (var letter in _firstName)
            {
                Console.WriteLine(letter);
            }
        }
        public void GetAndPrint()
        {
            GetName();
            PrintName();
        }
    }
}

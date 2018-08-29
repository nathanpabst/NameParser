using System;
using System.Collections.Generic;
using System.Text;

namespace NameParser2.Names
{
    class FirstName : NameBase
    {
        public FirstName() : base("first")
        {}

        public void PrintName()
        {
            foreach (var letter in Name)
            {
                Console.WriteLine(letter);
            }
        }

    }
}

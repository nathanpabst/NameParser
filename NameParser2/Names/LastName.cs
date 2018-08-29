using System;
using System.Collections.Generic;
using System.Text;

namespace NameParser2.Names
{
    class LastName : NameBase
    {
        public LastName() : base("last")
        {}

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

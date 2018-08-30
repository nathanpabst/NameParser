using System;

namespace NameParser2.Names
{
    //LastName inherits from NameBase
    class LastName : NameBase
    {
        //constructor method
        public FirstName FirstName { get; }
        public LastName() : base("last")
        {}

        public LastName(FirstName firstName) : this()
        {
            FirstName = firstName;
   
        }
        //method
        public override void PrintName()
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

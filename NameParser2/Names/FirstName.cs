﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NameParser2.Names
{
    class FirstName
    {
        public string Name { get; private set; }

        public void GetName()
        {
            Console.WriteLine("What is your first name?");
            Name = Console.ReadLine();
        }

        public void PrintName()
        {

            foreach (var letter in Name)
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

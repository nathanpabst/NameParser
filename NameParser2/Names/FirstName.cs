﻿using System;

namespace NameParser2.Names
{
    class FirstName : NameBase
    {
        public FirstName() : base("first")
        {}

        public override void PrintName()
        {
            foreach (var letter in Name)
            {
                Console.WriteLine(letter);
            }
        }

    }
}

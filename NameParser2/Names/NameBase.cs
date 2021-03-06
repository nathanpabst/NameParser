﻿using System;


namespace NameParser2.Names
{
    //abstract classes can not be instantiated
    abstract class NameBase
    {
        private readonly string _whichName;

        public string Name { get; protected set; }

        public NameBase(string whichName)
        {
            _whichName = whichName;
        }

        public virtual void GetName()
        {
            Console.WriteLine($"Enter your {_whichName} name?");
            Name = Console.ReadLine();
        }

        public abstract void PrintName();
    }
}

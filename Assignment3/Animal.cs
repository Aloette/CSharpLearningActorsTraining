﻿using System;

namespace Assignment3
{
    public abstract class Animal
    {
        string Name;

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }
        public abstract void Eat();
    }
}

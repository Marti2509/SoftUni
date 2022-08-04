﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Pet : IBirthable
    {
        private string name;
        private string birthdate;

        public Pet(string name, string birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public string Birthdate
        {
            get { return birthdate; }
            private set { birthdate = value; }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Czwiczenia3.Models
{
    public class Student
    { 
        public int IdStudent { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string IndexNumber { get; set; }
        
        public override string ToString()
        {
            return IdStudent + " " + IndexNumber + " " +  FirstName + " " + LastName;
        }
    }
}
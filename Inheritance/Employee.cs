﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Employee : Person
    {
        public int ID { get; set; }

        //overriding equals and getHash
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        //Overloading the "==" operator so it checks if two Employee objects are equal by comparing their Id property.
        public static bool operator== (Employee employee, Employee employee2)
        {
            if (employee.ID == employee2.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator!= (Employee employee, Employee employee2)
        {
            if (employee.ID != employee2.ID)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
    }
}

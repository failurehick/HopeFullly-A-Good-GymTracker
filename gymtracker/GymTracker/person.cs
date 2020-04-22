using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
     Title: Person
     Author: Keaton Sutcliffe
     Date:31/03/2020
     Purpose: Hold data for person as user
*/

namespace GymTracker
{
    public class Person
    {
        /* NO METHODS IN THIS CLASS */

        private string personName;

        public string PersonName
        {
            get { return personName; }
            set { personName = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private float rate;

        private int weight;

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        
    }
}

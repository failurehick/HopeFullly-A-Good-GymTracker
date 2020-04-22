using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
     Title: Activity
     Author: Keaton Sutcliffe
     Date:31/03/2020
     Purpose: Holds data for gym activities
*/

namespace GymTracker
{
    public class Activity
    {
        public string MachineName { get; set; }
        public string Level { get; set; }
        public bool Weighted { get; set; }
        public int Duration { get; set; }

        //Total end vaule
        public double Used { get; set; }
    }
}

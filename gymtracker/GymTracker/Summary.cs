using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
     Title: Summary
     Author: Keaton Sutcliffe
     Date:13/04/2020
     Purpose: Data for summary display
*/


namespace GymTracker
{
   public class Summary
    {
        private Person person;
        public Person SessionPerson
        {
            get { return person; }
            set { person = value; }
        }

        private int minutesOfExercise;

        public int MinutesOfExercise
        {
            get { return minutesOfExercise; }
            set { minutesOfExercise = value; }
        }

        private int totalUsed;

        public int TotalUsed
        {
            get { return totalUsed; }
            set { totalUsed = value; }
        }
    }
}

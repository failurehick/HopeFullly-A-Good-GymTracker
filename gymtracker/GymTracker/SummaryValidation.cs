using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
     Title: SummaryValidation
     Author: Keaton Sutcliffe
     Date:13/04/2020
     Purpose: Validate data ranges
*/


namespace GymTracker
{
    public class SummaryValidation
    {
        internal static int numberActivitiesMinimum = 2;
        internal static int numberActivitiesMaximum = 6;

        public static bool NumberActivitiesValid(int activities)
        {
            return activities >= numberActivitiesMinimum && activities <= numberActivitiesMaximum;
        }
    }
}

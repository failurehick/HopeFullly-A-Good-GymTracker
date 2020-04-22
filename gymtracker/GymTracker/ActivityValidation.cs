using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
     Title: ActivityValidation
     Author: Keaton Sutcliffe
     Date:19/04/2020
     Purpose: Rules check on duration
*/


namespace GymTracker
{
    public class ActivityValidation
    {
        internal static int activityDurationMinmum = 5;
        internal static int activityDurationMaxium = 60;

        public static bool ActivityDurationValid(int duration)
        {
            return duration >= activityDurationMinmum && duration <= activityDurationMaxium;
        }


    }
}

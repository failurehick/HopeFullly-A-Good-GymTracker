using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
     Title: Utility
     Author: Keaton Sutcliffe
     Date:31/03/2020
     Purpose: Arithmetic methods for program.
*/

namespace GymTracker
{
    class Utility
    {
        //<summary> Check if a string is already in a list </summary>
        //<param name="listToSearch"></param>
        //<param name="stringToFind"></param>
        //<returns>Boolean</returns>
        public static bool StringFound(List<string> listToSearch, string stringToFind)
        {
            //tracker variable
            bool stringFound = false;
            //look through all
            foreach(string value in listToSearch)
            {   //If the if statment is not done the bool is left as false
                if (value == stringToFind)
                {
                    stringFound = true;
                    return stringFound;
                }
                 
            }
            //Return if the list is true or flase
            return stringFound; 
        }
       
        //#endregion
        
        //Incomplete
        public static float CalculateActivityRate(string machine, string level, string duration)
        {
            float valueTemp = 0;
            return valueTemp;
        }
        
        //Making minutes into hours to find correct rate converson
        public static double MinutesFractionOfHour(int minutes)
        {   //finding a fraction of hours from minutes
            return (double)minutes / 60;
        }
        
        //displaying duration in a nice looking way
        public static string HoursAndMinutes(int minutes)
        {
            var tempString = string.Empty;
            //What ever is left is the amount of minutes for example 65mins would equal 5 so 5 minutes
            int minutesRemainder = minutes % 60;
            //How many 60's can fit in the number and this tells us how many hours there is
            int hours = (int)minutes / 60;
            //Outputs both Amount of minutes and hours into a string with some text 
            tempString = hours.ToString() + "Hours amd " + minutesRemainder + " minutes";
            return tempString;
        }
    }
}

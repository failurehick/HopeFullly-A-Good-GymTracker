using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

/*
     Title: Lists
     Author: Keaton Sutcliffe
     Date:31/03/2020
     Purpose: Provide lists of items for the interface
*/
namespace GymTracker
{
    public class Lists
    {
        internal static string dataPath = @"C:\Users\keat1\OneDrive\Documents\GitHub\TrackingGymApp\gymtracker.txt";

        //<summary>Get list of machines from the text file database </summary>
        //<returns>List<string></returns>
        public static List<string> Machines()
        {
            //Handler variables
            var path = dataPath;
            var tempList = new List<string>();
            var dt = new DataTable();
            //Collect data from the database
            dt = ImportData.GetTextFileData(path);
            //Use a try .. catch block to trap errors found
            try
            {
                //Iterate through the data rows to find unique machine names
               foreach (DataRow row in dt.Rows)
               {
                    //useing an object to hold the data from each row
                    //Intellisense will know valid object field item in the row of data
                    var lineData = new MachineData
                    {
                        MachineName = row.Field<string>(0),
                        Level = row.Field<string>(1)
                    };

                    if(!Utility.StringFound(tempList, lineData.MachineName))
                    {
                        tempList.Add(lineData.MachineName);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            //return the list
            return tempList;
         }

        //<summary>Get list of levels from the text file database. </summary>
        //<returns>list<string></string></returns>
        public static List<string> Levels()
        {
            //Handler variables
            var path = dataPath;
            var tempList = new List<string>();
            var dt = new DataTable();
            //Collect data from the database
            dt = ImportData.GetTextFileData(path);
            //Use a try .. catch block to trap errors found
            try
            {
                //Iterate through the data rows to find unique machine names
                foreach (DataRow row in dt.Rows)
                {
                    //useing an object to hold the data from each row
                    //Intellisense will know valid object field item in the row of data
                    var lineData = new MachineData
                    {
                        MachineName = row.Field<string>(0),
                        Level = row.Field<string>(1)
                    };

                    if (!Utility.StringFound(tempList, lineData.Level))
                    {
                        tempList.Add(lineData.Level);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            //return the list
            return tempList;
        }




    }
}

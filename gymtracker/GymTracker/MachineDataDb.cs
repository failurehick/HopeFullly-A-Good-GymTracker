using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

/*
     Title: MachineDataDb
     Author: Keaton Sutcliffe
     Date:13/04/2020
     Purpose:To Fetch lists from the text file database
*/


namespace GymTracker
{
    public class MachineDataDb
    {
        //<summary> To fetch Machinedata from the text file database.<summary>
        //<returns>DataTable<returns>

        public static DataTable GetMachineData()
        {
            //handles variables
            var path = Lists.dataPath;
            var dt = new DataTable();

            //using try to catch errors
            try
            {
                dt = ImportData.GetTextFileData(path);
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        //get all data columms for a particular machine

        public static List<MachineData> GetIndividualMachineData(string machineName)
        {
            var tempList = new List<MachineData>();
            var dt = MachineDataDb.GetMachineData();

            foreach(DataRow row in dt.Rows)
            {
                var data = new MachineData()
                {
                    MachineName = row.Field<string>(0),
                    Level = row.Field<string>(1),
                    Rate = float.Parse(row.Field<string>(2))
                };

                if(data.MachineName == machineName)
                {
                    tempList.Add(data);
                };
            }

            return tempList;
        }

        public static int GetRate(string machineName, string level)
        {
            float tempRate = 0;

            List<MachineData> machineData = GetIndividualMachineData(machineName);

            foreach(MachineData data in machineData)
            {
                if (data.Level == level)
                {
                    tempRate = data.Rate;
                }
            }

            return Convert.ToInt32(tempRate);
        }

    }
}

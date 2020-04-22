using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
     Title: MachineData
     Author: Keaton Sutcliffe
     Date:13/04/2020
     Purpose:Holding data for the gym machines.
*/


namespace GymTracker
{
    public class MachineData
    {
        private string machineName;

        public string MachineName
        {
            get { return machineName; }
            set { machineName = value; }
        }

        private string level;

        public string Level
        {
            get { return level; }
            set { level = value; }
        }

        private float rate;

        public float Rate
        {
            get { return rate; }
            set { rate = value; }
        }

    }
}

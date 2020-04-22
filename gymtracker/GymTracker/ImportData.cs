using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

/*
     Title: ImportData
     Author: Keaton Sutcliffe
     Date:31/03/2020
     Purpose: Import text file data into the application
*/

namespace GymTracker
{
    public class ImportData
    {
        public static DataTable GetTextFileData(string path)
        {
            StreamReader sr = new StreamReader(path);
            // Read the first line only for column headers
            // and use these to create the DataTable columns
            string[] headers = sr.ReadLine().Split(',');
            DataTable dt = new DataTable();

            // headers
            foreach (string header in headers)
            {
                dt.Columns.Add(header);
            }

            // Read the reamining data into the DataTable
            // to the EndOfStream
            while (!sr.EndOfStream)
            {
                // Regex with escape caharacters
                string[] rows = Regex.Split(sr.ReadLine(), ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
                DataRow dr = dt.NewRow();
                for (int i = 0; i < headers.Length; i++)
                {
                    dr[i] = rows[i];
                }
                dt.Rows.Add(dr);
            }

            // return the DataTable from the method
            return dt;
        }
    }
}

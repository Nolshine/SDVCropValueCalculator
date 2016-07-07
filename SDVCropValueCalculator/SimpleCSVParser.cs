using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SDVCropValueCalculator
{
    /// <summary>
    /// (Very) simple class to parse my CSV file.
    /// </summary>
    class SimpleCSVParser
    {
        /// <summary>
        /// Parse the data in file at 'path'
        /// </summary>
        /// <param name="path">Path to the file</param>
        /// <returns></returns>
        public static List<string[]> parseFile(string path)
        {
            try
            {
                // prepare to store parsed data
                List<string[]> parsedData = new List<string[]>();

                // parse data
                using (StreamReader readFile = new StreamReader(path))
                {
                    string line;
                    string[] row;

                    // skip the header line
                    readFile.ReadLine();

                    while ((line = readFile.ReadLine()) != null)
                    {
                        row = line.Split(',');
                        parsedData.Add(row);
                    }
                }

                // return parsed data
                return parsedData;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
    }
}

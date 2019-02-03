//-----------------------------------------------------------------------
// <copyright file="InputParameters.cs" company="DilyaSoft">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Paparser
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// Enter the path for the csv file
    /// </summary>
    public class InputParameters
    {
        /// <summary>
        /// Enter the file into the console application.
        /// </summary>
        /// <param name="args">I don't use it, but it's wrongly</param>
        /// <para>The parameter of the Main method is a String array that represents the command line arguments.</para>
        public static void Main(string[] args)
        {
            string csvData = string.Empty;
            Console.WriteLine("Please enter path the csv file /in=");
            Dictionary<string, string> parameters = Parser.ParsingInputParameters(Console.ReadLine());
            try
            {
                using (StreamReader sr = new StreamReader(parameters["in"]))
                {
                    csvData = sr.ReadToEnd();
                    sr.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Can not open the file");
                Console.WriteLine(e.Message);
                Console.ReadKey();
                return;
            }

            List<List<string>> parsedData = Parser.ParseData(csvData);
            if (parsedData == null)
            {
                Console.WriteLine("Can not parse this data");
                Console.ReadKey();
                return;
            }

            try
            {
                Parser.BubbleSort(parsedData, parameters["sort"]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Parser.Display(parsedData);
            Console.ReadKey();
        }
    }
}



//-----------------------------------------------------------------------
// <copyright file="Parser.cs" company="DilyaSoft">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Paparser
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Represents the parse CSV file.
    /// </summary>
    /// <para></para>
    public class Parser
    {
        /// <summary>
        /// String parsing with the String.Split parameter
        /// </summary> 
        /// <param name="line">line in csv file</param>
        /// <returns>return input values</returns>
        /// <para>Initialize a value of a key in Dictionary Collection with it,either the key in the collection would be a string data type or other data type</para>
        public static Dictionary<string, string> ParsingInputParameters(string line)
        {
            Dictionary<string, string> inputValues = new Dictionary<string, string>();
            var keys = line.Split('/');
            for (int i = 0; i < keys.Length; i++)
            {
                try
                {
                    inputValues.Add(keys[i].Split('=')[0], keys[i].Split('=')[1].Trim().Trim('"'));
                }
                catch
                {

                }
            }

            return inputValues;
        }

        /// <summary>
        /// File output data.
        /// </summary>
        /// <param name="allLines">Output file contents</param>
        /// <para>File output after sorting and comparison</para>
        public static void Display(List<List<string>> allLines)
        {
            Console.WriteLine("Output:");
            foreach (List<string> columns in allLines)
            {
                for (int i = 0; i < columns.Count; i++)
                {
                    Console.Write(columns[i]);
                    if (i != columns.Count - 1)
                    {
                        Console.Write('|');
                    }
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Sorting data with one of the algorithm
        /// </summary>
        /// <param name="data">Data of csv file</param>
        /// <param name="sort">the string that the number is prefigured</param>
        /// <para>you could use quicksort because sorting is faster than bubble</para>
        public static void BubbleSort(List<List<string>> data, string sort)
        {
            int sortByColumn = Convert.ToInt32(sort) - 1;
            for (int i = 0; i < data.Count * (data.Count - 1); i++)
            {
                for (int k = 0; k < data.Count - 1; k++)
                {
                    if (Comparison(data[k][sortByColumn], data[k + 1][sortByColumn]))
                    {
                        var temp = data[k];
                        data[k] = data[k + 1];
                        data[k + 1] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// the character from the second line is included in [0-9A-Z], unlike the character from the first line, you need to swap lines 
        /// </summary>
        /// <param name="s1">string s1</param>
        /// <param name="s2">string s2</param>
        /// <returns>the first line was not "bigger" than the second return false</returns>
        public static bool Comparison(string s1, string s2)
        {
            for (int i = 0; i < s1.Length && i < s2.Length; i++)
            {
                
                char[] compareChars = { s1[i], s2[i] };
                if (s1[i] == s2[i])
                { 
                    continue;
                }
                else if (WrongSymbol(s1[i]) && WrongSymbol(s2[i]))
                { 
                    continue;
                }
                else if (WrongSymbol(s1[i]) && !WrongSymbol(s2[i]))
                {
                    return true;
                }
                else if (s1[i] > s2[i])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        /// <summary>
        /// for each character in the chars, check if it is included in [0-9A-Z]
        /// </summary>
        /// <param name="c">char c</param>
        /// <returns>return true if it is included in [0-9A-Z]</returns>
        public static bool WrongSymbol(char c)
        {
            string pattern = "[0-9A-Z]";
            if (Regex.IsMatch(c.ToString(), pattern, RegexOptions.Compiled))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// parsing data splitting into characters and columns
        /// </summary>
        /// <param name="data">string data</param>
        /// <returns>return result after parsing</returns>
        public static List<List<string>> ParseData(string data)
        {
            List<List<string>> lines = new List<List<string>>();
            
            List<string> columns = new List<string>();
            
            List<char> symbols = new List<char>();
            
            bool insideQuotes = false;
            for (int i = 0; i < data.Length; i++)
            {
                char c = data[i];
                if (c == '"')
                {
                    insideQuotes = !insideQuotes;
                }
                else if (c == ',' && !insideQuotes)
                {
                    columns.Add(new string(symbols.ToArray()));
                    symbols.Clear();
                }
                else if (c == '\n')
                {
                    if (insideQuotes)
                    {
                        return null;
                    }

                    columns.Add(new string(symbols.ToArray()));
                    symbols.Clear();
                    lines.Add(new List<string>(columns));
                    columns.Clear();
                }
                else
                {
                    symbols.Add(data[i]);
                }
            }

            return lines;
        }
    }      
 }



//-----------------------------------------------------------------------
// <copyright file="ParserTests.cs" company="DilyaSoft">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace TestNinja.UnitTests
{
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Paparser;
   
    /// <summary>
    /// Testing our program
    /// </summary>
    [TestClass]
    public class ParserTests
    {
        [TestMethod]
        public void ParsingInputParams_consoleLine_inputValues()
        {
            //// arrange
            var parser = new Parser();
            string consoleLine = "/sort=3";
            Dictionary<string, string> expected = new Dictionary<string, string>() { { "sort", "3" } };

            //// act
            Dictionary<string, string> actual = Parser.ParsingInputParameters(consoleLine);

            //// assert
            Assert.AreEqual(expected["sort"], actual["sort"]);
        }

        [TestMethod]
        public void WrongSymbol_b_trueReturned()
        {
            // arrange
            char c = 'b';
            bool expected = true;

            // act
            bool actual = Parser.WrongSymbol(c);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Exchange_JanuaryAndJan1a_trueReturned()
        {
            //// arrange
            string s1 = "January";
            string s2 = "Jan1a";
            bool expected = true;

            //// act
            bool actual = Parser.Comparison(s1, s2);

            //// assert
            Assert.AreEqual(expected, actual);
        }

        public void BubbleSort_dataAndSort()
        {
            // arrange
            List<List<string>> data = new List<List<string>>() {
                new List<string>() { "January 21, 1996", "JDK 1.0", "The first public release" },
                new List<string>() { "February 19, 1997", "JDK 1.1", "JavaBeans, JDBC, RMI, reflection" }
            };
            string sort = "3";
            List<List<string>> expected = new List<List<string>>() {
                new List<string>() { "February 19, 1997", "JDK 1.1", "JavaBeans, JDBC, RMI, reflection" },
                new List<string>() { "January 21, 1996", "JDK 1.0", "The first public release" }
            };

            // act
            Parser.BubbleSort(data, sort);
            var actual = data;

            // assert
            Assert.AreEqual(expected.Count, actual.Count);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].Count, actual[i].Count);
                for (int j = 0; j < expected[i].Count; j++)
                {
                    Assert.AreEqual(expected[i][j], actual[i][j]);
                }
            }
        }

        public void Display_allLines()
        {
            // arrange
            List<List<string>> allLines = new List<List<string>>()
            {
                new List<string>() { "February 19, 1997", "JDK 1.1", " JavaBeans, JDBC, RMI, reflection" },
                new List<string>() { "January 21, 1996", "JDK 1.0", " The first public release" }
            };

            // act
            Parser.Display(allLines);
        }
    }
}

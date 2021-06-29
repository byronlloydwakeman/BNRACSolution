using DataManager.Library.DataFormatting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataManager.Library.Tests
{
    public class SerializeDataTests
    {
        /// <summary>
        /// Pass through a given number of strings, the formatted version, and a bool for whether it's a correct version.
        /// Enter the given number of strings into the algorithm as a list.
        /// Then use an if statement to determine whether the strings are equal.
        /// Then use Assert.Equal on the actual bool and the expected bool.
        /// </summary>
        [Theory]
        [InlineData("100", "1500", "520", "100;1500;520;", true)]
        [InlineData("100", "1500", "520", "100;1500520;", false)] //Note missing a semi colon
        public void SerializeTest(string s1, string s2, string s3, string expectedSerialized, bool expected)
        {
            List<string> temp = new List<string>()
            {
                s1,
                s2,
                s3
            };

            string actualSerialized = SerializeData.Serialize(temp);

            bool actual;

            if (actualSerialized == expectedSerialized)
            {
                actual = true;  
            }
            else
            {
                actual = false; 
            }

            Assert.Equal(actual, expected);
        }
    }
}









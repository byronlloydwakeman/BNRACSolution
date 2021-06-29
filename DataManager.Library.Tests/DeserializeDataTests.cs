using DataManager.Library.DataFormatting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataManager.Library.Tests
{
    public class DeserializeDataTests
    {
        /// <summary>
        /// Pass through the string of the data to be deserialized, the deserialized strings and bool for whether it should be equal or not.
        /// Enter the data to deserialized into the algorithm, sets its value to a list of string.
        /// Create a list of string of the deserialized strings.
        /// Create a bool variable to hold whether the lists are equal
        /// Loop through the list checking whether any of the values aren’t equal, if so set the bool to false
        /// Use Assert.Equal to check whether the the expected and actual bools are equal
        /// </summary>
        [Theory]
        [InlineData("100;500;1200;", "100", "500", "1200", true)]
        [InlineData("100;500;1200;", "100", "600", "1200", false)] //Wrong value for exp2
        //Missing ';', note due to nature of how it works it doesn't need the last ';'
        [InlineData("100;500;1200", "100", "500", "1200", true)]
        public void DeserializeTest(string serialized, string exp1, string exp2, string exp3, bool expected)
        {
            List<string> actualList = DeserializeData.Deserialize(serialized);

            List<string> expectedList = new List<string>()
            {
                exp1,
                exp2,
                exp3
            };

            bool actual = true;

            for (int i = 0; i < actualList.Count; i++)
            {
                if (actualList[i] != expectedList[i])
                {
                    actual = false;
                }
            }

            Assert.Equal(expected, actual);
        }
    }
}

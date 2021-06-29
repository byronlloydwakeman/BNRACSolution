using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Library.DataFormatting
{
    public static class DeserializeData
    {
        /// <summary>
        /// Create a temp list of type string.
        /// Create a temp string variable .
        /// Loop through the string passed through as a parameter.
        /// If the given character in the string ISN'T a ';', then add it to the temp string.
        /// If it is, add the temp string to the list, and set its value to "".
        /// Return the temp list.
        /// </summary>
        public static List<string> Deserialize(string data)
        {
            List<string> tempList = new List<string>();
            string tempString = "";

            foreach (var character in data)
            {
                if (character == ';')
                {
                    tempList.Add(tempString);
                    tempString = "";
                }
                else
                {
                    tempString += character;
                }
            }

            return tempList;
        }

    }
}
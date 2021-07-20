using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Library.DataFormatting
{
    public class FormatData : IFormatData
    {
        /// <summary>
        /// A list of string will be passed as a parameter.
        /// Create an empty temp string.
        /// Loop through the list of strings, adding each one to the temp string with a ";" following it.
        /// Return the temp variable.
        /// </summary>
        public string FormatStringListToIncludeSemiColons(List<string> data)
        {
            string temp = "";

            foreach (var item in data)
            {
                temp += item;
                temp += ";";
            }

            return temp;
        }
    }
}

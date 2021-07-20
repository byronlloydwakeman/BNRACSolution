using DataManager.Library.DataFormatting;
using DataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Library.Conversion
{
    public class ConvertEnum : IConvertEnum
    {
        private IDeformatData _deformat;
        public ConvertEnum(IDeformatData deformatData)
        {
            _deformat = deformatData;
        }

        public EnumQuirk ConvertStringQuirkToEnumQuirk(string quirk)
        {
            return (EnumQuirk)Enum.Parse(typeof(EnumQuirk), quirk);
        }

        public List<EnumItem> ConvertStringToListOfEnumItem(string items)
        {
            //Convert string of items to list of enum items, we'll have to do this in two parts. Convert the string into a list of string and then convert the list of string into a list of enum
            List<string> enumItemsAsString = _deformat.DeformatStringIntoList(items);

            List<EnumItem> toReturn = new List<EnumItem>();

            foreach (var item in enumItemsAsString)
            {
                toReturn.Add((EnumItem)Enum.Parse(typeof(EnumItem), item));
            }

            return toReturn;
        }
    }
}

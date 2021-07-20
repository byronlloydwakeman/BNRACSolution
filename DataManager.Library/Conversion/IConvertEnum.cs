using DataManager.Library.Models;
using System.Collections.Generic;

namespace DataManager.Library.Conversion
{
    public interface IConvertEnum
    {
        EnumQuirk ConvertStringQuirkToEnumQuirk(string quirk);

        List<EnumItem> ConvertStringToListOfEnumItem(string items);
    }
}
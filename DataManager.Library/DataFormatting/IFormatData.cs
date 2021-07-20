using System.Collections.Generic;

namespace DataManager.Library.DataFormatting
{
    public interface IFormatData
    {
        string FormatStringListToIncludeSemiColons(List<string> data);
    }
}
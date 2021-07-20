using System.Collections.Generic;

namespace DataManager.Library.DataFormatting
{
    public interface IDeformatData
    {
        List<string> DeformatStringIntoList(string paramData);
    }
}
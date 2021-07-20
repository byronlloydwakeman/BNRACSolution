using DataManager.Library.Models;
using System.Collections.Generic;

namespace DataManager.Library.Data
{
    public interface IAutoClickFormattedData
    {
        List<AutoClickModel> GetModelsWithGivenRequirements(int str, int stam, int dur, string itemsAsString, EnumQuirk quirk);
        void InsertAutoClickModel(AutoClickModel model);
    }
}
using DataManager.Library.Models;
using System.Collections.Generic;

namespace DataManager.Library.DataAccess
{
    public interface IAutoClickData
    {
        List<AutoClickDBModel> GetDBModelsWithGivenRequirements(int str, int stam, int dur, string quirk);
        void InsertDBModel(AutoClickDBModel model);
    }
}
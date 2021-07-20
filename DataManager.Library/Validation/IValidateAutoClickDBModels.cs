using DataManager.Library.Models;
using System.Collections.Generic;

namespace DataManager.Library.Validation
{
    public interface IValidateAutoClickDBModels
    {
        List<AutoClickDBModel> ValidateDBModelsWithItems(List<AutoClickDBModel> autoClickDBModels, List<EnumItem> enumItems);
    }
}
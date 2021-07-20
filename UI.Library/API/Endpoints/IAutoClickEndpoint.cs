using DataManager.Library.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using UI.Library.Models;

namespace UI.Library.API.Endpoints
{
    public interface IAutoClickEndpoint
    {
        Task<List<AutoClickUIModel>> GetModelsWithGivenRequirements(int Strength, int Stamina, int Durability, string EnumItems, EnumQuirk Quirk);
    }
}
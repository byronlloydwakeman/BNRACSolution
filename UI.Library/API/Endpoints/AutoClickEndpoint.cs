using DataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using UI.Library.Models;

namespace UI.Library.API.Endpoints
{
    public class AutoClickEndpoint : IAutoClickEndpoint
    {
        private readonly IAPIHelper _apiHelper;

        public AutoClickEndpoint(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

        public async Task<List<AutoClickUIModel>> GetModelsWithGivenRequirements(int Strength, int Stamina, int Durability, string EnumItems, EnumQuirk Quirk)
        {
            using (HttpResponseMessage response = 
                await _apiHelper.apiClient.GetAsync($"/api/AutoClick/GetModelsWithGivenRequirements?Strength={Strength}&Stamina={Stamina}&Durability={Durability}&EnumItems={EnumItems}&Quirk={Quirk}"))
            {
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<List<AutoClickUIModel>>();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}

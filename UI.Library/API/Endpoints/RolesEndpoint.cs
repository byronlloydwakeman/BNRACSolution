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
    public class RolesEndpoint : IRolesEndpoint
    {
        private readonly IAPIHelper _apiHelper;

        public RolesEndpoint(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

        public async Task AddRole(UserRoleUIModel userRoleUIModel)
        {
            using (HttpResponseMessage response = await _apiHelper.apiClient.PostAsJsonAsync("api/Roles/AddRole", userRoleUIModel))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async Task RemoveRole(UserRoleUIModel userRoleUIModel)
        {
            using (HttpResponseMessage response = await _apiHelper.apiClient.PostAsJsonAsync("api/Roles/RemoveRole", userRoleUIModel))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}

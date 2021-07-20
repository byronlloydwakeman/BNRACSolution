using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace UI.Library.API.Endpoints
{
    public class UserEndpoint : IUserEndpoint
    {
        private readonly IAPIHelper _apiHelper;

        public UserEndpoint(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

        /// <summary>
        /// Gets the Id of the user thats currently logged in
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetUserId()
        {
            using (HttpResponseMessage response = await _apiHelper.apiClient.GetAsync("/api/User/GetUserId"))
            {
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<string>();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using UI.Library.Models;

namespace UI.Library.API
{
    public class APIHelper : IAPIHelper
    {
        public HttpClient apiClient { get; set; }

        public APIHelper()
        {
            InitializeClient();
        }

        private void InitializeClient()
        {
            apiClient = new HttpClient();
            apiClient.BaseAddress = new Uri("https://localhost:44310/");
            apiClient.DefaultRequestHeaders.Accept.Clear();
            apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        //Login
        public async Task Login(string username, string password)
        {
            var data = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "password"),
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("password", password)
            });

            using (HttpResponseMessage response = await apiClient.PostAsync("/Token", data))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<AccessTokenModel>();

                    //Set up authentication for future use
                    apiClient.DefaultRequestHeaders.Clear();
                    apiClient.DefaultRequestHeaders.Accept.Clear();
                    apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    apiClient.DefaultRequestHeaders.Add("Authorization", $"Bearer { result.Access_Token }");
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }


        }

        //Register
    }
}

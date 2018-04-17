using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace lolo.Models.DataServices.APICalls
{
    public class API
    {

        public string ReadAPI(string _url, string _apiKeys)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + _apiKeys);
            HttpResponseMessage response = client.GetAsync(_url).Result;

            return response.Content.ReadAsStringAsync().Result;
        }
    }
}
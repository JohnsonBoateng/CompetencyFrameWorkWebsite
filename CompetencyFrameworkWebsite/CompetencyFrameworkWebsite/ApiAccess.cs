using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;

namespace CompetencyFrameworkWebsite
{
    public class ApiAccess
    {
        private HttpClient _httpClient;

        public ApiAccess()
        {
            _httpClient = new HttpClient {BaseAddress = new Uri(ConfigurationManager.AppSettings["ApiBaseAddress"]) };
        }

        public List<string> GetAllTechnologies()
        {       
            return CallApi("api/technology");
        }

        private List<string> CallApi(string address)
        {
            var response = _httpClient.GetAsync(address).Result;
            var result = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<List<string>>(result);
        }
    }
}
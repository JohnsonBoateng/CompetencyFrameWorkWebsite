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

        public List<string> GetAllTechnologies() => CallApi<string>("api/technology");
        public List<string> GetAllJobTitle(string technologyName) => CallApi<string>("api/jobtitle/"+ technologyName);
        public List<Competency> GetAllResults(string technologyName, string jobTitleName) => CallApi<Competency>("api/competency?technologyName="+technologyName+"&jobTitle="+jobTitleName);
       

        private List<T> CallApi<T>(string address)
        {
            var response = _httpClient.GetAsync(address).Result;
            var result = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<List<T>>(result);
        }

    }


}
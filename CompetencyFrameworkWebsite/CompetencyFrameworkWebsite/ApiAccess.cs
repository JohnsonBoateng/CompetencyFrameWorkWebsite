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
        public List<Job> GetAllJobDetails(string technologyName) => CallApi<Job>("api/job/" + technologyName);
        public List<string> GetAllJobTitle(string technologyName) => CallApi<string>("api/jobtitle/"+ technologyName);
        public List<Competency> GetAllResults(string technologyName, string jobTitleName) => CallApi<Competency>("api/competency?technologyName="+technologyName+"&jobTitle="+jobTitleName);
        public List <string> GetAllTopics () => CallApi<string>("api/topics");
        public List<UserRatingData> GetAllUserRating() => CallApi<UserRatingData>("api/userrating");
        public List<UserData> GetAllUser() => CallApi<UserData>("api/user");
        public List<GetUserRating> GetAllUserInput(int UserID) => CallApi<GetUserRating>("api/getuserrating?UserID="+UserID);

        private List<T> CallApi<T>(string address)
        {
            var response = _httpClient.GetAsync(address).Result;
            var result = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<List<T>>(result);
        }

    }


}
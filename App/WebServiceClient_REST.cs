using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using REST;
using DTO;
using Newtonsoft.Json;
using REST.Controllers;


namespace App
{
    [RoutePrefix("api/users")]
    class WebServiceClient_REST
    {
        static string baseUri = "http://localhost:49871/api/users";


        public static User getUserAccount(string username)
        {
            string uri = baseUri;
            using (HttpClient httpClient = new HttpClient())
            {
                Task<String> response = httpClient.GetStringAsync(uri);
                return JsonConvert.DeserializeObject<User>(response.Result);
            }
        }


        public static bool addCHFByUserName(string userName, decimal chf)
        {
            string uri = baseUri;
            User tempUser = getUserAccount(userName);
            
            using (HttpClient httpClient = new HttpClient())
            {
                string user = JsonConvert.SerializeObject(tempUser);
                StringContent frame = new StringContent(user, Encoding.UTF8, "Application/json");
                Task<HttpResponseMessage> response = httpClient.PutAsync(uri, frame);
                return response.Result.IsSuccessStatusCode;
            }
        }

        public static bool addCHFByUID(int UID, decimal chf)
        {
            User tempUser = getUserAccount(username: CardsController.getUsernameByUserID(UID));

            string uri = baseUri;
            using (HttpClient httpClient = new HttpClient())
            {
                string user = JsonConvert.SerializeObject(tempUser);
                StringContent frame = new StringContent(user, Encoding.UTF8, "Application/json");
                Task<HttpResponseMessage> response = httpClient.PutAsync(uri, frame);
                return response.Result.IsSuccessStatusCode;
            }
        }
    }
}

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
using System.Web.Script.Serialization;

namespace App
{
    [RoutePrefix("api/user")]
    class WebServiceClient_REST
    {
        //static string baseUri = "http://localhost:58760/api/user";
        static string baseUri = "http://153.109.124.35:81/Rest-PintoBuffet/api/user";

        public static string getUserAccount(string username)
        {
            string uri = baseUri + "/username/" + username;
            using (HttpClient httpClient = new HttpClient())
            {
                Task<string> response = httpClient.GetStringAsync(uri);
                return JsonConvert.DeserializeObject<string>(response.Result);
            }
        }


        public static bool addCHFByUserName(string userName, decimal chf)
        {
            string uri = baseUri + "/addCHFByUserName";
            string uName = userName;
            decimal money = chf;

            User tempUser = new User
            {
                userId = 1,
                userName = uName,
                CHF = money,
                cardId = 1
            };
            
            using (HttpClient httpClient = new HttpClient())
            {
                string jsonUser = JsonConvert.SerializeObject(tempUser);
                StringContent frame = new StringContent(jsonUser, Encoding.UTF8, "Application/json");
                Task<HttpResponseMessage> response = httpClient.PutAsync(uri, frame);
                return response.Result.IsSuccessStatusCode;
            }
        }

        public static bool addCHFByUID(int UID, decimal chf)
        {
            string uri = baseUri + "/addCHFByUID";
            int userID = UID;
            decimal money = chf;

            User tempUser = new User
            {
                userId = UID,
                userName = "",
                CHF = money,
                cardId = UID
            };

            using (HttpClient httpClient = new HttpClient())
            {
                string jsonUser = JsonConvert.SerializeObject(tempUser);
                StringContent frame = new StringContent(jsonUser, Encoding.UTF8, "Application/json");
                Task<HttpResponseMessage> response = httpClient.PutAsync(uri, frame);
                return response.Result.IsSuccessStatusCode;
            }

        }

        public static string getUsernameByUserID(int UID)
        {
            string uri = baseUri + "/userId/" + UID;
            using (HttpClient httpClient = new HttpClient())
            {
                Task<string> response = httpClient.GetStringAsync(uri);
                return JsonConvert.DeserializeObject<string>(response.Result);
            }
        }

    }
}

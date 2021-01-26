using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace WeatherApp.DAL
{
    public static class DataAccess
    {
        public static string setConnection(string uri, string apiname)
        {
            var resultString = "";
            HttpClient clientHttp = new HttpClient();
            clientHttp.BaseAddress = new Uri(uri);
            var request = clientHttp.GetAsync(apiname).Result;
            if (request.IsSuccessStatusCode)
            {
                 resultString = request.Content.ReadAsStringAsync().Result;

            }
            return resultString;

        }
        
        
    }
}
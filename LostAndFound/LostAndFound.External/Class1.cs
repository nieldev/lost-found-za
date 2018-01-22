using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LostAndFound.External
{
    public class InternetLostAndFoundApi
    {
        private HttpClient _client;
        const string apiKey = "8i8HN+i7Lcvhnug1AJOXJDnPLOkHoJJXlIGS7zf73hsWHV+T5WgNdlCF5DGO40LRhFaU8VTYhbmTxTgG2pM+HA==";
        private const string u = "niel.devries@gmail.com";
        private const string p = "99Bottl3s";
        public  InternetLostAndFoundApi()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri($"https://lostandfound.com");
        }

        public dynamic GetResult(string path)
        {

          
          
         
            var req = new HttpRequestMessage(HttpMethod.Post, $"/api/{path}");

            var dict = new Dictionary<string, string>();
            dict.Add("key", apiKey);
            dict.Add("u", u);
            dict.Add("p", p);
            req.Content = new FormUrlEncodedContent(dict);


            var a = _client.SendAsync(req);
            string responseBody = a.Result.Content.ReadAsStringAsync().Result;
            dynamic input = JsonConvert.DeserializeObject(responseBody);
            return input;

        }
    }
}

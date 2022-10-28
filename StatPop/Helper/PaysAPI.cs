using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ApiPopStat.Models;
using Newtonsoft.Json;

namespace StatPop.Helper
{
    public class PaysAPI
    {
        private static readonly HttpClient client = new HttpClient();

        private PaysAPI()
        {
            client.BaseAddress = new Uri("http://localhost:54444/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        private static readonly object padlock = new object();
        private static PaysAPI instance = null;

        public static PaysAPI Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new PaysAPI();
                    }
                    return instance;
                }
            }
        }
       
        public async Task<List<Pays>> GetAllPays()
        {
            List<Pays> List = new List<Pays>();
            HttpResponseMessage response = client.GetAsync("api/PaysTest/GetAllPays1").Result;
            if (response.IsSuccessStatusCode)
            {
                var resp = await response.Content.ReadAsStringAsync();
                List = JsonConvert.DeserializeObject<List<Pays>>(resp);
            }
            return List;
        }
        public async Task<List<String>> GetIncome()
        {
            List<String> List = new List<String>();
            HttpResponseMessage response = client.GetAsync("api/PaysTest/GetIncome").Result;
            if (response.IsSuccessStatusCode)
            {
                var resp = await response.Content.ReadAsStringAsync();
                List = JsonConvert.DeserializeObject<List<String>>(resp);
            }
            return List;
        }
        public async Task<List<String>> GetRegion()
        {
            List<String> List = new List<String>();
            HttpResponseMessage response = client.GetAsync("api/PaysTest/GetRegion").Result;
            if (response.IsSuccessStatusCode)
            {
                var resp = await response.Content.ReadAsStringAsync();
                List = JsonConvert.DeserializeObject<List<String>>(resp);
            }
            return List;
        }
        public async Task<List<int>> GetCountIncome()
        {
            List<int> List = new List<int>();
            HttpResponseMessage response = client.GetAsync("api/PaysTest/GetCountIncome").Result;
            if (response.IsSuccessStatusCode)
            {
                var resp = await response.Content.ReadAsStringAsync();
                List = JsonConvert.DeserializeObject<List<int>>(resp);
            }
            return List;
        }
        public async Task<List<int>> GetCountRegion()
        {
            List<int> List = new List<int>();
            HttpResponseMessage response = client.GetAsync("api/PaysTest/GetCountRegion").Result;
            if (response.IsSuccessStatusCode)
            {
                var resp = await response.Content.ReadAsStringAsync();
                List = JsonConvert.DeserializeObject<List<int>>(resp);
            }
            return List;
        }
    }
}

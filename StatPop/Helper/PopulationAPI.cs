using ApiPopStat.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace StatPop.Helper
{
    public class PopulationAPI
    {
       private static readonly HttpClient client = new HttpClient();

        private PopulationAPI()
        {
            client.BaseAddress = new Uri("http://localhost:54444/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        private static readonly object padlock = new object();
        private static PopulationAPI instance = null;

        public static PopulationAPI Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new PopulationAPI();
                    }
                    return instance;
                }
            }
        }
       
        public async Task<Population> GetPopulationAllYears(int? id)
        {
            Population List = new Population();
            HttpResponseMessage response = client.GetAsync("api/PopulationTest/GetAllYears/"+id).Result;
            if (response.IsSuccessStatusCode)
            {
                var resp = await response.Content.ReadAsStringAsync();
                List = JsonConvert.DeserializeObject<Population>(resp);
            }
            return List;
        }
        public async Task<IEnumerable<Population>> GetPopulationAllName()
        {
            List<Population> List = new List<Population>();
            HttpResponseMessage response = client.GetAsync("api/PopulationTest").Result;
            if (response.IsSuccessStatusCode)
            {
                var resp = await response.Content.ReadAsStringAsync();
                List = JsonConvert.DeserializeObject<List<Population>>(resp);
            }
            return List;
        }
        public async Task<IEnumerable<Population>> GetPopulationOneName(int? id)
        {
            List<Population> List = new List<Population>();
            HttpResponseMessage response = client.GetAsync("api/PopulationTest/GetOneName/"+id).Result;
            if (response.IsSuccessStatusCode)
            {
                var resp = await response.Content.ReadAsStringAsync();
                List = JsonConvert.DeserializeObject<List<Population>>(resp);
            }
            return List;
        }
        public async Task<Population> GetPopulationOn5Async(int? id)
        {
            Population List = new Population();
            HttpResponseMessage response = client.GetAsync("api/PopulationTest/GetPopulation5ans/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                var resp = await response.Content.ReadAsStringAsync();
                List = JsonConvert.DeserializeObject<Population>(resp);
            }
            return List;
        }

        public async Task<Population> GetPopulationOn10Async(int? id)
        {
            Population List = new Population();
            HttpResponseMessage response = client.GetAsync("api/PopulationTest/GetPopulation10ans/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                var resp = await response.Content.ReadAsStringAsync();
                List = JsonConvert.DeserializeObject<Population>(resp);
            }
            return List;
        }
        public async Task<Population> GetPopulationOn20Async(int? id)
        {
            Population List = new Population();
            HttpResponseMessage response = client.GetAsync("api/PopulationTest/GetPopulation20ans/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                var resp = await response.Content.ReadAsStringAsync();
                List = JsonConvert.DeserializeObject<Population>(resp);
            }
            return List;
        }
        public async Task<Population> GetPopulationOn30Async(int? id)
        {
            Population List = new Population();
            HttpResponseMessage response = client.GetAsync("api/PopulationTest/GetPopulation30ans/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                var resp = await response.Content.ReadAsStringAsync();
                List = JsonConvert.DeserializeObject<Population>(resp);
            }
            return List;
        }
        public async Task<Population> GetPopulationOn40Async(int? id)
        {
            Population List = new Population();
            HttpResponseMessage response = client.GetAsync("api/PopulationTest/GetPopulation40ans/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                var resp = await response.Content.ReadAsStringAsync();
                List = JsonConvert.DeserializeObject<Population>(resp);
            }
            return List;
        }
        public async Task<Population> GetPopulationOn50Async(int? id)
        {
            Population List = new Population();
            HttpResponseMessage response = client.GetAsync("api/PopulationTest/GetPopulation50ans/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                var resp = await response.Content.ReadAsStringAsync();
                List = JsonConvert.DeserializeObject<Population>(resp);
            }
            return List;
        }
    }
}

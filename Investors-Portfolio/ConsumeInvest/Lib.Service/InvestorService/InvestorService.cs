using Lib.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Service.InvestorService
{
    public class InvestorService : IInvestorService
    {
        public async Task<List<Investor>> GetInvestor()
        {
            var investorlist = new List<Investor>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44305/");
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("api/MInvestors");
                if (response.IsSuccessStatusCode)
                {
                    var readTask = response.Content.ReadAsStringAsync().Result;
                    investorlist = JsonConvert.DeserializeObject<List<Investor>>(readTask);
                    return investorlist;
                }
                return investorlist;
            }
        }
        public async Task<bool> SaveInvestor(Investor model)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44305/");
                client.DefaultRequestHeaders.Clear();
                string jsonData = JsonConvert.SerializeObject(model);
                var content = new StringContent(jsonData, UnicodeEncoding.UTF8, "application/json");
                var response = await client.PostAsync("api/MInvestors", content);
                if (response.IsSuccessStatusCode)
                {
                    var readTask = response.Content.ReadAsStringAsync().Result;
                    var result = JsonConvert.DeserializeObject<bool>(readTask);
                    return result;
                }
            }
            return false;
        }
    }
}

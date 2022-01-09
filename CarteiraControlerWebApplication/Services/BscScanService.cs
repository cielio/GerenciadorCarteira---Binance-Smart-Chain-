using CarteiraControlerWebApplication.DTOs;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CarteiraControlerWebApplication.Services
{
    public class BscScanService : IBscScanService
    {
        private readonly HttpClient _httpClient;
        public BscScanService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<TransacoesDTO> GetApi(string wallateAddress, string contractaddress)
        {
            string uri = @"https://api.bscscan.com/api?module=account&action=tokentx&contractaddress="+contractaddress+"&address="+ wallateAddress+"&page=1&offset=*&startblock=0&endblock=999999999&sort=asc&apikey=FD9VG3D5AVW769VB2TFEN6CH7IXASCG8AK";
            var response = await _httpClient.GetAsync(uri);
            response.EnsureSuccessStatusCode();
            var jsonResult = await response.Content.ReadAsStringAsync();

            var transacoesDTO = Newtonsoft.Json.JsonConvert.DeserializeObject<TransacoesDTO>(jsonResult);
            foreach (var item in transacoesDTO.result)
            {
                item.Type = item.To.Contains(wallateAddress.ToLower()) ? "Buy" : "Sell";
            }
            return transacoesDTO; 
        }
    }
}

using System.Net.Http.Json;

namespace EComm_2011501158.Client.Services.PesananProdukService
{
    public class PesananProdukService : IPesananProdukService
    {
        private HttpClient _http;
        private ILocalStorageService _localstorage;

        public List<ItemKereta> ItemKeretas { get ; set; }
        public PesananProdukService(HttpClient http, ILocalStorageService localStorage)
        {
            _http = http;
            _localstorage = localStorage;
        }
        public async Task CreatePesananProduk(ItemKereta item)
        {
            var kereta = await _localstorage.GetItemAsync<List<ItemKereta>>("kereta");
            foreach (var data in kereta)
            {
                var result = await _http.PostAsJsonAsync("api/pesananproduk", data);
                var response = await result.Content.ReadFromJsonAsync<List<ItemKereta>>();
                ItemKeretas = response;
            }
        }

        public async Task<List<ItemKereta>> GetAllPesananProduk()
        {
            var result = await _http.GetFromJsonAsync<List<ItemKereta>>("api/pesananproduk");
            if (result != null)
            {
                ItemKeretas = result;
                return result;
            }
            else
            {
                return new List<ItemKereta>();
            }
        }
    }
}

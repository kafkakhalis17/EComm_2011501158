using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace EComm_2011501158.Client.Services.ProdukService
{
    public class ProdukService : IProdukService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationmanager;

        public ProdukService(HttpClient http, NavigationManager navigationmanager) {
            _http = http;
            _navigationmanager = navigationmanager;
        }
        public List<Produk> Produks { get; set; } = new List<Produk>();

        public async Task GetAllProduk()
        {
            var result = await _http.GetFromJsonAsync<List<Produk>>("api/produk");
            if (result != null)
            {
                Produks = result;
            }
            throw new NotImplementedException();
        }

        public async Task<Produk> GetProduksById(int id)
        {
            var result = await _http.GetFromJsonAsync<Produk>($"api/produk/{id}");
            if (result != null) { return result; }
            throw new Exception("Data tidak ditemukan");
        }
    }
}

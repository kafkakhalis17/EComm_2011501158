using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using System.Xml;

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

        public async Task CreateProduk(Produk produk)
        {
            var result = await _http.PostAsJsonAsync("api/produk", produk);
            var response = await result.Content.ReadFromJsonAsync<List<Produk>>();
            Produks = response;
            _navigationmanager.NavigateTo("/master_produk");
        }

        public async Task DeleteProduk(int id)
        {
            var result = await _http.DeleteAsync($"api/produk/{id}");
            var response = await result.Content.ReadFromJsonAsync<List<Produk>>();
            Produks = response;
            _navigationmanager.NavigateTo("/master_produk");
        }

        public async Task GetAllProduk()
        {
            var result = await _http.GetFromJsonAsync<List<Produk>>("api/produk");
            if (result != null)
            {
                Produks = result;
            }
           
        }

        public async Task<Produk> GetProduksById(int id)
        {
            var result = await _http.GetFromJsonAsync<Produk>($"api/produk/{id}");
            if (result != null) { return result; }
            throw new Exception("Data tidak ditemukan");
        }

        public async Task UpdateProduk(Produk produk)
        {
            var result = await _http.PutAsJsonAsync($"api/produk/{produk.IdProduk}", produk);
            var response = await result.Content.ReadFromJsonAsync<List<Produk>>();
            Produks = response;
            _navigationmanager.NavigateTo("/master_produk");
        }
       

        public async Task<List<Produk>> SearchProduk(string kataCari)
        {
            var result = await _http.GetFromJsonAsync<List<Produk>>($"api/produk/cari/{kataCari}"); 
            if (result != null)
            {
                return result;
            }
            throw new Exception("Data produk tidak ditemukan");
        }
    }
}

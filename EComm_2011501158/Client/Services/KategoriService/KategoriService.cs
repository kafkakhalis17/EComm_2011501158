using EComm_2011501158.Shared;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace EComm_2011501158.Client.Services.KategoriService
{
    public class KategoriService : IKategoriService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationmanager;

        public KategoriService(HttpClient http, NavigationManager navigationmanager)
        {
            _http = http;
            _navigationmanager = navigationmanager;
        }
        public List<Kategori> Kategoris { get; set; } = new List<Kategori>();

        public async Task CreateKategori(Kategori kategori)
        {
            var result = await _http.PostAsJsonAsync("api/kategori", kategori);
            var response = await result.Content.ReadFromJsonAsync<List<Kategori>>();
            Kategoris = response;
            _navigationmanager.NavigateTo("/master_kategori");
        }
        
        public async Task DeleteKategori(int id)
        {
            var result = await _http.DeleteAsync($"api/kategori/{id}");
            var response = await result.Content.ReadFromJsonAsync<List<Kategori>>();
            Kategoris = response;
            _navigationmanager.NavigateTo("/master_kategori");
        }

        public async Task GetAllKategori()
        {
            var result = await _http.GetFromJsonAsync<List<Kategori>>("api/kategori");
            if (result != null)
            {
                Kategoris = result;
            }
            throw new NotImplementedException();
        }

        public async Task<Kategori> GetKategoriById(int id)
        {
            var result = await _http.GetFromJsonAsync<Kategori>($"api/kategori/{id}");
            if (result != null) { return result; }
            throw new Exception("Data tidak ditemukan");
        }

        public async Task UpdateKategori(Kategori kategori)
        {
            var result = await _http.PutAsJsonAsync($"api/kategori/{kategori.IdKategori}", kategori);
            var response = await result.Content.ReadFromJsonAsync<List<Kategori>>();
            Kategoris = response;
            _navigationmanager.NavigateTo("/master_kategori");
        }
    }
}

using static System.Net.WebRequestMethods;
using System.Net.Http.Json;
using EComm_2011501158.Shared;
using Microsoft.AspNetCore.Components;

namespace EComm_2011501158.Client.Services.VarianService
{
    public class VarianService : IVarianService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationmanager;

        public VarianService(HttpClient http, NavigationManager navigationmanager)
        {
           _http = http;
           _navigationmanager = navigationmanager;
        }
        public List<Varian> Varians { get; set; } = new List<Varian>();

        public async Task CreateVarian(Varian varian)
        {
            var result = await _http.PostAsJsonAsync("api/varian", varian);
            var response = await result.Content.ReadFromJsonAsync<List<Varian>>();
            Varians = response;
            _navigationmanager.NavigateTo("/master_varian");
        }

        public async Task DeleteVarian(int id)
        {
            var result = await _http.DeleteAsync($"api/varian/{id}");
            var response = await result.Content.ReadFromJsonAsync<List<Varian>>();
            Varians = response;
            _navigationmanager.NavigateTo("/master_varian");
        }

        public async Task GetAllVarian()
        {
            var result = await _http.GetFromJsonAsync<List<Varian>>("api/varian");
            if (result != null)
            {
                Varians  = result;
            }
            throw new NotImplementedException();
    
        }

        public async Task<Varian> GetVarianById(int id)
        {
            var result = await _http.GetFromJsonAsync<Varian>($"api/varian/{id}");
            if (result != null) { return result; }
            throw new Exception("Data tidak ditemukan");
        }

        public async Task UpdateVarian(Varian varian)
        {
            var result = await _http.PutAsJsonAsync($"api/produk/{varian.IdVarian}", varian);
            var response = await result.Content.ReadFromJsonAsync<List<Varian>>();
            Varians = response;
            _navigationmanager.NavigateTo("/master_varian");
        }
    }
}

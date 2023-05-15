using EComm_2011501158.Shared;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using System.Xml;
using static System.Net.WebRequestMethods;

namespace EComm_2011501158.Client.Services.PenggunaService
{
    public class PenggunaService : IPenggunaService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationmanager;
        
        public PenggunaService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationmanager = navigationManager; 
        }
        public List<Pengguna> Penggunas { get; set; } = new List<Pengguna>();

        public async Task GetAllPengguna()
        {
            var result = await _http.GetFromJsonAsync<List<Pengguna>>("api/pengguna");
            if (result != null)
            {
                Penggunas = result;
            }
            throw new NotImplementedException();
        }

        public Task<Produk> GetPenggunaById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

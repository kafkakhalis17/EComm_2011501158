using EComm_2011501158.Shared;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace EComm_2011501158.Client.Services.KonfirmasiPesananService
{
    public class KonfirmasiPesananService : IKonfirmasiPesananService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationmanager;

        public KonfirmasiPesananService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationmanager = navigationManager;
        }
        public List<KonfirmasiPesanan> konfirmasiPesanans { get; set; } = new List<KonfirmasiPesanan>();

        public async Task CreateKonfirmasiPesanan(KonfirmasiPesanan konfirmasiPesanan)
        {
            var result = await _http.PostAsJsonAsync("api/konfirmasi_pesanan", konfirmasiPesanan );
            var response = await result.Content.ReadFromJsonAsync<List<KonfirmasiPesanan>>();
            konfirmasiPesanans = response;
            _navigationmanager.NavigateTo("/konfirmasipesanan");
        }

        public async Task DeleteKonfirmasiPesanan(int id)
        {
            var result = await _http.DeleteAsync($"api/konfirmasipesanan/{id}");
            var response = await result.Content.ReadFromJsonAsync<List<KonfirmasiPesanan>>();
            konfirmasiPesanans = response;
            _navigationmanager.NavigateTo("/konfirmasipesanan");
        }

        public async Task GetAllKonfirmasi()
        {

            var result = await _http.GetFromJsonAsync<List<KonfirmasiPesanan>>("api/konfrimasi_pesanan");
            if (result != null)
            {
                konfirmasiPesanans = result;
            }
            throw new NotImplementedException();
        }
    }
}

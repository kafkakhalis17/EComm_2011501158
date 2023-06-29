using System.ComponentModel.DataAnnotations;
using System.Net.Http.Json;

namespace EComm_2011501158.Client.Services.PesananService
{
    public class PesananService : IPesananService
    {
        private HttpClient _http;

        public List<Pesanan> Pesanans { get; set; }
        public PesananService(HttpClient http)
        {
            _http = http;
        }

        public async Task CreatePesanan(Pesanan pesanan)
        {
            var result = await _http.PostAsJsonAsync("api/pesanan", pesanan);
            var response = await result.Content.ReadFromJsonAsync<List<Pesanan>>();
            Pesanans = response;
        }

        public async Task<List<Pesanan>> GetAllPesanan()
        {
            var result = await _http.GetFromJsonAsync<List<Pesanan>>("api/pesanan");
            if (result != null)
            {
                Pesanans = result;
                return result;
            }
            else
            {
                return new List<Pesanan>();
            }
        }
   

        public async Task<int> GetIdTerakhir()
        {
            var result = await _http.GetAsync("api/pesanan/IdTerakhir");
            var response = await result.Content.ReadFromJsonAsync<int>();
            if (result != null)
                return response;
            throw new Exception("Gagal Mendapatkan id Terakhir");
        }
    }
}

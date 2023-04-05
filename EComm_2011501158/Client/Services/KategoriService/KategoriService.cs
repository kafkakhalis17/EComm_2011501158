using EComm_2011501158.Shared;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace EComm_2011501158.Client.Services.KategoriService
{
    public class KategoriService : IKategoriService
    {
        private readonly HttpClient _http;

        public KategoriService(HttpClient http)
        {
            _http = http;
        }
        public List<Kategori> Kategoris { get; set; } = new List<Kategori>();

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
    }
}

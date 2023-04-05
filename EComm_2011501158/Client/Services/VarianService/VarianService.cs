using static System.Net.WebRequestMethods;
using System.Net.Http.Json;
using EComm_2011501158.Shared;

namespace EComm_2011501158.Client.Services.VarianService
{
    public class VarianService : IVarianService
    {
        private readonly HttpClient _http;

        public VarianService(HttpClient http)
        {
           _http = http;
        }
        public List<Varian> Varians { get; set; } = new List<Varian>();

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
    }
}

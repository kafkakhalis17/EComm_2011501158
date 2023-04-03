using System.Net.Http.Json;

namespace EComm_2011501158.Client.Services.ProdukService
{
    public class ProdukService : IProdukService
    {
        private readonly HttpClient http;

        public ProdukService(HttpClient http) {
            this.http = http;
        }
        public List<Produk> Produks { get; set; } = new List<Produk>();

        public async Task GetAllProduk()
        {
            var result = await this.http.GetFromJsonAsync<List<Produk>>("api/produk");
            if (result != null)
            {
                Produks = result;
            }
            throw new NotImplementedException();
        }

        public async Task<Produk> GetProduksById(int id)
        {
            var result = await this.http.GetFromJsonAsync<Produk>($"api/produk/{id}");
            if (result != null) { return result}
            throw new Exception("Data tidak ditemukan");
        }
    }
}

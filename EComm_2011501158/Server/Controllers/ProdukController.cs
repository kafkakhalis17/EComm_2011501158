using EComm_2011501158.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EComm_2011501158.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdukController : ControllerBase
    {
        public static List<Produk> produks = new List<Produk>();
        private readonly DataContext _context;
        public ProdukController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<List<Produk>>> GetAllProduk()
        {
            return Ok(produks);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Produk>> GetProduksById(int id)
        {
            var prod = await _context.Produk.FirstOrDefaultAsync(p => p.IdProduk == id);
            if (prod == null)
            {
                return NotFound("Data produk tak ditemukan");
            }
            return Ok(prod);
        }
        private async Task<List<Produk>> GetDbProduk()
        {
            return await _context.Produk.ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<List<Produk>>> CreateProduk(Produk produk)
        {
            _context.Produk.Add(produk);
            await _context.SaveChangesAsync();
            return Ok(await GetDbProduk());
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<List<Produk>>> UpdateProduk(Produk produk, int id)
        {
            var dbProduk = await _context.Produk.FirstOrDefaultAsync(sh => sh.IdProduk == id);
            if (dbProduk == null)
                return NotFound("Data tidak ditemukan");
            dbProduk.IdProduk = id;
            dbProduk.Nama = produk.Nama;
            dbProduk.Deskripsi = produk.Deskripsi;
            dbProduk.Harga = produk.Harga;
            dbProduk.HargaOrginal = produk.HargaOrginal;
            dbProduk.DateCreated = produk.DateCreated;
        }
    }
}

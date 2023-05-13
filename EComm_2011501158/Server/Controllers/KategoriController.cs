using EComm_2011501158.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EComm_2011501158.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KategoriController : ControllerBase
    {
        public static List<Kategori> Kategoris = new List<Kategori> ();
        private readonly DataContext _context;

        public KategoriController(DataContext context)
        {
            _context = context;
          
        }
        // Get all data kategori 
        [HttpGet]
        public async Task<ActionResult<List<Kategori>>> GetAllKategori()
        {
            var kategoris = await _context.Kategori.ToListAsync();
            return Ok(kategoris);
        }
        // get data by id 
        [HttpGet("{id}")]
        public async Task<ActionResult<Kategori>> GetKategoriById(int id)
        {
            var kat = await _context.Kategori.FirstOrDefaultAsync(k => k.IdKategori == id);
            if (kat == null)
            {
                return NotFound("Data kategori tidack ditemukan");
            }
            return Ok(kat);
        }
        private async Task<List<Kategori>> GetDbKategori()
        {
            return await _context.Kategori.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<List<Kategori>>> CreateKategori(Kategori kategori)
        {
            _context.Kategori.Add(kategori);
            await _context.SaveChangesAsync();
            return Ok(await GetDbKategori());
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Kategori>>> UpdateKategori(Kategori kategori, int id)
        {
            var dbkat = await _context.Kategori.FirstOrDefaultAsync(sh => sh.IdKategori == id);
            if (dbkat == null)
                return NotFound("Data tidak ditemukan");
            dbkat.IdKategori = id;
            dbkat.Nama = kategori.Nama;
            await _context.SaveChangesAsync();
            return Ok(await GetDbKategori());
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Kategori>>> DeleteKategori(int id)
        {
            var dbkat = await _context.Kategori
                .FirstOrDefaultAsync(sh => sh.IdKategori == id);
            if (dbkat == null) return NotFound("data tidak ditemukan");
            _context.Kategori.Remove(dbkat);
            await _context.SaveChangesAsync();
            return Ok(await GetDbKategori());
        }
    }
}

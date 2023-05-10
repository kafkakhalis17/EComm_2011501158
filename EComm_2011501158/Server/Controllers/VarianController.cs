using EComm_2011501158.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EComm_2011501158.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VarianController : ControllerBase
    {
        public static List<Varian> varians = new List<Varian>();
        private readonly DataContext _context;
        public VarianController(DataContext context) 
        { 
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<List<Varian>>> GetAllVarian()
        {
            var varians = await _context.Varian.ToListAsync();
            return Ok(varians);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Varian>> GetVariansById(int id)
        {
            var vari = await _context.Varian.FirstOrDefaultAsync(p => p.IdVarian == id);
            if (vari == null)
            {
                return NotFound("Data Varian tak ditemukan");
            }
            return Ok(vari);
        }

        private async Task<List<Varian>> GetDbVarian()
        {
            return await _context.Varian.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<List<Varian>>> CreateVarian(Varian varian)
        {
            _context.Varian.Add(varian);
            await _context.SaveChangesAsync();
            return Ok(await GetDbVarian());
        }

        [HttpPut("id")]
        public async Task<ActionResult<List<Varian>>> UpdateKategori(Varian varian, int id)
        {
            var dbVar = await _context.Varian.FirstOrDefaultAsync(sh => sh.IdVarian == id);
            if (dbVar == null)
                return NotFound("Data tidak ditemukan");
            dbVar.IdVarian = id;
            dbVar.Nama = varian.Nama;
            await _context.SaveChangesAsync();
            return Ok(await GetDbVarian());
        }
        public async Task<ActionResult<List<Varian>>> DeleteVarian (int id)
        {
            var dbVar = await _context.Varian
                .FirstOrDefaultAsync(sh => sh.IdVarian == id);
            if (dbVar == null) return NotFound("data tidak ditemukan");
            _context.Varian.Remove(dbVar);
            await _context.SaveChangesAsync();
            return Ok(await GetDbVarian());
        }
    }
}

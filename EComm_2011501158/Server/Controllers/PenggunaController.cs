using EComm_2011501158.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EComm_2011501158.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PenggunaController : ControllerBase
    {
        public static List<Pengguna> penggunas = new List<Pengguna>();
        private readonly DataContext _context;
        public PenggunaController(DataContext context) {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Pengguna>>> GetAllPengguna()
        {
            var penggunas = await _context.Pengguna.ToListAsync();
            return Ok(penggunas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Pengguna>> GetPenggunaById(int id)
        {
            var user = await _context.Pengguna.FirstOrDefaultAsync(p => p.IdPengguna == id);
            if (user == null)
            {
                return NotFound("Data Pengguna tak ditemukan");
            }
            return Ok(user);
        }
    }
}

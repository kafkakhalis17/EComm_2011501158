using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EComm_2011501158.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KonfirmasiPesananController : ControllerBase
    {
        private readonly DataContext _context;
        public static List<KonfirmasiPesanan> konfirmasiPesanans = new List<KonfirmasiPesanan>();
        public KonfirmasiPesananController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<KonfirmasiPesanan>>> GetAllKonfirmasi()
        {
            var konfirmasiPesanans = await _context.KonfirmasiPesanan.ToListAsync();
            return Ok(konfirmasiPesanans);
        }

        [HttpPost]
        public async Task<ActionResult<List<KonfirmasiPesanan>>> CreateKonfirmasiPesanan(KonfirmasiPesanan konfirmasiPesanan)
        {
            _context.KonfirmasiPesanan.Add(konfirmasiPesanan);
            await _context.SaveChangesAsync();
            return Ok(await _context.KonfirmasiPesanan.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<KonfirmasiPesanan>>> DeleteKonfirmasiPesanan(int id)
        {
            var konfirmasiPesanan = await _context.KonfirmasiPesanan.FindAsync(id);
            if (konfirmasiPesanan == null)
                return NotFound("Data tidak ditemukan");

            _context.KonfirmasiPesanan.Remove(konfirmasiPesanan);
            await _context.SaveChangesAsync();
            return Ok(await _context.KonfirmasiPesanan.ToListAsync());
        }
    }
}

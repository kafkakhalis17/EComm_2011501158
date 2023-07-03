using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EComm_2011501158.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KonfirmasiPesananController : ControllerBase
    {
        private readonly DataContext _context;
        public static List<KonfirmasiPesanan> KonfirmasiPesanans = new List<KonfirmasiPesanan>();
        public KonfirmasiPesananController(DataContext context)
        {
            _context = context;
        }

        private async Task<List<KonfirmasiPesanan>> GetDbKonfrimasiPesanan()
        {
            return await _context.KonfirmasiPesanan.ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<List<KonfirmasiPesanan>>> CreateKonfirmasiPesanan(KonfirmasiPesanan konfirmasiPesanan)
        {
            _context.KonfirmasiPesanan.Add(konfirmasiPesanan);
            await _context.SaveChangesAsync();
            return Ok(await GetDbKonfrimasiPesanan());
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<KonfirmasiPesanan>>> DeleteKonfirmasiPesanan(int id)
        {
            var dbKonfrimasiPesanan = await _context.KonfirmasiPesanan
                .FirstOrDefaultAsync(sh => sh.IdKonfirmasi == id);
            if (dbKonfrimasiPesanan == null) return NotFound("data tidak ditemukan");
            _context.KonfirmasiPesanan.Remove(dbKonfrimasiPesanan);
            await _context.SaveChangesAsync();
            return Ok(await GetDbKonfrimasiPesanan());
        }

    }
}

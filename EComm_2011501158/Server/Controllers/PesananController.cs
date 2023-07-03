using Microsoft.AspNetCore.Mvc;

using EComm_2011501158.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;

namespace EComm_2011501158.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PesananController : ControllerBase
    {
        public static List<Pesanan> pesanan = new List<Pesanan>();
        private readonly DataContext _context;
        public PesananController( DataContext context) {
            _context = context;     
        }

        private async Task<List<Pesanan>> GetDbPesanan()
        {
            return await _context.Pesanan.ToListAsync();    
        }
        [HttpPost]
        public async Task<ActionResult<List<Pesanan>>>CreatePesanan(Pesanan pesanan)
        {
            _context.Pesanan.Add(pesanan);
            await _context.SaveChangesAsync();
            return Ok(await GetDbPesanan());
        }
        [HttpGet("IdTerakhir")]
        public async Task<ActionResult<int>> GetIdTerhakhir()
        {
            var pesan = await _context.Pesanan.OrderByDescending(o => o.IdPesanan)
                .FirstOrDefaultAsync();
            if (pesan  != null)
            {
                return Ok(pesan.IdPesanan);
            }
            else { return 1; }
        }
        [HttpGet]
        public async Task<ActionResult<List<Pesanan>>> GetAllPesanan()
        {
            var pesan = await _context.Pesanan
                .Include(p => p.PesaananProduk)
                .ThenInclude(x => x.Produk)
                .ToListAsync();
            return Ok(pesan);
        }
    }
}
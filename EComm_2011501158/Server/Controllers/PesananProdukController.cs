using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EComm_2011501158.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PesananProdukController : ControllerBase
    {
        public static List<ItemKereta> pesananproduk = new List<ItemKereta>();
        private readonly DataContext _context;
        public PesananProdukController(DataContext context) {
            _context = context;
        }
        private async Task<List<ItemKereta>> GetDbPesananProduk()
        {
            return await _context.PesananProduk.ToListAsync();  
        }
        [HttpPost]
        public async Task<ActionResult<List<ItemKereta>>> CreatePesananProduk(ItemKereta pesananproduk)
        {
            _context.PesananProduk.Add(pesananproduk);
            await _context.SaveChangesAsync();
            return Ok(await GetDbPesananProduk());
        }
        [HttpGet]
        public async Task<ActionResult<List<ItemKereta>>> GetAllPesananProduk()
        {
            var prodpsn = await  _context.PesananProduk
                .ToListAsync();
            return Ok(prodpsn);
        }
    }
}

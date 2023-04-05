using EComm_2011501158.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EComm_2011501158.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KategoriController : ControllerBase
    {
        public static List<Kategori> Kategoris = new List<Kategori> { 
        new Kategori
        {
            IdKategori = 1,
            Nama = "Horror"

        },
        new Kategori
        {
            IdKategori = 2,
            Nama = "Fantasy"

        },
        new Kategori
        {
            IdKategori = 3,
            Nama = "Drama"

        }


        };

        [HttpGet]
        public async Task<ActionResult<List<Kategori>>> GetAllKategori()
        {
            return Ok(Kategoris);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Kategori>> GetKategoriById(int id)
        {
            var kat = Kategoris.FirstOrDefault(k => k.IdKategori == id);
            if (kat == null)
            {
                return NotFound("Data kategori tidack ditemukan");
            }
            return Ok(kat);
        }
    }
}

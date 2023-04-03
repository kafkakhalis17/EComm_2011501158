using EComm_2011501158.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EComm_2011501158.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VarianController : ControllerBase
    {
        public static List<Varian> varians = new List<Varian>
        {
            new Varian
            {
                IdVarian= 1,
                Nama ="Horror"
            },
            new Varian
            {
                IdVarian= 2,
                Nama ="Fantasy"
            },
            new Varian
            {
                IdVarian= 2,
                Nama = "Fantasy"
            }
        };

        [HttpGet]
        public async Task<ActionResult<List<Varian>>> GetAllVarian()
        {
            return Ok(varians);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Varian>> GetVariansById(int id)
        {
            var prod = varians.FirstOrDefault(p => p.IdVarian == id);
            if (prod == null)
            {
                return NotFound("Data Varian tak ditemukan");
            }
            return Ok(prod);
        }
    }
}

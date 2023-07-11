using EComm_2011501158.Shared;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Utilities.IO.Pem;

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
        private async Task<List<Pengguna>> GetDbPengguna()
        {
            return await _context.Pengguna.ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<List<Pengguna>>> CreatePengguna(Pengguna pengguna)
        {
            _context.Pengguna.Add(pengguna);
            await _context.SaveChangesAsync();
            return Ok(await GetDbPengguna());
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<List<Pengguna>>> UpdatePengguna(Pengguna pengguna, int id)
        {
            var dbPengguna = await _context.Pengguna.FirstOrDefaultAsync(sh => sh.IdPengguna == id);
            if (dbPengguna == null)
                return NotFound("Data tidak ditemukan");
            dbPengguna.IdPengguna = id;
            dbPengguna.NamaPengguna = pengguna.NamaPengguna;
            dbPengguna.Username = pengguna.Username;
            dbPengguna.Password = pengguna.Password;
            dbPengguna.KonfirmPassword = pengguna.KonfirmPassword;
            dbPengguna.AlamatPengguna = pengguna.AlamatPengguna;
            dbPengguna.TeleponPengguna = pengguna.TeleponPengguna;
            dbPengguna.FotoPengguna = pengguna.FotoPengguna;
            dbPengguna.TglLahir = pengguna.TglLahir;
            dbPengguna.Admin = pengguna.Admin;
    
            await _context.SaveChangesAsync();
            return Ok(await GetDbPengguna());
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Pengguna>>> DeletePengguna(int id)
        {
            var dbPengguna = await _context.Pengguna
                .FirstOrDefaultAsync(sh => sh.IdPengguna == id);
            if (dbPengguna == null) return NotFound("data tidak ditemukan");
            _context.Pengguna.Remove(dbPengguna);
            await _context.SaveChangesAsync();
            return Ok(await GetDbPengguna());
        }

        [HttpPost("loginpengguna")]
        public async Task<ActionResult<Pengguna>>LoginPengguna(LoginModel loginmodel)
        {
            var user = await _context.Pengguna.FirstOrDefaultAsync(c => c.Username.ToLower() == loginmodel
            .Username.ToLower() && c.Password == loginmodel.Password);

            if (user == null)
            {
                return Ok(user);
            }
            else
            {
                return NotFound();
            }

            
        }
        [HttpGet("logoutpengguna")]
        public async Task<ActionResult<String>> LogOutPengguna()
        {
            await HttpContext.SignOutAsync();
            return "Succes";    
        }
    }
}

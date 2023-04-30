using EComm_2011501158.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EComm_2011501158.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdukController : ControllerBase
    {

        public static List<Produk> produks = new List<Produk>
        {
            new Produk
            {
                IdProduk=1,
                IdKategori=1,
                Nama="Misteri Tujuh Lonceng",
                Deskripsi="Misteri Tujuh Lonceng adalah sebuah " +
                "novel yang bercerita tentang pembunuhan seorang pegawai Departemen Luar " +
                "Negeri Inggris di sebuah pemondokan, yaitu Pemondokan Chimney. Setelah itu " +
                "terjadi juga pembunuhan terhadap seorang pria yang tidak lain adalah teman " +
                "orang yang terbunuh di pemondokan Chimney.",
                GambarUrl=
                "https://upload.wikimedia.org/wikipedia/id/4/4c/The_Seven_Dials_Mystery_First_Edition_Cover_1929.jpg",
                Harga=99.999m,
                HargaOrginal=100.000m,
                DateCreated=DateTime.Now,
                DateUpdated=DateTime.Now,
                IsDeleted=false,
                IsPublic=true
            },
             new Produk{
                IdProduk=2,
                IdKategori=2,
                Nama="Season of Storms",
                Deskripsi="The Witcher adalah rangkaian enam novel fantasi dan 15 cerita pendek  " +
                "yang ditulis oleh penulis Polandia Andrzej Sapkowski" +
                "Serial ini berputar di sekitar \"penyihir\" eponymous, Geralt of Rivia ",
                GambarUrl=
                "https://upload.wikimedia.org/wikipedia/en/8/84/Season_of_Storms_Orion.jpg",
                Harga=70000,
                HargaOrginal=120.000m,
                DateCreated=DateTime.Now,
                DateUpdated=DateTime.Now,
                IsDeleted=false,
                IsPublic=true
            },
             new Produk{
                IdProduk=3,
                IdKategori=2,
                Nama="Lord of the rings",
                Deskripsi="The Lord of the Rings adalah sebuah novel epik  " +
                " fantasi tinggi [a] oleh penulis dan sarjana Inggris J. R. R. Tolkien. " +
                "Bertempat di Middle-earth, ceritanya dimulai sebagai sekuel dari buku anak-anak Tolkien tahun 1937 The Hobbit, tetapi akhirnya berkembang menjadi karya yang jauh lebih besar. ",
                GambarUrl=
                "https://upload.wikimedia.org/wikipedia/en/thumb/e/e9/First_Single_Volume_Edition_of_The_Lord_of_the_Rings.gif/220px-First_Single_Volume_Edition_of_The_Lord_of_the_Rings.gif",
                Harga=70000,
                HargaOrginal=120.000m,
                DateCreated=DateTime.Now,
                DateUpdated=DateTime.Now,
                IsDeleted=false,
                IsPublic=true
            }
            

        };
        [HttpGet]
        public async Task<ActionResult<List<Produk>>> GetAllProduk()
        {
            return Ok(produks);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Produk>> GetProduksById(int id)
        {
            var prod = produks.FirstOrDefault(p => p.IdProduk == id);
            if (prod == null)
            {
                return NotFound("Data produk tak ditemukan");
            }
            return Ok(prod);
        }

    }
}

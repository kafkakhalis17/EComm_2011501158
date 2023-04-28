using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EComm_2011501158.Shared
{
    public class Kategori
    {
        [Key]
        public int IdKategori {  get; set; }
        public string Nama { get; set; }
        public List<Produk> Produk { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComm_2011501158.Shared
{
    public class ItemKereta
    {
        public int IdProduk { get; set; }
        public int IdVarian { get; set; }
        public string NamaProduk { get; set; } = string.Empty;
        public string NamaVarian { get; set; } = string.Empty;
        public decimal Harga { get; set; }
        public string Image { get; set; } = string.Empty;
    }
}

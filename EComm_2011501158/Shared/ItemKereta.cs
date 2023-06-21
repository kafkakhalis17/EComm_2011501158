using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EComm_2011501158.Shared
{
    public class ItemKereta
    {
        [JsonIgnore]
        [ForeignKey("IdPesanan")]
        public virtual Pesanan? Pesanan { get; set; }  
        public int IdPesanan { get; set; }
        [JsonIgnore]
        [ForeignKey("IdProduk")]
        public virtual Produk?Produk { get; set; }
        public int IdProduk { get; set; }
        [JsonIgnore]
        [ForeignKey("IdVarian")]
        public virtual Varian ? Varian { get; set; }
        public int IdVarian { get; set; }
        public string NamaProduk { get; set; } = string.Empty;
        public string NamaVarian { get; set; } = string.Empty;
        [Column(TypeName = "decimal(8,2)")]
        public decimal Harga { get; set; }
        public string Image { get; set; } = string.Empty;
        public int Qty { get; set; }
    }
}

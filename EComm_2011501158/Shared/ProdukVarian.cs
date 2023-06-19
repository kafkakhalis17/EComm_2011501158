using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EComm_2011501158.Shared
{
    public class ProdukVarian
    {
        [JsonIgnore]
        [ForeignKey("IdProduk")]
        
        public virtual Produk? Produk { get; set; }
        public int IdProduk { get; set; }
        [ForeignKey("IdVarian")]
        public virtual Varian? Varian { get; set; }
        public int IdVarian { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal HargaVarian { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal HargaOriVarian { get; set; }
    }
}

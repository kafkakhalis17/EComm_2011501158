using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComm_2011501158.Shared
{
    public class KonfirmasiPesanan
    {
        [Key]
        public int IdKonfirmasi { get; set; }
        public DateTime TglKonfirmasi { get; set; } = DateTime.Now;
        public string BankTransfer { get; set; } = string.Empty;
        public DateTime TglTransfer { get; set; } = DateTime.Now;
      
       
        [Column(TypeName = "decimal(18,2)")]
        public decimal JumlahTransfer { get; set; }
            
        [ForeignKey (nameof(IdPesanan))]
        public Pesanan? Pesanan { get; set; }
        [Required(ErrorMessage = "Id Pesananan Harus Diisi")]
        public int IdPesanan { get; set; }

    }
}

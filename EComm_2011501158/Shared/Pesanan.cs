using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComm_2011501158.Shared
{
    public class Pesanan
    {
        [Key]
        public int IdPesanan { get; set; }
        public DateTime TglPesanan { get; set; } = DateTime.Now;
        public List<ItemKereta>PesaananProduk { get; set; }= new List<ItemKereta>();    
    }
}

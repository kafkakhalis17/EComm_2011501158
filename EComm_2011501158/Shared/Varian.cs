using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComm_2011501158.Shared
{
    public class Varian
    {
        [Key]
        public int IdVarian { get; set; } 
        public string Nama { get; set;} = string.Empty;
    }
}

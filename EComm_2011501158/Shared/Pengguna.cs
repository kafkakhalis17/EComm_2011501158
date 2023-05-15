using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EComm_2011501158.Shared
{
    public class Pengguna
    {
        [Key]
        public int IdPengguna { get; set; }
        public string Username { get; set; } = String.Empty;
        public string NamaPengguna { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;
        public string KonfirmPassword { get; set; } = String.Empty;
        public string EmailPengguna { get; set; } = String.Empty;
        public string AlamatPengguna { get; set; } = String.Empty;
        public string TeleponPengguna { get; set; } = String.Empty;
        public string FotoPengguna { get; set; } = String.Empty;
        public DateTime TglLahir { get; set; }
        public bool Admin { get; set; }
        
    }
}

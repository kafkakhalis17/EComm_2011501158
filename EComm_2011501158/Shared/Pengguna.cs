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
        [Required(ErrorMessage = "Username Harus Diisi")]
        public string Username { get; set; } = String.Empty;
        [Required(ErrorMessage = "Nama Harus Diisi")]
        public string NamaPengguna { get; set; } = String.Empty;
        [Required(ErrorMessage = "Password Pengguna Harus Diisi")]
        [MinLength(8, ErrorMessage = "Panjang password minimal 8 karakter")]
        public string Password { get; set; } = String.Empty;
        [Required(ErrorMessage = "Konfirmasi Password Harus Diisi")]
        [Compare("Password", ErrorMessage = "Konfirmasi Password Harus Sama dengan Password")]
        public string KonfirmPassword { get; set; } = String.Empty;
        [Required(ErrorMessage = "Email  Pengguna Harus Diisi")]
        [EmailAddress(ErrorMessage = "Format Email tidak valid")]
        public string EmailPengguna { get; set; } = String.Empty;
        [Required(ErrorMessage = "Alamat Harus Diisi")]
        public string AlamatPengguna { get; set; } = String.Empty;
        [Required(ErrorMessage = "Telp Harus Diisi")]
        [MaxLength(12, ErrorMessage = "No telp Tidak valid")]
        public string TeleponPengguna { get; set; } = String.Empty;
        [Required(ErrorMessage = "Gambar Pengguna Harus Diisi")]
        public string FotoPengguna { get; set; } = String.Empty;
        [Required(ErrorMessage = "Tanggal lahir Harus Diisi")]
        public DateTime TglLahir { get; set; }
        [Required(ErrorMessage = "Status User harus diisi")]
        public bool Admin { get; set; }
        
    }
}

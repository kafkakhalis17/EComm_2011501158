namespace EComm_2011501158.Client.Services.PenggunaService
{
    public interface IPenggunaService
    {
        List<Pengguna> Penggunas { get; set; }
        Task GetAllPengguna();
        Task<Produk> GetPenggunaById(int id);
    }
}

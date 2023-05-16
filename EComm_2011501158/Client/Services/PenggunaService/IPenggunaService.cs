namespace EComm_2011501158.Client.Services.PenggunaService
{
    public interface IPenggunaService
    {
        List<Pengguna> Penggunas { get; set; }
        Task GetAllPengguna();
        Task<Pengguna> GetPenggunaById(int id);
        Task CreatePengguna(Pengguna pengguna);
        Task UpdatePengguna(Pengguna pengguna);
        Task DeletePengguna(int id);
    }
}

namespace EComm_2011501158.Client.Services.KategoriService
{
    public interface IKategoriService
    {
        List<Kategori> Kategoris  { get; set; }
        Task GetAllKategori();
        Task<Kategori> GetKategoriById(int id);
    }
}

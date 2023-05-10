namespace EComm_2011501158.Client.Services.KategoriService
{
    public interface IKategoriService
    {
        List<Kategori> Kategoris { get; set; }

        Task GetAllKategori();
        Task<Kategori> GetKategoriById(int id);

        Task CreateKategori(Kategori kategori);
        Task DeleteKategori(int id);    
        Task UpdateKategori(Kategori kategori);
    }
}

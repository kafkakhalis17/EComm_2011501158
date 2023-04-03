namespace EComm_2011501158.Client.Services.ProdukService
{
    public interface IProdukService
    {
        List<Produk> Produks { get; set; }
        Task GetAllProduk();
        Task <Produk> GetProduksById(int id);
    }
}

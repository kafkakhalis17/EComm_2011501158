namespace EComm_2011501158.Client.Services.PesananProdukService
{
    public interface IPesananProdukService
    {
        List<ItemKereta>ItemKeretas { get; set; }
        Task CreatePesananProduk(ItemKereta item);
        Task<List<ItemKereta>> GetAllPesananProduk();
    }
}

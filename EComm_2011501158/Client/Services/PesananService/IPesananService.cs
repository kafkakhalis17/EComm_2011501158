namespace EComm_2011501158.Client.Services.PesananService
{
    public interface IPesananService
    {
        List<Pesanan>Pesanans { get; set; }
        Task CreatePesanan(Pesanan pesanan);
        Task<int> GetIdTerakhir(    );
        Task<List<Pesanan>> GetAllPesanan();

    }
}

using EComm_2011501158.Shared;
namespace EComm_2011501158.Client.Services.KonfirmasiPesananService
{
    public interface IKonfirmasiPesananService
    {
        List<KonfirmasiPesanan> konfirmasiPesanans { get; set; }
        Task GetAllKonfirmasi();
        Task CreateKonfirmasiPesanan(KonfirmasiPesanan konfirmasiPesanan);
        Task DeleteKonfirmasiPesanan(int id);
    }
}

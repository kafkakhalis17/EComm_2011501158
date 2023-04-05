namespace EComm_2011501158.Client.Services.VarianService
{
    public interface IVarianService
    {
        List<Varian> Varians { get; set; }

        Task GetAllVarian();

        Task<Varian> GetVarianById(int id);
    }
}

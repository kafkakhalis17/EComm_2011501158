namespace EComm_2011501158.Client.Services.KeretaService
{
    public interface IKeretaService
    {
        event Action OnChange;
        Task TambahKereta(ItemKereta item);
        Task<List<ItemKereta>> GetItemKereta();

        Task HapusItem(ItemKereta item);
        Task KosongKereta();
    }
}

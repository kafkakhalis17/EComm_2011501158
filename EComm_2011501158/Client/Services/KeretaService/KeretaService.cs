using EComm_2011501158.Shared;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using EComm_2011501158.Client.Services.ProdukService;
using System.Data;

namespace EComm_2011501158.Client.Services.KeretaService
{
    public class KeretaService :IKeretaService
    {
        private readonly ILocalStorageService _localStorage;
        private readonly IToastService _toastService;
        private readonly IProdukService _produkService;
        public event Action OnChange;
        public KeretaService(
            ILocalStorageService localStorage,
            IToastService toastservice,
            IProdukService produkservice
            ) {
            _localStorage = localStorage;
            _toastService = toastservice;
            _produkService = produkservice;
            }
        public async Task HapusItem(ItemKereta item)
        {
            var kereta = await _localStorage.GetItemAsync<List<ItemKereta>>("kereta");
            if (kereta == null) { return; }
            var ItemKereta = kereta
            .Find(x => x.IdProduk == item.IdProduk && x.IdVarian == item.IdVarian);
            kereta.Remove(ItemKereta);
            await _localStorage.SetItemAsync("kereta", kereta);
            OnChange.Invoke();
        }

        public async Task TambahKereta(ItemKereta item)
        {
            var kereta = await _localStorage.GetItemAsync<List<ItemKereta>>("kereta");
            if (kereta == null)
            {
                kereta = new List<ItemKereta>();
            }var ItemSama = kereta
                .Find(x => x.IdProduk == item.IdProduk && x.IdVarian == item.IdVarian);
            if(ItemSama == null)
            {
                kereta.Add(item);
            }
            else
            {
                ItemSama.Qty += item.Qty;
            }
           
            await _localStorage.SetItemAsync("kereta", kereta);
            var produk = await _produkService.GetProduksById(item.IdProduk);
            _toastService.ShowToast(ToastLevel.Success, "Tambah" + produk.Nama);
            OnChange.Invoke();
        }

        public async Task<List<ItemKereta>> GetItemKereta()
        {
            var kereta = await _localStorage.GetItemAsync<List<ItemKereta>>("kereta");
            if(kereta == null)
            {
                return new List<ItemKereta>();
            }
            return kereta;
        }

    
        public async Task KosongKereta()
        {
            await _localStorage.RemoveItemAsync("kereta");
            OnChange.Invoke();
        }
    }
}

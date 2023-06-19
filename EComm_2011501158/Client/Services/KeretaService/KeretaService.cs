using EComm_2011501158.Shared;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using EComm_2011501158.Client.Services.ProdukService;

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
            var kereta = await _localStorage.GetItemAsync<List<ProdukVarian>>("kereta");
            if (kereta == null) { return; }
            var ItemKereta = kereta
            .Find(x => x.IdProduk == item.IdProduk && x.IdVarian == item.IdVarian);
            kereta.Remove(ItemKereta);
            await _localStorage.SetItemAsync("kereta", kereta);
            OnChange.Invoke();
        }

        public async Task TambahKereta(ProdukVarian produkVarian)
        {
            var kereta = await _localStorage.GetItemAsync<List<ProdukVarian>>("kereta");
            if (kereta == null)
            {
                kereta = new List<ProdukVarian>();
            }
            kereta.Add(produkVarian);
            await _localStorage.SetItemAsync("kereta", kereta);
            var produk = await _produkService.GetProduksById(produkVarian.IdProduk);
            _toastService.ShowToast(ToastLevel.Success, "Tambah" + produk.Nama);
            OnChange.Invoke();
        }

        public async Task<List<ItemKereta>> GetItemKereta()
        {
             var result = new List<ItemKereta>();
             var kereta = await _localStorage.GetItemAsync<List<ProdukVarian>>("kereta");
            if (kereta == null)
            {
                return result;
            }
            foreach (var item in kereta) {
                var produk = await _produkService.GetProduksById(item.IdProduk);
                var KeretaItem = new ItemKereta
                {
                    IdProduk = produk.IdProduk,
                    NamaProduk = produk.Nama,
                    Image = produk.GambarUrl,
                    IdVarian = item.IdVarian
                };
                var varians = produk.ProdukVarians
                    .Find(v => v.IdVarian == item.IdVarian);
                if (varians != null)
                {
                    KeretaItem.NamaVarian = varians.Varian?.Nama;
                    KeretaItem.Harga = varians.HargaVarian;
                }
                result.Add(KeretaItem);
            }
            return result;
        }
    }
}

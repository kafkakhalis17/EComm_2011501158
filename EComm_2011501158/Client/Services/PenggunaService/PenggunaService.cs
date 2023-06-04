﻿using EComm_2011501158.Shared;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using System.Xml;
using static System.Net.WebRequestMethods;

namespace EComm_2011501158.Client.Services.PenggunaService
{
    public class PenggunaService : IPenggunaService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationmanager;
        
        public PenggunaService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationmanager = navigationManager; 
        }
        public List<Pengguna> Penggunas { get; set; } = new List<Pengguna>();

        public async Task CreatePengguna(Pengguna pengguna)
        {
            var result = await _http.PostAsJsonAsync("api/pengguna", pengguna);
            var response = await result.Content.ReadFromJsonAsync<List<Pengguna>>();
            Penggunas = response;
            _navigationmanager.NavigateTo("/master_pengguna");
        }

        public async Task DeletePengguna(int id)
        {
            var result = await _http.DeleteAsync($"api/pengguna/{id}");
            var response = await result.Content.ReadFromJsonAsync<List<Pengguna>>();
            Penggunas = response;
            _navigationmanager.NavigateTo("/master_pengguna");
        }
        public async Task GetAllPengguna()
        {
            var result = await _http.GetFromJsonAsync<List<Pengguna>>("api/pengguna");
            if (result != null)
            {
                Penggunas = result;
            }
            throw new NotImplementedException();
        }

        public async Task<Pengguna> GetPenggunaById(int id)
        {
            var result = await _http.GetFromJsonAsync<Pengguna>($"api/pengguna/{id}");
            if (result != null) { return result; }
            throw new Exception("Data tidak ditemukan");
        }

        public async Task UpdatePengguna(Pengguna pengguna)
        {
            var result = await _http.PutAsJsonAsync($"api/pengguna/{pengguna.IdPengguna}", pengguna);
            var response = await result.Content.ReadFromJsonAsync<List<Pengguna>>();
            Penggunas = response;
            _navigationmanager.NavigateTo("/master_pengguna");
        }
    }
}

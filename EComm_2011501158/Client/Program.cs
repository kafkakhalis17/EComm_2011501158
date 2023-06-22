global using EComm_2011501158.Client.Services.ProdukService;
global using EComm_2011501158.Client.Services.KategoriService;
global using EComm_2011501158.Client.Services.VarianService;
global using EComm_2011501158.Client.Services.PenggunaService;
global using EComm_2011501158.Client.Services.KeretaService;
global using EComm_2011501158.Client.Services.PesananProdukService;
global using EComm_2011501158.Client.Services.PesananService;
global using EComm_2011501158.Shared;
global using Blazored.Toast;
global using Blazored.Toast.Services;
global using Blazored.LocalStorage;
using EComm_2011501158.Client;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using EComm_2011501158.Client.Services.PesananService;
using EComm_2011501158.Client.Services.PesananProdukService;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IProdukService, ProdukService>();
builder.Services.AddScoped<IKategoriService, KategoriService>();
builder.Services.AddScoped<IVarianService, VarianService>();
builder.Services.AddScoped<IKeretaService, KeretaService>();
builder.Services.AddScoped<IPenggunaService, PenggunaService>();
builder.Services.AddScoped<IPesananService, PesananService>();
builder.Services.AddScoped<IPesananProdukService, PesananProdukService>();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddBlazoredToast();
await builder.Build().RunAsync();

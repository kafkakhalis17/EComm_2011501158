global using EComm_2011501158.Client.Services.ProdukService;
global using EComm_2011501158.Client.Services.KategoriService;
global using EComm_2011501158.Client.Services.VarianService;
global using EComm_2011501158.Shared;
using EComm_2011501158.Client;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IProdukService, ProdukService>();
builder.Services.AddScoped<IKategoriService, KategoriService>();
builder.Services.AddScoped<IVarianService, VarianService>();
await builder.Build().RunAsync();

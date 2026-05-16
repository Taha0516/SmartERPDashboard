using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SmartERPDashboard;
using SmartERPDashboard.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// ── Register Services ───────────────────────────────────────────
builder.Services.AddSingleton<IMockDataService, MockDataService>();
builder.Services.AddSingleton<LocalizationService>();

await builder.Build().RunAsync();

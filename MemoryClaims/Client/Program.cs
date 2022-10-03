using MemoryClaims.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("main");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
//btw i feel this book need to be free and live.. so if you understand it then 3 level sick story 
//no big deal
builder.Services.AddScoped(x => new Claims.ClientIsConnectedToSoftwareThisIsWhatWeeKnowThisOfDetail() { Software = Claims.Software.Private });
await builder.Build().RunAsync();
using MemoryClaims.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("main");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
//btw i feel this book need to be free and live.. so if you understand it then 3 level sick story 
//no big deal 
//i just made a link to the commit so ppl come to this..
builder.Services.AddScoped(x => new Claims.ClientDetail() { Software = Claims.Software.PrivateClaims });
await builder.Build().RunAsync();
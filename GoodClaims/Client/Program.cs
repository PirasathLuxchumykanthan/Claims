using GoodClaims.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Security.Claims;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("main");
builder.RootComponents.Add<HeadOutlet>("head::after");
//i made the same stuff add Claims
//and btw sorry my english i need to say but i do my best
//this will show how i get invold whit the diffrent project so u can see
builder.Services.AddScoped(x => new Claims.ClientDetail() { Software = Claims.Software.PrivateGood });
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
await builder.Build().RunAsync();
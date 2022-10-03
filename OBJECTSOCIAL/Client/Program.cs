using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using OBJECTSOCIAL.Client;
using System.Security.Claims;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("main");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
//haha i waited to add the ddl to claims bce this is is business connet to the business...
builder.Services.AddScoped(x => new Claims.ClientIsConnectedToSoftwareThisIsWhatWeeKnowThisOfDetail() { Software = Claims.Software.Private });
await builder.Build().RunAsync();
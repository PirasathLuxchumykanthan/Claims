using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using OBJECTSOCIAL.Client;
using System.Security.Claims;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("main");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
//haha i waited to add the ddl to claims bce this is is business connet to the business...
// iw ant to do this as lifestyle be call if ppl can donate me
//haha btw is business software.
//so cool u can see this..
builder.Services.AddScoped(x => new Claims.ClientIsConnectedToSoftwareThisIsWhatWeeKnowThisOfDetail() { Software = Claims.Software.Business });
await builder.Build().RunAsync();
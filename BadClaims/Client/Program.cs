using BadClaims.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("main");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
//made bad.claims
//btw all comment her also log.. in this story behind the code.
//as i thing need to be social..
//so wild u got it it every comment i made a story to
//btw i made this public to tell my story
builder.Services.AddScoped(x => new Claims.ClientIsConnectedToSoftwareThisIsWhatWeeKnowThisOfDetail() { Software=Claims.Software.Private });
await builder.Build().RunAsync();
using ClaimsSoftware.Data;
using Microsoft.AspNetCore.Components.WebView.Maui;

namespace ClaimsSoftware
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            //made the same
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>();
            builder.Services.AddScoped(x => new Claims.ClientIsConnectedToSoftwareThisIsWhatWeeKnowThisOfDetail() { Software = Claims.Software.PrivateClaims });
            builder.Services.AddMauiBlazorWebView();
#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif


            return builder.Build();
        }
    }
}
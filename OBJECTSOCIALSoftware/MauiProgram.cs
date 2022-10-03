using Microsoft.AspNetCore.Components.WebView.Maui;
using OBJECTSOCIALSoftware.Data;

namespace OBJECTSOCIALSoftware
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>(); ;

            builder.Services.AddMauiBlazorWebView();
#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif
            //uhh i hate this weaterforcastservice
            builder.Services.AddSingleton<WeatherForecastService>();

            return builder.Build();
        }
    }
}
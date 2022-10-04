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
            builder.Services.AddScoped(x => new Claims.ClientDetail()
            {
                Software = Claims.Software.Business,
                Entrance =
#if ANDROID
                 Claims.Entrance.Android
#elif MACCATALYST
 Claims.Entrance.Mac
#elif WINDOWS
Claims.Entrance.Microsoft
#elif IOS
Claims.Entrance.iOS
#else
Claims.Entrance.Unknown
#endif

            });
            //i got no more space on my computer
            //remove some old files
            builder.Services.AddMauiBlazorWebView();
#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif


            return builder.Build();
        }
    }
}
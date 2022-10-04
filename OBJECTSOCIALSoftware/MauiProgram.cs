using Microsoft.AspNetCore.Components.WebView.Maui;


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
            //i know when is coming as software.business then is OBJECT:SOCIAL
            //so when person come from business app and private person then i know what time of person it is..
            //normal her a member have a login the can use. so remeber that
            //so total yes then wee have 2 business software and 4 private software..
            //lest say this if a person login a business then he is serious business man.and he need to work no fun.. no share stuff..
            //well i say this will become mind blow
      //know you know why i have inset unkown
           builder.Services.AddScoped(x => new Claims.ClientDetail() { Software = Claims.Software.Business, Entrance=
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

            return builder.Build();
        }
    }
}
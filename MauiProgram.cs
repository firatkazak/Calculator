namespace Calculator;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        MauiAppBuilder builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>().ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            fonts.AddFont("Sublima-ExtraBold.otf", "SublimaExtraBold");
            fonts.AddFont("Sublima-Light.otf", "SublimaLight");
        });
        return builder.Build();
    }
}

using Microsoft.Extensions.Logging;

namespace TDMPW_412_2P_EX;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("coolvetica-compressed.otf", "coolveticaCompressed");
                fonts.AddFont("coolvetica.otf", "coolveticaNormal");
                fonts.AddFont("coolvetica-condensed.otf", "coolveticaCondensed");
                fonts.AddFont("Cocogoose-Pro-Semilight.ttf", "cocogooseSemi");
                fonts.AddFont("fontello.ttf", "icono");
                fonts.AddFont("fontello2.ttf", "icono2");
                fonts.AddFont("fontello3.ttf", "icono3");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

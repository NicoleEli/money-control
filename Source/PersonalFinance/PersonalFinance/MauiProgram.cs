﻿using Microsoft.Extensions.Logging;
using PersonalFinance.ViewModels;

namespace PersonalFinance;

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
			});

		builder.Services.AddTransient<MainPage>();

		builder.Services.AddTransient<MainPageViewModel>();
		builder.Services.AddTransient<BudgetSheet>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

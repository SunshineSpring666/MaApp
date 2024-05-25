using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;

namespace MaApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.ConfigureSyncfusionCore();
            builder.UseMauiApp<App>();

            return builder.Build();
        }
    }
}
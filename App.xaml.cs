using Syncfusion.Maui.Scheduler;
using Syncfusion.Maui.Popup;
using System.Globalization;
using System.Resources;
namespace MaApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        CultureInfo.CurrentUICulture = new CultureInfo("zh-CN");
        SfSchedulerResources.ResourceManager = new ResourceManager("MaApp.Resources.SfScheduler", Application.Current.GetType().Assembly);
        SfPopupResources.ResourceManager = new ResourceManager("MaApp.Resources.SfPopup", Application.Current.GetType().Assembly);
        MainPage = new AppShell();
    }
}
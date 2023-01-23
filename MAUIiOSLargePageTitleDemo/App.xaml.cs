using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using Application = Microsoft.Maui.Controls.Application;

namespace MAUIiOSLargePageTitleDemo;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        // Enable Large Title for iOS
        var navigationPage = new Microsoft.Maui.Controls.NavigationPage(new MainPage());
        navigationPage.On<iOS>().SetPrefersLargeTitles(true);
        MainPage = navigationPage;
    }
}

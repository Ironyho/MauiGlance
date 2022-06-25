using MauiGlance.ViewModels;

namespace MauiGlance;

public partial class App : Application
{
    public App(ShellViewModel shellViewModel)
    {
        InitializeComponent();

        MainPage = AppConfig.Desktop ? new DesktopShell() : new MobileShell();
        MainPage.BindingContext = shellViewModel;

        RequestedThemeChanged += App_RequestedThemeChanged;
    }

    private void App_RequestedThemeChanged(object sender, AppThemeChangedEventArgs e)
    {
        MessagingCenter.Send<App, AppTheme>(this, "Theme", e.RequestedTheme);
    }
}
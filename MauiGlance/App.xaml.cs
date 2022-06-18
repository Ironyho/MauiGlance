using MauiGlance.ViewModels;

namespace MauiGlance;

public partial class App : Application
{
	public App(ShellViewModel shellViewModel)
	{
		InitializeComponent();

		MainPage = AppConfig.Desktop ? new DesktopShell() : new MobileShell();
		MainPage.BindingContext = shellViewModel;
	}
}
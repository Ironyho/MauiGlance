using MauiGlance.Models;
using MauiGlance.Resources.Strings;

using MvvmHelpers;

namespace MauiGlance.ViewModels
{
    public class ShellViewModel : BaseViewModel
    {
        public AppModule Docs { get; set; }
        public AppModule Demos { get; set; }
        public AppModule Samples { get; set; }
        public AppModule Settings { get; set; }

        public ShellViewModel()
        {
            InitializeModules();
            ThemeModuleIcons();

            SubscribeThemeMessage();
        }

        private void InitializeModules()
        {
            Docs = new AppModule { Title = AppResource.Shell_Docs };
            Demos = new AppModule { Title = AppResource.Shell_Demos };
            Samples = new AppModule { Title = AppResource.Shell_Samples };
            Settings = new AppModule { Title = AppResource.Shell_Settings };
        }

        private void SubscribeThemeMessage()
        {
            MessagingCenter.Subscribe<App, AppTheme>(this, "Theme", (sender, theme) =>
            {
                ThemeModuleIcons(theme);
            });
        }

        private void ThemeModuleIcons(AppTheme theme = AppTheme.Unspecified)
        {
            if (theme == AppTheme.Dark)
            {
                Docs.Icon = "shell_docs_dark.png";
                Demos.Icon = "shell_demos_dark.png";
                Samples.Icon = "shell_samples_dark.png";
                Settings.Icon = "shell_settings_dark.png";
            }
            else
            {
                Docs.Icon = "shell_docs.png";
                Demos.Icon = "shell_demos.png";
                Samples.Icon = "shell_samples.png";
                Settings.Icon = "shell_settings.png";
            }
        }
    }
}
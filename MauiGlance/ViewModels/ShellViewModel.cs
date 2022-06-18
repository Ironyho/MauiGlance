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
            Docs = new AppModule { Title = AppResource.Shell_Docs, };
            Demos = new AppModule { Title = AppResource.Shell_Demos };
            Samples = new AppModule { Title = AppResource.Shell_Samples };
            Settings = new AppModule { Title = AppResource.Shell_Settings };
        }
    }
}
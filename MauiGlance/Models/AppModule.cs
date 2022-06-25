using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace MauiGlance.Models;

public partial class AppModule: ObservableObject
{
    [ObservableProperty]
    string title;

    [ObservableProperty]
    string icon;
}
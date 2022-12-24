using DelayedCertificateIssuingMachine.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace DelayedCertificateIssuingMachine.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }

    private void FileNew_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void FileExport_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void FileExit_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void HelpAbout_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }
}

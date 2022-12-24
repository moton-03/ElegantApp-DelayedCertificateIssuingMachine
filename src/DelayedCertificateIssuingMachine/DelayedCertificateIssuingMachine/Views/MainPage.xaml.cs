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

    void Ini()
    {
        MainTextBox.Text = "Enter the properties and export.";

        DelayTime.Text = "";
        Publisher.Text = "";
        PublicationTime.Text = "";
    }

    private void New_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        Ini();
    }

    private void Export_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }
}

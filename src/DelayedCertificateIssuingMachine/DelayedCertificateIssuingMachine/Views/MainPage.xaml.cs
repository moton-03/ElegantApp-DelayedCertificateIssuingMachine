using System.Diagnostics;
using System.Text;
using DelayedCertificateIssuingMachine.ViewModels;

using Microsoft.UI.Xaml.Controls;
using Windows.Storage.Pickers;
using WinRT.Interop;
using static System.Net.Mime.MediaTypeNames;

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

        Ini();
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
        string Text;

        Text = $@"--Delayed Certificate--
This certificate proves that something was delayed by {DelayTime.Text}.
  {PublicationTime.Text}
    {Publisher.Text}";

        MainTextBox.Text = Text;
    }

    private void Download_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void Print_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }
}
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Coursework.UI.Pages.Menus;

public partial class DoctorMenu : Page
{
    public DoctorMenu()
    {
        InitializeComponent();
    }

    private void ShowCharts(object sender, RoutedEventArgs e)
    {
        MainWindow window = (Application.Current.MainWindow as MainWindow)!;
        window.ContentFrame.Source = window.pages["ShowDoctorsChartsPage"];
    }

    private void MakeNewChart(object sender, RoutedEventArgs e)
    {
        MainWindow window = (Application.Current.MainWindow as MainWindow)!;
        window.ContentFrame.Source = window.pages["MakeNewChartPage"];
    }

    private void CloseChart(object sender, RoutedEventArgs e)
    {
        MainWindow window = (Application.Current.MainWindow as MainWindow)!;
        window.ContentFrame.Source = window.pages["CloseChartPage"];
    }

    private void TextBlock_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
    {
        Border border = (Border)sender;
        border.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD8, 0xE2, 0xEC));
    }

    private void TextBlock_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
    {
        Border border = (Border)sender;
        border.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xE7, 0xE7, 0xDE));
    }
}
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Coursework.UI.Pages.Menus;

public partial class GuestMenu : Page
{
    public GuestMenu()
    {
        InitializeComponent();
    }

    private void Hyperlink_OnClick(object sender, RoutedEventArgs e)
    {
        MainWindow window = (Application.Current.MainWindow as MainWindow)!;
        window.ContentFrame.Source = window.pages["HelloPage"];
    }

    private void Show_Docs(object sender, RoutedEventArgs e)
    {
        MainWindow window = (Application.Current.MainWindow as MainWindow)!;
        window.ContentFrame.Source = window.pages["ShowDoctorsListPage"];
    }

    private void TextBlock_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
    {
        Border border = (Border)sender;
        border.Background = new SolidColorBrush(Color.FromArgb(255, 255, 143, 23));
    }

    private void TextBlock_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
    {
        Border border = (Border)sender;
        border.Background = new SolidColorBrush(Color.FromArgb(255, 255, 252, 245));
    }
}
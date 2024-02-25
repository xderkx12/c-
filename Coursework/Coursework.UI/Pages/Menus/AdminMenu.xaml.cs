﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Coursework.UI.Pages.Menus;

public partial class AdminMenu : Page
{
    public AdminMenu()
    {
        InitializeComponent();
    }

    private void LookAtDocs(object sender, RoutedEventArgs e)
    {
        MainWindow window = (Application.Current.MainWindow as MainWindow)!;
        window.ContentFrame.Source = window.pages["ShowDoctorsListPage"];
    }

    private void NewDoctor(object sender, RoutedEventArgs e)
    {
        MainWindow window = (Application.Current.MainWindow as MainWindow)!;
        window.ContentFrame.Source = window.pages["AddDoctorPage"];
    }

    private void LookAtPatients(object sender, RoutedEventArgs e)
    {
        MainWindow window = (Application.Current.MainWindow as MainWindow)!;
        window.ContentFrame.Source = window.pages["ShowPatientsListPage"];
    }

    private void LookAtCharts(object sender, RoutedEventArgs e)
    {
        MainWindow window = (Application.Current.MainWindow as MainWindow)!;
        window.ContentFrame.Source = window.pages["ShowChartsPage"];
    }

    private void ShowChambersPage(object sender, RoutedEventArgs e)
    {
        MainWindow window = (Application.Current.MainWindow as MainWindow)!;
        window.ContentFrame.Source = window.pages["ShowChambersPage"];
    }

    private void ShowIllnessesPage(object sender, RoutedEventArgs e)
    {
        MainWindow window = (Application.Current.MainWindow as MainWindow)!;
        window.ContentFrame.Source = window.pages["ShowIllnessPage"];
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
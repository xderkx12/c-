using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Coursework.BLL.DtoModels;
using Coursework.BLL.Services;
using Coursework.Domain;

namespace Coursework.UI.Pages.Content.Doctor;

public partial class ShowDoctorsChartsPage : Page
{
    private ChartDto? _lastSelected { get; set; } = null;
    public ObservableCollection<ChartDto> ChartDtos { get; set; }
    public ShowDoctorsChartsPage()
    {
        InitializeComponent();
        MainWindow window = (Application.Current.MainWindow as MainWindow)!;
        ChartDtos = window.manager.GetDoctorsCharts(Identity.UserId);
        Charts.ItemsSource = ChartDtos;
    }

    private void Confirm_Changes(object sender, RoutedEventArgs e)
    {
        MainWindow window = (Application.Current.MainWindow as MainWindow)!;
        Chart old = window.manager.ChartManager.GetById(_lastSelected!.Id);
        Chart @new = new Chart
        {
            ChamberId = old.ChamberId,
            Content = TxtBoxContent.Text,
            DoctorId = old.DoctorId,
            Finish = old.Finish,
            Id = old.Id,
            IllnessId = old.IllnessId,
            PatientId = old.PatientId,
            Start = old.Start
        };
        window.manager.ChartManager.Update(old, @new);
    }

    private void Charts_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        ConfirmButton.IsEnabled = true;
        _lastSelected = (ChartDto)Charts.SelectedItem;
        TxtBoxContent.Text = _lastSelected.Content;
    }

    private void TxtBoxContent_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void textBox_PreviewKeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.Enter)
        {
                TxtBoxContent.AppendText(Environment.NewLine);
                TxtBoxContent.CaretIndex = TxtBoxContent.Text.Length; // перемещаем курсор на последнюю позицию в текстовом поле
                TxtBoxContent.ScrollToEnd(); // перемещаем курсор на конец текстового поля
                e.Handled = true; // отменяем стандартное поведение Enter
        }
    }

}
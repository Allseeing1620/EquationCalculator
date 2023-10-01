using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace EquationCalculator.Components;

public partial class Matrices : UserControl
{
    public Matrices()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void Сalculate(object? sender, RoutedEventArgs e)
    {
        var matricesViewModel = DataContext as MatricesViewModel;
        matricesViewModel.Result();
    }
}
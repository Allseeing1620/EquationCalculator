using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace EquationCalculator.Components;

public partial class LogarithmView : UserControl
{
    public LogarithmView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void Сalculate(object? sender, RoutedEventArgs e)
    {
        var logarithmView = DataContext as LogarithmViewModel;
        logarithmView.Result();
    }
}
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace EquationCalculator.Components;

public partial class QuadraticEqautions : UserControl
{
    public QuadraticEqautions()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
    
    private void Сalculate(object? sender, RoutedEventArgs e)
    {
        var linearEquations = DataContext as QuadraticEquationsViewModel;
        linearEquations.Result();
    }
}
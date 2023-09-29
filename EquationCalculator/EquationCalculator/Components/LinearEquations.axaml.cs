using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace EquationCalculator.Components;

public partial class LinearEquations : UserControl
{
    public LinearEquations()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
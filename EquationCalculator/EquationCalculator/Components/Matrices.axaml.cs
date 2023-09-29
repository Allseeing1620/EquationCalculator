using Avalonia;
using Avalonia.Controls;
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
}
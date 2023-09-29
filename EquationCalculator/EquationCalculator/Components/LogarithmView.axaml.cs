using Avalonia;
using Avalonia.Controls;
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
}
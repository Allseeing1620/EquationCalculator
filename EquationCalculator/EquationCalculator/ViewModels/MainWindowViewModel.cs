using EquationCalculator.Components;

namespace EquationCalculator.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public QuadraticEquationsViewModel QuadraticEquationsViewModel { get; set; } = new();
    public MatricesViewModel MatricesViewModel { get; set; } = new();
    public LogarithmViewModel LogarithmViewModel { get; set; } = new();
    
}
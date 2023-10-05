using System;
using EquationCalculator.ViewModels;
using ReactiveUI;

namespace EquationCalculator.Components;

public class LogarithmViewModel : ViewModelBase
{
    private string _resultLogarithm = "c";
    private string _baseLogarithm = "0";
    private string _valueLogarithm = "0";

    public string ResultValue { 
        get => _resultLogarithm; 
        set => this.RaiseAndSetIfChanged(ref _resultLogarithm, value);
    }
    
    public string BaseLogarithm { 
        get => _baseLogarithm; 
        set => this.RaiseAndSetIfChanged(ref _baseLogarithm, value);
    }
    
    public string ValueLogarithm { 
        get => _valueLogarithm; 
        set => this.RaiseAndSetIfChanged(ref _valueLogarithm, value);
    }
    
    public void Result()
    {
        ResultValue = Math.Log(Convert.ToDouble(ValueLogarithm),Convert.ToDouble(BaseLogarithm)).ToString("#0.00");
    }
    
}
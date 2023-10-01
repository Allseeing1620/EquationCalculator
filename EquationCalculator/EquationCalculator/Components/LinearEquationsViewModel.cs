using System.ComponentModel;
using EquationCalculator.ViewModels;
using ReactiveUI;

namespace EquationCalculator.Components;

public class LinearEquationsViewModel: ViewModelBase
{
    private string _boxOne = "dfff";
    private string _boxTwo = "";

    public string BoxOne { 
        get => _boxOne;
        set => this.RaiseAndSetIfChanged(ref _boxOne, value);
    }
    public string BoxTwo { 
        get => _boxTwo;
        set => this.RaiseAndSetIfChanged(ref _boxTwo, value);
        
    }

    public LinearEquationsViewModel()
    {
        this.PropertyChanged += OnPropertyChanged;
    }

    private void OnPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
    }

}
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text.RegularExpressions;
using EquationCalculator.ViewModels;
using ReactiveUI;

namespace EquationCalculator.Components;

public class LinearEquationsViewModel: ViewModelBase
{
    private string _boxOne = "x+1";
    private string _boxTwo = "0";
    private string leftSide = "";
    private string rightSide = "";

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

    public void Result()
    {
        
    }

    public void LeftSide()
    {
        string pattern = "x";
        IList<int> indeces = new List<int>();
        foreach (Match match in Regex.Matches(_boxOne, pattern))
        {
            indeces.Add(match.Index);
        }
        
    }
    
    
    public void RightSide()
    {
        string pattern = "x";
        IList<int> indeces = new List<int>();
        foreach (Match match in Regex.Matches(_boxTwo, pattern))
        {
            indeces.Add(match.Index);
        }
    }
}
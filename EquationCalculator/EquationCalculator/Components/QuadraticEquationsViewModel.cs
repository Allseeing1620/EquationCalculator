using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text.RegularExpressions;
using EquationCalculator.ViewModels;
using ReactiveUI;

namespace EquationCalculator.Components;

public class QuadraticEquationsViewModel: ViewModelBase
{
    private string _boxOne = "0";
    private string _boxTwo = "0";
    private string _boxThree = "0";
    private string _boxFourth = "0";
    private string _boxRes = "x=0";
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

    public string BoxThree
    {
        get => _boxThree;
        set => this.RaiseAndSetIfChanged(ref _boxThree, value);
    }
    
    public string BoxFourth
    {
        get => _boxFourth;
        set => this.RaiseAndSetIfChanged(ref _boxFourth, value);
    }

    public string BoxRes
    {
        get => _boxRes;
        set => this.RaiseAndSetIfChanged(ref _boxRes, value);
    }
    
    public QuadraticEquationsViewModel()
    {
        this.PropertyChanged += OnPropertyChanged;
    }

    private void OnPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        
    }

    public double[] Equal()
    {
        double[] roots = new []{0.0, 0.0};
        double a, b, c, res = 0;
        double D = 0;
        Double.TryParse(_boxOne, out a);
        Double.TryParse(_boxTwo, out b);
        Double.TryParse(_boxThree, out c);
        Double.TryParse(_boxFourth, out res);

        c -= res;
        
        D = Math.Pow(b, 2) - 4 * a * c;

        roots[0] = (b * (-1) + Math.Sqrt(D))/(2 * a);
        roots[1] = (b * (-1) - Math.Sqrt(D))/(2 * a);

        return roots;
    }

    public void Result()
    {
        double[] roots = Equal();

        if (roots[0] == roots[1])
            BoxRes = "x = " + roots[0].ToString();
        else if (double.IsNaN(roots[0]) || double.IsNaN(roots[1]))
            BoxRes = "D < 0";
        else
            BoxRes = "x = " + roots[0].ToString() + "; " + roots[1].ToString();
    }
}
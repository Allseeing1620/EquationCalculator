using System.ComponentModel;
using EquationCalculator.ViewModels;
using ReactiveUI;

namespace EquationCalculator.Components;

public class LinearEquationsViewModel: ViewModelBase
{
    private int _x1LineOne = 0;
    private int _x2LineOne = 0;
    private int _x3LineOne = 0;
    
    private int _x1LineTwo = 0;
    private int _x2LineTwo = 0;
    private int _x3LineTwo = 0;
    
    private int _x1LineThree = 0;
    private int _x2LineThree = 0;
    private int _x3LineThree = 0;

    private int _equalFirstEquation = 0;
    private int _equalTwoEquation = 0;
    private int _equalThreeEquation = 0;
    private int _test;

    public int X1LineOne { 
        get => _x1LineOne;
        set => this.RaiseAndSetIfChanged(ref _x1LineOne, value);
    }
    public int X2LineOne { 
        get => _x2LineOne;
        set => this.RaiseAndSetIfChanged(ref _x2LineOne, value);
        
    }
    public int X3LineOne { 
        get => _x3LineOne;
        set => this.RaiseAndSetIfChanged(ref _x3LineOne, value);
        
    }
    
    public int EqualFirstEquation{
        get => _equalFirstEquation;
        set => this.RaiseAndSetIfChanged(ref _equalFirstEquation, value);
    }
    
    public int X1LineTwo { 
        get => _x1LineTwo;
        set => this.RaiseAndSetIfChanged(ref _x1LineTwo, value);
        
    }
    
    public int X2LineTwo { 
        get => _x2LineTwo;
        set => this.RaiseAndSetIfChanged(ref _x2LineTwo, value);
        
    }
    
    public int X3LineTwo { 
        get => _x3LineTwo;
        set => this.RaiseAndSetIfChanged(ref _x3LineTwo, value);
        
    }
    
    public int EqualTwoEquation {
        get => _equalTwoEquation;
        set => this.RaiseAndSetIfChanged(ref _equalTwoEquation, value);
    }
    
    public int X1LineThree { 
        get => _x1LineThree;
        set => this.RaiseAndSetIfChanged(ref _x1LineThree, value);
        
    }
    public int X2LineThree { 
        get => _x2LineThree;
        set => this.RaiseAndSetIfChanged(ref _x2LineThree, value);
        
    }
    public int X3LineThree {
        get => _x3LineThree;
        set => this.RaiseAndSetIfChanged(ref _x3LineThree, value);
    }
    
    public int EqualThreeEquation {
        get => _equalThreeEquation;
        set => this.RaiseAndSetIfChanged(ref _equalThreeEquation, value);
    }
    
    public int Test {
        get => _test;
        set => this.RaiseAndSetIfChanged(ref _test, value);
    }

    
    public LinearEquationsViewModel()
    {
        this.PropertyChanged += OnPropertyChanged;
    }

    private void OnPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        var test = EqualFirstEquation + X1LineOne;
        Test = test;
    }
    
}
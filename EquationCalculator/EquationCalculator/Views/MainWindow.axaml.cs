using System;
using System.Linq;
using Avalonia.Controls;
using EquationCalculator.Components;
using EquationCalculator.ViewModels;
using FluentAvalonia.UI.Controls;

namespace EquationCalculator.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        var nv = this.FindControl<NavigationView>("NavigationView");
        nv.SelectionChanged += OnNVSample2SelectionChanged;
    }
    
    protected override void OnOpened(EventArgs e)
    {
        base.OnOpened(e);
        var nv = this.FindControl<NavigationView>("NavigationView") ?? throw new NullReferenceException("NavigationView");
        nv.SelectedItem = nv.MenuItems.ElementAt(0);
    }
    
    private void OnNVSample2SelectionChanged(object sender, NavigationViewSelectionChangedEventArgs e)
    {
        if (e.SelectedItem is NavigationViewItem nvi)
        {
            var vm = DataContext as MainWindowViewModel;
            if(vm == null) return;

            if (sender is NavigationView navigationView)
            {
                switch (nvi.Tag)
                {
                    case "LinearEquations":
                        navigationView.Content = new LinearEquations { DataContext = vm.LinearEquationsViewModel };
                        break;
                    case "Matrices":
                        navigationView.Content = new Matrices { DataContext = vm.MatricesViewModel };
                        break;
                    case "Logarithm":
                        navigationView.Content = new LogarithmView { DataContext = vm.LogarithmViewModel };
                        break;
                    
                }
            }            
        }
    }
}
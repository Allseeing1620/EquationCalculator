using System;
using System.Collections.Generic;
using System.ComponentModel;
using EquationCalculator.ViewModels;
using ReactiveUI;

namespace EquationCalculator.Components;

public class MatricesViewModel: ViewModelBase
{
   
   private int _l1_0;
   public int[,] Matr = new int[3,3];
   private int _l3_2 = 0;
   private int _l3_1 = 0;
   private int _l3_0 = 0;
   private int _l2_2 = 0;
   private int _l2_1 = 0;
   private int _l2_0 = 0;
   private int _l1_2 = 0;
   private int _l1_1 = 0;


   public int L1_0 { 
      get => _l1_0;
      set => this.RaiseAndSetIfChanged(ref _l1_0, value);
   }
   public int L1_1 { 
      get => _l1_1;
      set => this.RaiseAndSetIfChanged(ref _l1_1, value);
   }
   public int L1_2 { 
      get => _l1_2;
      set => this.RaiseAndSetIfChanged(ref _l1_2, value);
   }
   public int L2_0 { 
      get => _l2_0;
      set => this.RaiseAndSetIfChanged(ref _l2_0, value);
   }
   public int L2_1{ 
      get => _l2_1;
      set => this.RaiseAndSetIfChanged(ref _l2_1, value);
   }
   public int L2_2{ 
      get => _l2_2;
      set => this.RaiseAndSetIfChanged(ref _l2_2, value);
   }
   public int L3_0 {
      get => _l3_0;
      set => this.RaiseAndSetIfChanged(ref _l3_0, value);
   }
   public int L3_1 { 
      get => _l3_1;
      set => this.RaiseAndSetIfChanged(ref _l3_1, value);
   }
   public int L3_2 { 
      get => _l3_2;
      set => this.RaiseAndSetIfChanged(ref _l3_2, value);
   }

   public MatricesViewModel()
   {
      this.PropertyChanged += OnPropertyChanged;
   }

   

   private void OnPropertyChanged(object? sender, PropertyChangedEventArgs e)
   {
      Matr[0, 0] = L1_0;
      Matr[0, 1] = L1_1;
      Matr[0, 2] = L1_2;
      Matr[1, 0] = L2_0;
      Matr[1, 1] = L2_1;
      Matr[1, 2] = L2_2;
      Matr[2, 0] = L3_0;
      Matr[2, 1] = L3_1;
      Matr[2, 2] = L3_2;
      Console.Write(Matr);
   }
}
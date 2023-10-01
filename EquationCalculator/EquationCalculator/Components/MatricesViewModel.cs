using System;
using System.Collections.Generic;
using System.ComponentModel;
using EquationCalculator.ViewModels;
using ReactiveUI;

namespace EquationCalculator.Components;

public class MatricesViewModel: ViewModelBase
{
   
   private int _l1_0;
   public  int[,] MatrixOne = new int[3,3];
   public  int[,] MatrixTwo = new int[3,3];
   public  int[,] MatrixResult = new int[3,3];
   private int _l3_2 = 0;
   private int _l3_1 = 0;
   private int _l3_0 = 0;
   private int _l2_2 = 0;
   private int _l2_1 = 0;
   private int _l2_0 = 0;
   private int _l1_2 = 0;
   private int _l1_1 = 0;
   private int _matricesTwo_L1_0;
   private int _matricesTwo_L1_1;
   private int _matrices_L1_0;
   private int _matrices_L3_2;
   private int _matrices_L1_1;
   private int _matrices_L1_2;
   private int _result_L2_0;
   private int _matrices_L2_0;
   private int _matrices_L2_1;
   private int _matrices_L2_2;
   private int _matrices_L3_0;
   private int _matrices_L3_1;
   private int _result_L3_1;
   private int _result_L1_0;
   private int _result_L1_1;
   private int _result_L1_2;
   private int _result_L3_0;
   private int _result_L3_2;
   private int _result_L2_2;
   private int _result_L2_1;
   private int _matricesTwo_L1_2;
   private int _matricesTwo_L3_2;
   private int _matricesTwo_L3_1;
   private int _matricesTwo_L3_0;
   private int _matricesTwo_L2_2;
   private int _matricesTwo_L2_0;
   private int _matricesTwo_L2_1;
   private string _sing = "+";


   public int  Matrices_L1_0 { 
      get => _matrices_L1_0;
      set => this.RaiseAndSetIfChanged(ref _matrices_L1_0, value);
   }
   public int  Matrices_L1_1 { 
      get => _matrices_L1_1;
      set => this.RaiseAndSetIfChanged(ref _matrices_L1_1, value);
   }
   public int  Matrices_L1_2 { 
      get => _matrices_L1_2;
      set => this.RaiseAndSetIfChanged(ref _matrices_L1_2, value);
   }
   public int  Matrices_L2_0 { 
      get => _matrices_L2_0;
      set => this.RaiseAndSetIfChanged(ref _matrices_L2_0, value);
   }
   public int  Matrices_L2_1{ 
      get => _matrices_L2_1;
      set => this.RaiseAndSetIfChanged(ref _matrices_L2_1, value);
   }
   public int  Matrices_L2_2{ 
      get => _matrices_L2_2;
      set => this.RaiseAndSetIfChanged(ref _matrices_L2_2, value);
   }
   public int  Matrices_L3_0 {
      get => _matrices_L3_0;
      set => this.RaiseAndSetIfChanged(ref _matrices_L3_0, value);
   }
   public int Matrices_L3_1 { 
      get => _matrices_L3_1;
      set => this.RaiseAndSetIfChanged(ref _matrices_L3_1, value);
   }
   public int  Matrices_L3_2 { 
      get => _matrices_L3_2;
      set => this.RaiseAndSetIfChanged(ref _matrices_L3_2, value);
   }

   public int ResultL10 { 
      get => _result_L1_0;
      set => this.RaiseAndSetIfChanged(ref _result_L1_0, value);
   }
   public int ResultL11 { 
      get => _result_L1_1;
      set => this.RaiseAndSetIfChanged(ref _result_L1_1, value);
   }
   public int ResultL12 { 
      get => _result_L1_2;
      set => this.RaiseAndSetIfChanged(ref _result_L1_2, value);
   }
   public int ResultL30 { 
      get => _result_L3_0;
      set => this.RaiseAndSetIfChanged(ref _result_L3_0, value);
   }
   public int ResultL31 { 
      get => _result_L3_1;
      set => this.RaiseAndSetIfChanged(ref _result_L3_1, value);
   }
   public int ResultL32 { 
      get => _result_L3_2;
      set => this.RaiseAndSetIfChanged(ref _result_L3_2, value);
   }
   public int ResultL22 { 
      get => _result_L2_2;
      set => this.RaiseAndSetIfChanged(ref _result_L2_2, value);
   }
   public int ResultL21 { 
      get => _result_L2_1;
      set => this.RaiseAndSetIfChanged(ref _result_L2_1, value);
   }
   public int ResultL20 {
      get => _result_L2_0;
      set => this.RaiseAndSetIfChanged(ref _result_L2_0, value);
   }
   public int MatricesTwo_L3_2 { 
      get => _matricesTwo_L3_2;
      set => this.RaiseAndSetIfChanged(ref _matricesTwo_L3_2, value);
   }
   public int MatricesTwo_L3_1 { 
      get => _matricesTwo_L3_1;
      set => this.RaiseAndSetIfChanged(ref _matricesTwo_L3_1, value);
   }
   public int MatricesTwo_L3_0 { 
      get => _matricesTwo_L3_0;
      set => this.RaiseAndSetIfChanged(ref _matricesTwo_L3_0, value);
   }
   public int MatricesTwo_L2_2 { 
      get => _matricesTwo_L2_2;
      set => this.RaiseAndSetIfChanged(ref _matricesTwo_L2_2, value);
   }
   public int MatricesTwo_L2_1 { 
      get => _matricesTwo_L2_1;
      set => this.RaiseAndSetIfChanged(ref _matricesTwo_L2_1, value);
   }
   public int MatricesTwo_L2_0 { 
      get => _matricesTwo_L2_0;
      set => this.RaiseAndSetIfChanged(ref _matricesTwo_L2_0, value);
   }
   public int MatricesTwo_L1_2 { 
      get => _matricesTwo_L1_2;
      set => this.RaiseAndSetIfChanged(ref _matricesTwo_L1_2, value);
   }
   public int MatricesTwo_L1_1 { 
      get => _matricesTwo_L1_1;
      set => this.RaiseAndSetIfChanged(ref _matricesTwo_L1_1, value);
   }
   public int MatricesTwo_L1_0 { 
      get => _matricesTwo_L1_0;
      set => this.RaiseAndSetIfChanged(ref _matricesTwo_L1_0, value);
   }
   
   public String Sign
   {
      get => _sing;
      set
      {
         if (value != _sing)
         {
            _sing = value;
            this.RaisePropertyChanged(nameof(SignIndex));
         }
      }
   }

   public int SignIndex
   {
      get
      {
         switch (Sign)
         {
            case "+":
               return 0;
            case "-":
               return 1;
            case "*":
               return 2;
            
            default:
               throw new ArgumentOutOfRangeException();
         }
      }
      set
      {
         switch (value)
         {
            case 0:
               Sign = "+";
               break;
            case 1:
               Sign = "-";
               break;
            case 2:
               Sign = "*";
               break;
            default:
               throw new ArgumentOutOfRangeException();
         }
      }
   }

   public MatricesViewModel()
   {
      this.PropertyChanged += OnPropertyChanged;
   }

   
   private void OnPropertyChanged(object? sender, PropertyChangedEventArgs e)
   {
      MatrixOne[0, 0] =  Matrices_L1_0;
      MatrixOne[0, 1] =  Matrices_L1_1;
      MatrixOne[0, 2] =  Matrices_L1_2;
      MatrixOne[1, 0] =  Matrices_L2_0;
      MatrixOne[1, 1] =  Matrices_L2_1;
      MatrixOne[1, 2] =  Matrices_L2_2;
      MatrixOne[2, 0] =  Matrices_L3_0;
      MatrixOne[2, 1] =  Matrices_L3_1;
      MatrixOne[2, 2] =  Matrices_L3_2;
      
      MatrixTwo[0, 0] =  MatricesTwo_L1_0;
      MatrixTwo[0, 1] =  MatricesTwo_L1_1;
      MatrixTwo[0, 2] =  MatricesTwo_L1_2;
      MatrixTwo[1, 0] =  MatricesTwo_L2_0;
      MatrixTwo[1, 1] =  MatricesTwo_L2_1;
      MatrixTwo[1, 2] =  MatricesTwo_L2_2;
      MatrixTwo[2, 0] =  MatricesTwo_L3_0;
      MatrixTwo[2, 1] =  MatricesTwo_L3_1;
      MatrixTwo[2, 2] =  MatricesTwo_L3_2;
      
      IdentifySign(Sign);

   }

   private void IdentifySign(string sing)
   {
      switch (sing)
      {
         case "+":
            Sum();
            break;
         case "-":
            Difference();
            break;
         case "*" :
            Multiplication();
            break;
      }
   }

   private void Sum()
   {
      for (int i = 0; i < 2; i++)
      for (int j = 0; j < 2; j++) {
         MatrixResult[i, j] = MatrixOne[i, j] + MatrixTwo[i, j];
      }            
   }

   private void Difference()
   {
      for (int i = 0; i < 2; i++)
         for (int j = 0; j < 2; j++) {
            MatrixResult[i, j] = MatrixOne[i, j] - MatrixTwo[i, j];
         }
   }
   
   private void Multiplication()
   {
      for (int i = 0; i < MatrixOne.GetLength(0); i++)
      {
         for (int j = 0; j < MatrixTwo.GetLength(1); j++)
         {
            for (int k = 0; k < MatrixTwo.GetLength(0); k++)
            {
               MatrixResult[i,j] += MatrixOne[i,k] * MatrixTwo[k,j];
            }
         }
      }
      
   }
   
   public void Result()
   {
      ResultL10 = MatrixResult[0, 0];
      ResultL11 = MatrixResult[0, 1];
      ResultL12 = MatrixResult[0, 2];
      ResultL20 = MatrixResult[1, 0];
      ResultL21 = MatrixResult[1, 1];
      ResultL22 = MatrixResult[1, 2];
      ResultL30 = MatrixResult[2, 0];
      ResultL31 = MatrixResult[2, 1];
      ResultL32 = MatrixResult[2, 2];
   }
   
}
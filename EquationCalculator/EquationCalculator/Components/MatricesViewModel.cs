using System;
using System.Collections.Generic;
using System.ComponentModel;
using EquationCalculator.ViewModels;
using ReactiveUI;

namespace EquationCalculator.Components;

public class MatricesViewModel: ViewModelBase
{
   public  int[,] MatrixOne = new int[3,3];
   public  int[,] MatrixTwo = new int[3,3];
   public  int[,] MatrixResult = new int[3,3];
   
   private int _l1_0 = 0;
   private int _l3_2 = 0;
   private int _l3_1 = 0;
   private int _l3_0 = 0;
   private int _l2_2 = 0;
   private int _l2_1 = 0;
   private int _l2_0 = 0;
   private int _l1_2 = 0;
   private int _l1_1 = 0;
   
   private string _matrices_L1_0 = "0";
   private string _matrices_L1_1 = "0";
   private string _matrices_L1_2 = "0";
   private string _matrices_L2_0 = "0";
   private string _matrices_L2_1 = "0";
   private string _matrices_L2_2 = "0";
   private string _matrices_L3_0 = "0";
   private string _matrices_L3_1 = "0";
   private string _matrices_L3_2 = "0";
   
   private string _matricesTwo_L1_0 = "0";
   private string _matricesTwo_L1_1 = "0";
   private string _matricesTwo_L1_2 = "0";
   private string _matricesTwo_L3_0 = "0";
   private string _matricesTwo_L3_1 = "0";
   private string _matricesTwo_L3_2 = "0";
   private string _matricesTwo_L2_0 = "0";
   private string _matricesTwo_L2_1 = "0";
   private string _matricesTwo_L2_2 = "0";
   
   private int _result_L1_0;
   private int _result_L1_1;
   private int _result_L1_2;
   private int _result_L2_0;
   private int _result_L2_1;
   private int _result_L2_2;
   private int _result_L3_0;
   private int _result_L3_1;
   private int _result_L3_2;
   
   
   
   private string _sing = "+";


   public string  Matrices_L1_0 { 
      get => _matrices_L1_0;
      set => this.RaiseAndSetIfChanged(ref _matrices_L1_0, value);
   }
   public string  Matrices_L1_1 { 
      get => _matrices_L1_1;
      set => this.RaiseAndSetIfChanged(ref _matrices_L1_1, value);
   }
   public string  Matrices_L1_2 { 
      get => _matrices_L1_2;
      set => this.RaiseAndSetIfChanged(ref _matrices_L1_2, value);
   }
   public string  Matrices_L2_0 { 
      get => _matrices_L2_0;
      set => this.RaiseAndSetIfChanged(ref _matrices_L2_0, value);
   }
   public string  Matrices_L2_1{ 
      get => _matrices_L2_1;
      set => this.RaiseAndSetIfChanged(ref _matrices_L2_1, value);
   }
   public string  Matrices_L2_2{ 
      get => _matrices_L2_2;
      set => this.RaiseAndSetIfChanged(ref _matrices_L2_2, value);
   }
   public string  Matrices_L3_0 {
      get => _matrices_L3_0;
      set => this.RaiseAndSetIfChanged(ref _matrices_L3_0, value);
   }
   public string Matrices_L3_1 { 
      get => _matrices_L3_1;
      set => this.RaiseAndSetIfChanged(ref _matrices_L3_1, value);
   }
   public string  Matrices_L3_2 { 
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
   public string MatricesTwo_L3_2 { 
      get => _matricesTwo_L3_2;
      set => this.RaiseAndSetIfChanged(ref _matricesTwo_L3_2, value);
   }
   public string MatricesTwo_L3_1 { 
      get => _matricesTwo_L3_1;
      set => this.RaiseAndSetIfChanged(ref _matricesTwo_L3_1, value);
   }
   public string MatricesTwo_L3_0 { 
      get => _matricesTwo_L3_0;
      set => this.RaiseAndSetIfChanged(ref _matricesTwo_L3_0, value);
   }
   public string MatricesTwo_L2_2 { 
      get => _matricesTwo_L2_2;
      set => this.RaiseAndSetIfChanged(ref _matricesTwo_L2_2, value);
   }
   public string MatricesTwo_L2_1 { 
      get => _matricesTwo_L2_1;
      set => this.RaiseAndSetIfChanged(ref _matricesTwo_L2_1, value);
   }
   public string MatricesTwo_L2_0 { 
      get => _matricesTwo_L2_0;
      set => this.RaiseAndSetIfChanged(ref _matricesTwo_L2_0, value);
   }
   public string MatricesTwo_L1_2 { 
      get => _matricesTwo_L1_2;
      set => this.RaiseAndSetIfChanged(ref _matricesTwo_L1_2, value);
   }
   public string MatricesTwo_L1_1 { 
      get => _matricesTwo_L1_1;
      set => this.RaiseAndSetIfChanged(ref _matricesTwo_L1_1, value);
   }
   public string MatricesTwo_L1_0 { 
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
      Int32.TryParse(Matrices_L1_0, out MatrixOne[0, 0]);
      Int32.TryParse(Matrices_L1_1, out MatrixOne[0, 1]);
      Int32.TryParse(Matrices_L1_2, out MatrixOne[0, 2]);
      Int32.TryParse(Matrices_L2_0, out MatrixOne[1, 0]);
      Int32.TryParse(Matrices_L2_1, out MatrixOne[1, 1]);
      Int32.TryParse(Matrices_L2_2, out MatrixOne[1, 2]);
      Int32.TryParse(Matrices_L3_0, out MatrixOne[2, 0]);
      Int32.TryParse(Matrices_L3_1, out MatrixOne[2, 1]);
      Int32.TryParse(Matrices_L3_2, out MatrixOne[2, 2]);
   
      Int32.TryParse(MatricesTwo_L1_0, out MatrixTwo[0, 0]);
      Int32.TryParse(MatricesTwo_L1_1, out MatrixTwo[0, 1]);
      Int32.TryParse(MatricesTwo_L1_2, out MatrixTwo[0, 2]);
      Int32.TryParse(MatricesTwo_L2_0, out MatrixTwo[1, 0]);
      Int32.TryParse(MatricesTwo_L2_1, out MatrixTwo[1, 1]);
      Int32.TryParse(MatricesTwo_L2_2, out MatrixTwo[1, 2]);
      Int32.TryParse(MatricesTwo_L3_0, out MatrixTwo[2, 0]);
      Int32.TryParse(MatricesTwo_L3_1, out MatrixTwo[2, 1]);
      Int32.TryParse(MatricesTwo_L3_2, out MatrixTwo[2, 2]);
      
      IdentifySign(Sign);

   }

   private void IdentifySign(string sing)
   {
      Array.Clear(MatrixResult, 0, MatrixResult.Length);
      
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
      for (int i = 0; i < 3; i++)
      {
         for (int j = 0; j < 3; j++)
         {
            MatrixResult[i, j] = MatrixOne[i, j] + MatrixTwo[i, j];
         }
      }
   }

   private void Difference()
   {  
      for (int i = 0; i < 3; i++)
         for (int j = 0; j < 3; j++) {
            MatrixResult[i, j] = MatrixOne[i, j] - MatrixTwo[i, j];
         }
   }
   
   private void Multiplication()
   {
      for (int i = 0; i < 3; i++)
      {
         for (int j = 0; j < 3; j++)
         {
            for (int k = 0; k < 3; k++)
            {
               MatrixResult[i, j] += MatrixOne[i, k] * MatrixTwo[k, j];
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

   public int[, ] Transpose(int [, ] Matr)
   {
      int buf = 0;
      
      for (int i = 0; i < 3; i++)
      {
         for (int j = i; j < 3; j++)
         {
            buf = Matr[i, j];
            Matr[i, j] = Matr[j, i];
            Matr[j, i] = buf;
         }
      }

      return Matr;
   }

   public void TransposeOne()
   {
      int[,] matr = Transpose(MatrixOne);

      Matrices_L1_0 = matr[0, 0].ToString();
      Matrices_L1_1 = matr[0, 1].ToString();
      Matrices_L1_2 = matr[0, 2].ToString();
      Matrices_L2_0 = matr[1, 0].ToString();
      Matrices_L2_1 = matr[1, 1].ToString();
      Matrices_L2_2 = matr[1, 2].ToString();
      Matrices_L3_0 = matr[2, 0].ToString();
      Matrices_L3_1 = matr[2, 1].ToString();
      Matrices_L3_2 = matr[2, 2].ToString();
   }
   
   public void TransposeTwo()
   {
      int[,] matr = Transpose(MatrixTwo);
      
      MatricesTwo_L1_0 = matr[0, 0].ToString();
      MatricesTwo_L1_1 = matr[0, 1].ToString();
      MatricesTwo_L1_2 = matr[0, 2].ToString();
      MatricesTwo_L2_0 = matr[1, 0].ToString();
      MatricesTwo_L2_1 = matr[1, 1].ToString();
      MatricesTwo_L2_2 = matr[1, 2].ToString();
      MatricesTwo_L3_0 = matr[2, 0].ToString();
      MatricesTwo_L3_1 = matr[2, 1].ToString();
      MatricesTwo_L3_2 = matr[2, 2].ToString();
   }
}
using EquationCalculator.Components;

namespace EquationCalculator.Tests;

public class MatricesUnitTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void SumMatrices_test()
    {
        MatricesViewModel matricesViewModel = new MatricesViewModel();
        matricesViewModel.MatrixOne[0, 0] = 1;
        matricesViewModel.MatrixOne[0, 1] = 2;
        matricesViewModel.MatrixOne[0, 2] = 3;
        matricesViewModel.MatrixOne[1, 0] = 4;
        matricesViewModel.MatrixOne[1, 1] = 5;
        matricesViewModel.MatrixOne[1, 2] = 6;
        matricesViewModel.MatrixOne[2, 0] = 7;
        matricesViewModel.MatrixOne[2, 1] = 8;
        matricesViewModel.MatrixOne[2, 2] = 9;
        
        matricesViewModel.MatrixTwo[0, 0] = 9;
        matricesViewModel.MatrixTwo[0, 1] = 8;
        matricesViewModel.MatrixTwo[0, 2] = 7;
        matricesViewModel.MatrixTwo[1, 0] = 6;
        matricesViewModel.MatrixTwo[1, 1] = 5;
        matricesViewModel.MatrixTwo[1, 2] = 4;
        matricesViewModel.MatrixTwo[2, 0] = 3;
        matricesViewModel.MatrixTwo[2, 1] = 2;
        matricesViewModel.MatrixTwo[2, 2] = 1;
        matricesViewModel.Sum();
        int[, ] exm =  {{10, 10, 10}, 
                        {10, 10, 10}, 
                        {10, 10, 10}};
        Assert.That(matricesViewModel.MatrixResult, Is.EqualTo(exm));
    }
    
    [Test]
    public void DiffMatrices_test()
    {
        MatricesViewModel matricesViewModel = new MatricesViewModel();
        matricesViewModel.MatrixOne[0, 0] = 1;
        matricesViewModel.MatrixOne[0, 1] = 2;
        matricesViewModel.MatrixOne[0, 2] = 3;
        matricesViewModel.MatrixOne[1, 0] = 4;
        matricesViewModel.MatrixOne[1, 1] = 5;
        matricesViewModel.MatrixOne[1, 2] = 6;
        matricesViewModel.MatrixOne[2, 0] = 7;
        matricesViewModel.MatrixOne[2, 1] = 8;
        matricesViewModel.MatrixOne[2, 2] = 9;
        
        matricesViewModel.MatrixTwo[0, 0] = 1;
        matricesViewModel.MatrixTwo[0, 1] = 0;
        matricesViewModel.MatrixTwo[0, 2] = 0;
        matricesViewModel.MatrixTwo[1, 0] = 2;
        matricesViewModel.MatrixTwo[1, 1] = 0;
        matricesViewModel.MatrixTwo[1, 2] = 0;
        matricesViewModel.MatrixTwo[2, 0] = 3;
        matricesViewModel.MatrixTwo[2, 1] = 0;
        matricesViewModel.MatrixTwo[2, 2] = 0;
        matricesViewModel.Difference();
        int[, ] exm =  {{0, 2, 3},
                        {2, 5, 6},
                        {4, 8, 9}};
        Assert.That(matricesViewModel.MatrixResult, Is.EqualTo(exm));
    }
}
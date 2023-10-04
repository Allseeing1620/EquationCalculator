using EquationCalculator.Components;

namespace EquationCalculator.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ResultLogarithm_test()
    {
        LogarithmViewModel logarithmViewModel = new LogarithmViewModel();
        logarithmViewModel.BaseLogarithm = "10";
        logarithmViewModel.ValueLogarithm = "5";
        logarithmViewModel.Result();
        var exm = "0,70";
        Assert.AreEqual(exm,logarithmViewModel.ResultValue);
    }
}
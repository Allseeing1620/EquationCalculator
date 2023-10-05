using EquationCalculator.Components;

namespace EquationCalculator.Tests;

public class LogarithmTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ResultLogarithm_test()
    {
        LogarithmViewModel logarithmViewModel = new LogarithmViewModel();
        logarithmViewModel.BaseLogarithm = "2";
        logarithmViewModel.ValueLogarithm = "64";
        logarithmViewModel.Result();
        var exm = "6.00";
        Assert.AreEqual(exm,logarithmViewModel.ResultValue);
    }
}
using EquationCalculator.Components;

namespace EquationCalculator.Tests;

public class QuadraticUnitTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void EqualQuadratic_test()
    {
        QuadraticEquationsViewModel quadraticEquationsView = new QuadraticEquationsViewModel();
        quadraticEquationsView.BoxOne = "1";
        quadraticEquationsView.BoxTwo = "4";
        quadraticEquationsView.BoxThree = "-5";
        quadraticEquationsView.BoxFourth = "0";
        quadraticEquationsView.Result();
        var fin = "x = 1; -5";
        Assert.That(quadraticEquationsView.BoxRes, Is.EqualTo(fin));
    }
}
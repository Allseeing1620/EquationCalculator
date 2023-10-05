using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EquationCalculator.Components;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace EquationCalculator.Spec.Steps;

[Binding]
public sealed class MatricesStepDefinition
{
    // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

    private readonly ScenarioContext _scenarioContext;
    private readonly MatricesViewModel _matricesViewModel = new MatricesViewModel();
    private int[,] _result;
    private string sign;
    
    public MatricesStepDefinition(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    public int[,] ParseString(string matr)
    {
        int[,] res = new int[3, 3];
        string[] buf = matr.Split("|");
        string[] line = buf[0].Split(",");
        res[0, 0] = Int32.Parse(line[0]);
        res[0, 1] = Int32.Parse(line[1]);
        res[0, 2] = Int32.Parse(line[2]);
        line = buf[1].Split(",");
        res[1, 0] = Int32.Parse(line[0]);
        res[1, 1] = Int32.Parse(line[1]);
        res[1, 2] = Int32.Parse(line[2]);
        line = buf[2].Split(",");
        res[2, 0] = Int32.Parse(line[0]);
        res[2, 1] = Int32.Parse(line[1]);
        res[2, 2] = Int32.Parse(line[2]);

        return res;
    }

    [Given("the first matrice is (.*)")]
    public void GivenTheFirstMatriceIs(string matr)
    {
        //TODO: implement arrange (precondition) logic
        // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata 
        // To use the multiline text or the table argument of the scenario,
        // additional string/Table parameters can be defined on the step definition
        // method. 
        _matricesViewModel.MatrixOne = ParseString(matr);
    }

    [Given("the second matrice is (.*)")]
    public void GivenTheSecondMatriceIs(string matr)
    {
        //TODO: implement arrange (precondition) logic
        // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata 
        // To use the multiline text or the table argument of the scenario,
        // additional string/Table parameters can be defined on the step definition
        // method. 
        _matricesViewModel.MatrixTwo = ParseString(matr);
    }
    
    [Given("the sign is (.*)")]
    public void SignIs(string sign)
    {
        //TODO: implement arrange (precondition) logic
        // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata 
        // To use the multiline text or the table argument of the scenario,
        // additional string/Table parameters can be defined on the step definition
        // method. 

        this.sign = sign;
    }

    [When("the two matrices are added")]
    public void WhenTheTwoMatricesAreAdded()
    {
        //TODO: implement act (action) logic

        if (this.sign == "+")
            _matricesViewModel.Sum();
        else if (this.sign == "-")
            _matricesViewModel.Difference();
        else if (this.sign == "*")
            _matricesViewModel.Multiplication();
        
        _result = _matricesViewModel.MatrixResult;
    }

    [Then("the result of equation should be (.*)")]
    public void ThenTheResultShouldBe(string matr)
    {
        //TODO: implement assert (verification) logic
        int[,] res = ParseString(matr);
        
        Assert.AreEqual(res, _result);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EquationCalculator.Components;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace EquationCalculator.Spec.Steps;

[Binding]
public sealed class QuadraticStepDefinition
{
    // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

    private readonly ScenarioContext _scenarioContext;
    private readonly QuadraticEquationsViewModel _matricesViewModel = new QuadraticEquationsViewModel();
    private string res;

    public QuadraticStepDefinition(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [Given("the a is (.*)")]
    public void GivenTheA(int number)
    {
        //TODO: implement arrange (precondition) logic
        // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata 
        // To use the multiline text or the table argument of the scenario,
        // additional string/Table parameters can be defined on the step definition
        // method. 

        _matricesViewModel.BoxOne = number.ToString();
    }

    [Given("the b is (.*)")]
    public void GivenTheB(int number)
    {
        //TODO: implement arrange (precondition) logic
        // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata 
        // To use the multiline text or the table argument of the scenario,
        // additional string/Table parameters can be defined on the step definition
        // method. 

        _matricesViewModel.BoxTwo = number.ToString();
    }
    
    [Given("the c is (.*)")]
    public void GivenTheC(int number)
    {
        //TODO: implement arrange (precondition) logic
        // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata 
        // To use the multiline text or the table argument of the scenario,
        // additional string/Table parameters can be defined on the step definition
        // method. 

        _matricesViewModel.BoxThree = number.ToString();
    }

    [When("Quadratic equation are solved")]
    public void WhenTheQuadraticEquationAreSolved()
    {
        //TODO: implement act (action) logic

        _matricesViewModel.Result();
        res = _matricesViewModel.BoxRes;
    }
    
    [When("Discriminant are solved")]
    public void WhenTheDiscriminantSolved()
    {
        //TODO: implement act (action) logic

        res = _matricesViewModel.Discriminant(1, 4, -5).ToString();
    }

    [Then("the x should be (.*)")]
    public void ThenTheXShouldBe(string result)
    {
        //TODO: implement assert (verification) logic

        Assert.AreEqual(result, res);
    }
    
    [Then("the D should be (.*)")]
    public void ThenTheDShouldBe(string result)
    {
        //TODO: implement assert (verification) logic

        Assert.AreEqual(result, res);
    }
}
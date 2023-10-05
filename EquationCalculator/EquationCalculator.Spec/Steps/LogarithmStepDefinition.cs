using EquationCalculator.Components;
using NUnit.Framework;
using Xunit;

namespace EquationCalculator.Spec.Steps;

[Binding]
public sealed class LogarithmStepDefinitions
{
    // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

    private readonly ScenarioContext _scenarioContext;
    private readonly LogarithmViewModel _logarithmViewModel = new LogarithmViewModel();
    private string _result;
   

    public LogarithmStepDefinitions(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [Given("the base is (.*)")]
    public void GivenTheBase(int number)
    {
        //TODO: implement arrange (precondition) logic
        // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
        // To use the multiline text or the table argument of the scenario,
        // additional string/Table parameters can be defined on the step definition
        // method. 

        _logarithmViewModel.BaseLogarithm = number.ToString();
    }

    [Given("the value is (.*)")]
    public void GivenTheValue(int number)
    {
        //TODO: implement arrange (precondition) logic
        // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
        // To use the multiline text or the table argument of the scenario,
        // additional string/Table parameters can be defined on the step definition
        // method. 

        _logarithmViewModel.ValueLogarithm = number.ToString();
    }

    [When("the base and value are added")]
    public void WhenTheBaseAndValueAreAdded()
    {
        //TODO: implement act (action) logic
        _logarithmViewModel.Result();

        _result = _logarithmViewModel.ResultValue;
    }

    [Then("the result of should be (.*)")]
    public void ThenTheResultShouldBe(string result)
    {
        //TODO: implement assert (verification) logic
        Assert.AreEqual(result, _result);
        
    }
}
using System;
using TechTalk.SpecFlow;

namespace SpecFlow3Net5
{
    [Binding]
    public class StepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;

        public StepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
    
        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
        }
    }
}

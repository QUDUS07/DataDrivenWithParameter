using System;
using TechTalk.SpecFlow;

namespace DataDrivenWithParameterProject.StepDefinitions
{
    [Binding]
    public class DataDrivenWithParameterStepDefinitions
    {
        DataDrivenWithParameterStepDefinitions dataDrivenWithParameter;
        public DataDrivenWithParameterStepDefinitions()
        {
            dataDrivenWithParameter = new DataDrivenWithParameterStepDefinitions();
        }









        [Given(@"I navigate to ""([^""]*)""")]
        public void NavigateTo(string url)
        {
            dataDrivenWithParameter.NavigateTo(url);
        }

        [Given(@"I click on Sign up")]
        public void ClickOnSignUp()
        {
            dataDrivenWithParameter.ClickOnSignUp();
        }

        [Given(@"I enter Username ""([^""]*)""")]
        public void EnterUsername(string username)
        {
            dataDrivenWithParameter.EnterUsername(username);
        }

        [Given(@"I enter Email ""([^""]*)""")]
        public void EnterEmail(string email)
        {
            dataDrivenWithParameter.EnterEmail(email);
        }

        [Given(@"I enter password ""([^""]*)""")]
        public void Password(string password)
        {
            dataDrivenWithParameter.Password(password);
        }

        [When(@"I click on the sign up botton")]
        public void ClickOnTheSignUpBotton()
        {
            dataDrivenWithParameter.ClickOnTheSignUpBotton();
        }

        [Then(@"I should be able to register successfully")]
        public void IsNewArticleDisplaced()
        {
            dataDrivenWithParameter.IsNewArticleDisplaced();
        }
    }
}

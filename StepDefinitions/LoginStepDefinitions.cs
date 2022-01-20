using PracticeProject.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace PracticeProject.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        LoginPage loginPage = new LoginPage();

        [Given(@"the user navigates to the website ""([^""]*)""")]
        public void GivenTheUserNavigatesToTheWebsite(string url)
        {
            loginPage.Navigate(url);
        }

        [When(@"the user enters valid email ""([^""]*)""")]
        public void WhenTheUserEntersValidEmail(string emailtext)
        {
            loginPage.EnterEmail(emailtext);
        }

        [When(@"the user enters valid password ""([^""]*)""")]
        public void WhenTheUserEntersValidPassword(string passwordtext)
        {
            loginPage.EnterPassword(passwordtext); 
        }

        [When(@"the user clicks the Let's go button")]
        public void WhenTheUserClicksTheLetsGoButton()
        {
           loginPage.ClickButton();
        }

        [Then(@"the user is successfully logged in")]
        public void ThenTheUserIsSuccessfullyLoggedIn()
        {
            
        }

        [Then(@"user enters job title ""([^""]*)""")]
        public void ThenUserEntersJobTitle(string jobtitletext)
        {
            loginPage.EnterJobTitle(jobtitletext);
        }

        [Then(@"user selects job category")]
        public void ThenUserSelectsJobCategory()
        {
            loginPage.SelectJobCategory();
        }

        [Then(@"user enters describtion ""([^""]*)""")]
        public void ThenUserEntersDescribtion(string automationTester)
        {
           loginPage.EnterDescription(automationTester);
        }

        [Then(@"user selects working pattern")]
        public void ThenUserSelectsWorkingPattern()
        {
            
        }


        [Then(@"user enters dress code""([^""]*)""")]
        public void ThenUserEntersDressCode(string smart)
        {
          loginPage.EnterDressCode(smart);  
        }

        [Then(@"user selects experience level")]
        public void ThenUserSelectsExperienceLevel()
        {
           loginPage.SelectExperienceLevel();
        }


        [Then(@"user enters name""([^""]*)""")]
        public void ThenUserEntersName(string gerald)
        {
            
        }

        [Then(@"user enters mobile number")]
        public void ThenUserEntersMobileNumber()
        {
            
        }

        [Then(@"user enters arrival instructions""CallGerald")]
        public void ThenUserEntersArrivalInstructionsCallGerald()
        {
            
        }

        [Then(@"user clicks next")]
        public void ThenUserClicksNext()
        {
            
        }
    }
}

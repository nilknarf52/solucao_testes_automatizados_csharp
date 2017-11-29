using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Testing.ToolsQA
{
    [Binding]
    public class LogIn_Steps
    {
        private IWebDriver driver;

        [Given(@"User is at the Home Page")]
        public void GivenUserIsAtTheHomePage()
        {
            BrowserFactory.StartDriver("Chrome");
            BrowserFactory.OpenUrl("http://www.store.demoqa.com/");
            driver = BrowserFactory.Driver;
        }

        [Given(@"Navigate to LogIn Page")]
        public void GivenNavigateToLogInPage()
        {
            driver.FindElement(By.XPath(".//*[@id='account']/a")).Click();
        }
        
        [When(@"User enter(.*) and(.*)")]
        public void WhenUserEnterAnd(string username, string password)
        {
            driver.FindElement(By.Id("log")).SendKeys(username);
            driver.FindElement(By.Id("pwd")).SendKeys(password);
        }

        [When(@"Click on the LogIn button")]
        public void WhenClickOnTheLogInButton()
        {
            driver.FindElement(By.Id("login")).Click();
        }
        
        [When(@"User LogOut from the Application")]
        public void WhenUserLogOutFromTheApplication()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Successful LogIN message should display")]
        public void ThenSuccessfulLogINMessageShouldDisplay()
        {
            //This Checks that if the LogOut button is displayed
            true.Equals(driver.FindElement(By.XPath(".//*[@id='account_logout']/a")).Displayed);
        }

        [Then(@"Successful LogOut message should display")]
        public void ThenSuccessfulLogOutMessageShouldDisplay()
        {
            ScenarioContext.Current.Pending();
        }
    }
}

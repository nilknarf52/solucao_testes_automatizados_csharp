using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;


namespace Testing
{
    public static class BrowserFactory
    {
        private static IWebDriver _driver;
        private static string _browser;

        public static IWebDriver Driver
        {
            get
            {
                if (_driver == null)
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method StartDriver.");
                return _driver;
            }
            private set
            {
                _driver = value;
            }
        }

        public static string BroserInfo
        {
            get { return _browser; }
        }

        public static void StartDriver(string browser)
        {
            switch (browser)
            {
                case "Chrome":
                default:
                    var options = new ChromeOptions();
                    options.AddArguments(
                        "start-maximized",
                        "--disable-infobars");
                    options.AddUserProfilePreference("credentials_enable_service", false);
                    options.AddUserProfilePreference("profile.password_manager_enabled", false);
                    _driver = new ChromeDriver(options);
                    break;
            }
            _browser = browser + " (" + ((RemoteWebDriver)_driver).Capabilities.Version + ")";
        }
        
        public static void OpenUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
            WaitPageLoad();
        }

        public static void WaitPageLoad()
        {
            IWait<IWebDriver> wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            wait.Until(drv => ((IJavaScriptExecutor)_driver).ExecuteScript("return document.readyState").Equals("complete"));
        }

        public static void CloseDriver()
        {
            _driver.Close();
            _driver.Quit();
        }
    }
}

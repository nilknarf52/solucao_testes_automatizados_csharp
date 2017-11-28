//using NUnit.Framework;
//using OpenQA.Selenium;

//namespace Selenium
//{
//    [TestFixture]
//    public class TestClass
//    {
//        private IWebDriver _driver;

//        [OneTimeSetUp]
//        public void SetUp()
//        {
//            BrowserFactory.StartDriver("Chrome");
//            BrowserFactory.OpenUrl("https://paulofachini.github.io/");
//            _driver = BrowserFactory.Driver;
//        }

//        [Test]
//        public void TestCase()
//        {
//            IWebElement helloworld = _driver.FindElement(By.Id("helloworld"));
//            bool achou = helloworld.Text.Contains("Hello World");
//            Assert.IsTrue(achou);
//        }

//        [OneTimeTearDown]
//        public void TearDown()
//        {
//            BrowserFactory.CloseDriver();
//        }
//    }
//}

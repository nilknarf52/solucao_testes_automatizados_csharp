using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    [TestFixture]
    public class TestClass
    {
        static IWebDriver _driver;

        [OneTimeSetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Url = "https://paulofachini.github.io/";
        }

        [Test]
        public void TestCase()
        {
            IWebElement helloworld = _driver.FindElement(By.Id("helloworld"));
            bool achou = helloworld.Text.Contains("Hello World");
            Assert.IsTrue(achou);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _driver.Close();
            _driver.Quit();
        }
    }
}

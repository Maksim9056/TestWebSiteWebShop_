using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace TestWebSiteWebShop_
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            var edgeOptions = new EdgeOptions();
            IWebDriver driver = new EdgeDriver(@"C:\edgedriver_win64\msedgedriver.exe", edgeOptions);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl("https://localhost:7224/");
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}
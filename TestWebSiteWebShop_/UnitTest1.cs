using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using TestWebSiteWebShop_.Pages.Buy;
using TestWebSiteWebShop_.Pages.Main;

namespace TestWebSiteWebShop_
{
    public class Tests
    {
        [Test]
        public void Setup()
        {
            var edgeOptions = new EdgeOptions();
            IWebDriver driver = new EdgeDriver(@"C:\edgedriver_win64\msedgedriver.exe", edgeOptions);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl("https://localhost:7224/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));


            Main main = new Main();
            main.Parameth(wait);
            main.Click();
            Buy buy = new Buy();

            buy.Parameth(wait);
            buy.CheckBeforeClick();
            driver.Close();
        }

    }
}
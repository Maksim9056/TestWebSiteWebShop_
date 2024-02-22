using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using TestWebSiteWebShop_.Pages.Buy;
using TestWebSiteWebShop_.Pages.Filler;
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
            Filter filter = new Filter();
            Buy buy = new Buy();
            main.Parameth(wait);
           

            filter.ParamethFilter(wait);
            filter.FilterAuther();
            filter.ButtonClick();
            filter.ButtonClickAll();
            filter.FilterName();
            filter.ButtonClick();
            filter.ButtonClickAll();

            filter.FilterName2();
            filter.ButtonClick();
            filter.ButtonClickAll();
            main.Click();


            buy.Parameth(wait);
            buy.CheckBeforeClick();


            main.Click2();
            buy.CheckBeforeClick();
            main.Click3();
            buy.CheckBeforeClick();

            main.Click4();
            buy.CheckBeforeClick();

            main.Click5();
            buy.CheckBeforeClick();


            driver.Close();
        }

    }
}
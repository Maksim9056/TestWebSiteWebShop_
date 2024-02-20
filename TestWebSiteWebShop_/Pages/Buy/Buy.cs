using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWebSiteWebShop_.Pages.Buy
{
    public class Buy
    {
        public string LinkText = "ВЫСОКО-НАГРУЖЕННЫЕ ПРИЛОЖЕНИЯ:";
        public string Auther = "Мартин:";
        public string cssSelectorForAutherMartin = "body:nth-child(2) form:nth-child(1) div:nth-child(2) > label:nth-child(1)";
        public string cssSelector = "body:nth-child(2) > form:nth-child(1)";
        public string cssSelectorBuy = "body > form > button";
        public WebDriverWait wait { get; set; }

        public void Parameth(WebDriverWait driver)
        {

            wait = driver;
        }

        [Test]
        public void CheckBeforeClick()
        {
            IWebElement searchBox = wait.Until(d => d.FindElement(By.CssSelector(cssSelectorBuy)));
            searchBox.Click();
            //Assert.IsTrue(searchBox.Text == LinkText);

            ////searchBox = wait.Until(d => d.FindElement(By.CssSelector(cssSelectorForAutherMartin)));
            //Assert.IsTrue(searchBox.Text == Auther);

        }

    }
}

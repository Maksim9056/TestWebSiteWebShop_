using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWebSiteWebShop_.Pages.Main
{
    public class Main
    {
        public string LinkText = "ВЫСОКО-НАГРУЖЕННЫЕ ПРИЛОЖЕНИЯ";
        public WebDriverWait wait { get; set; }

        public void Parameth(WebDriverWait driver)
        {

            wait = driver;
        }

        [Test]
        public void Click()
        {
            IWebElement searchBox = wait.Until(d => d.FindElement(By.LinkText(LinkText)));
            Assert.IsTrue(searchBox.Text == LinkText);
            searchBox.Click();

        }

        [Test]
        public void Click2()
        {


        }
    }
}

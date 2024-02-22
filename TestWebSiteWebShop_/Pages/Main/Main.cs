using NUnit.Framework.Internal;
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
        public string LinkText2 = ".Selenium.WebDriver.Recipes in C#";
        public string LinkText3 = "ASP.NET 8 Best Practices";
        public string LinkText4 = "Apress.Practical.GraphQL.";
        public string LinkText5 = "Net.Framework.100.professional.notes.";

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

            IWebElement searchBox = wait.Until(d => d.FindElement(By.LinkText(LinkText2)));
            Assert.IsTrue(searchBox.Text == LinkText2);
            searchBox.Click();
        }

        [Test]
        public void Click3()
        {

            IWebElement searchBox = wait.Until(d => d.FindElement(By.LinkText(LinkText3)));
            Assert.IsTrue(searchBox.Text == LinkText3);
            searchBox.Click();
        }

        [Test]
        public void Click4()
        {

            IWebElement searchBox = wait.Until(d => d.FindElement(By.LinkText(LinkText4)));
            Assert.IsTrue(searchBox.Text == LinkText4);
            searchBox.Click();
        }

        [Test]
        public void Click5()
        {

            IWebElement searchBox = wait.Until(d => d.FindElement(By.LinkText(LinkText5)));
            Assert.IsTrue(searchBox.Text == LinkText5);
            searchBox.Click();
        }
    }
}

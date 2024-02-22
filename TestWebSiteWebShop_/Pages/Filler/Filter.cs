using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestWebSiteWebShop_.Pages.Filler
{
    public class Filter
    {
        public string LinkText = "ВЫСОКО-НАГРУЖЕННЫЕ ПРИЛОЖЕНИЯ";
        public string LinkText2 = ".Selenium.WebDriver.Recipes in C#";
        public string LinkText3 = "ASP.NET 8 Best Practices";
        public string LinkText4 = "Apress.Practical.GraphQL.";
        public string LinkText5 = "Net.Framework.100.professional.notes.";
        public IWebElement Filters;

        public string cssSelectorAuther = "Countre";
        public string cssSelector2Auther = "Jonathan";
        public string cssSelector3Auther = "Nabendu Biswas";
        public string cssSelector4Auther = "Zubair Chowhan\t";
        public string cssSelector5Auther = "Roger Ye\t";

        public string cssSelectorAutherEnter = "#author";
        public string cssSelectorNameEnter = "#name";
        public string cssSelectorButton = "div.container:nth-child(1) div.form-container div:nth-child(1) form:nth-child(2) > button:nth-child(2)";
        public string cssSelectorButtonAll = "div.container:nth-child(1) div.form-container div:nth-child(1) form:nth-child(2) > button:nth-child(3)";

        public WebDriverWait wait { get; set; }

        public void ParamethFilter(WebDriverWait driver)
        {

            wait = driver;
        }

        public void FilterName()
        {
            Filters = wait.Until(d => d.FindElement(By.CssSelector(cssSelectorNameEnter)));
            Filters.SendKeys(LinkText);

        }

        public void FilterName2()
        {
            Filters = wait.Until(d => d.FindElement(By.CssSelector(cssSelectorNameEnter)));
            Filters.SendKeys(LinkText2);

        }

        public void FilterAuther()
        {
            Filters = wait.Until(d => d.FindElement(By.CssSelector(cssSelectorAutherEnter)));
            Filters.SendKeys(cssSelectorAuther);
           
        }

        public void FilterAuther2()
        {
            Filters = wait.Until(d => d.FindElement(By.CssSelector(cssSelectorAutherEnter)));
            Filters.SendKeys(cssSelector2Auther);

        }

        public void FilterAuther3()
        {
            Filters = wait.Until(d => d.FindElement(By.CssSelector(cssSelectorAutherEnter)));
            Filters.SendKeys(cssSelector3Auther);

        }
        public void ButtonClick()
        {
            Filters = wait.Until(d => d.FindElement(By.CssSelector(cssSelectorButton)));
            Filters.Click();
        }

        public void ButtonClickAll()
        {
            Filters = wait.Until(d => d.FindElement(By.CssSelector(cssSelectorButtonAll)));
            Filters.Click();
        }

    }
}

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTest
{
    class Class1
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("D:\\");
        }

        [Test]
        public void Test1()
        {
            driver.Url = "https://rozetka.com.ua";
            ClickSearchBar();
            SearchSmth();
            AddToBasket();
            GoToBasket();
            RemoveFromBasket();
        }

        public void ClickSearchBar()
        {
            IWebElement ass = driver.FindElement(By.XPath(".//input[@name='search']"));
            ass.Clear();
            ass.SendKeys("iphone");
        }
        public void SearchSmth()
        {
            IWebElement ass = driver.FindElement(By.XPath(".//button[@class='button button_color_green button_size_medium search-form__submit']"));
            ass.Click();
        }
        public void AddToBasket()
        {
            IWebElement ass = driver.FindElement(By.XPath(".//button[@class='btn-link-i']"));
            ass.Click();
        }

        public void GoToBasket()
        {
            IWebElement ass = driver.FindElement(By.XPath(".//a[@class='header - actions__button header - actions__button_type_cart whitelink header - actions__button - state - active']"));
            ass.Click();
        }
        public void OpenBasket()
        {
            IWebElement ass = driver.FindElement(By.XPath(".//a[@name='before_delete']"));
            ass.Click();
        }
        public void RemoveFromBasket()
        {
            IWebElement ass = driver.FindElement(By.XPath(".//a[@class='popup-close']"));
            ass.Click();
        }



        [TearDown]
        public void CloseBrowser()
        {
            //driver.Close();
        }

    }
}

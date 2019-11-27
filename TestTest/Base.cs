using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using TestTest.Pages;


namespace TestTest
{
    class Base
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
            driver.Url = "https://www.google.com";
            PageHome pageHome = new PageHome(); 
            PageFactory.InitElements(driver, pageHome);
            BackToHome backToHome = new BackToHome();
            PageFactory.InitElements(driver,backToHome);
            pageHome.Input.Click();
            pageHome.Input.SendKeys("Волк это ходить");
            pageHome.BtnSearch.Click();
            backToHome.BackHome.Click();

        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }

    }
}

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



namespace TestTest
{
    public class Base
    {
        public static IWebDriver driver;

         public static IWebDriver getDriver()
            {
                return driver;
            }

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("D:\\");
        }

[TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }

    }
}

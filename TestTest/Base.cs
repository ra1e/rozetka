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
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("D:\\");
            driver.Url = "https://www.google.com";
        }




        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }

    }
}

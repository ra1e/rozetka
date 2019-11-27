using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading.Tasks;

namespace TestTest.Pages
{
    class BackToHome
    {
        [FindsBy(How = How.CssSelector, Using = "a#logo")]
        public IWebElement BackHome { get; set; }
    }
}

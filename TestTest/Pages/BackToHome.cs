using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading.Tasks;

namespace TestTest.Pages
{
    class BackToHome
    {
        public IWebElement BackHome = Base.getDriver().FindElement(By.Id("logo"));
    }
}

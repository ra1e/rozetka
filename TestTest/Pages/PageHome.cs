using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading.Tasks;

namespace TestTest.Pages
{
    class PageHome : Base
    {

        public IWebElement Input = Base.getDriver().FindElement(By.XPath("//input[title='Поиск']"));



        public IWebElement BtnSearch = Base.getDriver().FindElement(By.XPath("//input[value='Поиск в Google']"));



    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading.Tasks;
namespace TestTest.Pages
{
    class PageHome
    {
        [FindsBy(How = How.CssSelector, Using = "input[title='Поиск']")]
        public IWebElement Input { get; set; }


        [FindsBy(How = How.CssSelector, Using = "input[value='Поиск в Google']")]
        public IWebElement BtnSearch { get; set; }


    }
}

using NUnit.Framework;


namespace TestTest
{
    class test1 : Base
    {
        [Test]
        public void Test1()
        {
            driver.Url = "https://www.google.com";

            SinglePages.getPageHome().Input.Click();
            SinglePages.getPageHome().Input.SendKeys("Волк это ходить");
            SinglePages.getPageHome().BtnSearch.Click();
            SinglePages.getBackToHome().BackHome.Click();

        }
    }
}

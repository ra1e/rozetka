using TestTest.Pages;


namespace TestTest
{
    class SinglePages
    {
        private static PageHome pageHome;
        public static PageHome getPageHome()
        {
            if (pageHome == null)
                pageHome = new PageHome();
            return pageHome;
        }

        private static BackToHome backToHome;
        public static BackToHome getBackToHome()
        {
            if (backToHome == null)
                backToHome = new BackToHome();
            return backToHome;
        }

    }
}

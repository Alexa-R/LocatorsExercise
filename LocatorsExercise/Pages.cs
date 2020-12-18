using OpenQA.Selenium.Support.PageObjects;

namespace LocatorsExercise
{
    public static class Pages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(WebDriverFactory.Driver, page);
            return page;
        }

        public static HomePage HomePage => GetPage<HomePage>();
    }
}

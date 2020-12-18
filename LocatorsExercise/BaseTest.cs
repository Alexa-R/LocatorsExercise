using NUnit.Framework;
namespace LocatorsExercise
{
    [TestFixture]
    public class BaseTest
    {

        [SetUp]
        public void SetUpTest()
        {
            //https://www.onliner.by/
            //https://catalog.onliner.by/mobile/poco/x3nfc6128gbblue
            //
            WebDriverFactory.InitBrowser("Chrome");
            WebDriverFactory.GoToUrl("https://www.onliner.by/");
            WebDriverFactory.Driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDownTest()
        {
            WebDriverFactory.CloseAllDrivers();
        }
    }
}

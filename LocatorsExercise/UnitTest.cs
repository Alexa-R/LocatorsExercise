using NUnit.Framework;

namespace LocatorsExercise
{
    public class UnitTest : BaseTest
    {
        [Test]
        public void LocatorIsDisplayed()
        {
           Assert.IsTrue(Page.HomePage.IsLocatorDisplayed());
        }
    }
}

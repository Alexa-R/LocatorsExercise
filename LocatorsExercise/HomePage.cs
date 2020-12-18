using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace LocatorsExercise
{
    public class HomePage
    {
        //[FindsBy(How = How.Id, Using = "fast-search")]
        //[FindsBy(How = How.ClassName, Using = "onliner_logo")]
        //[FindsBy(How = How.Name, Using = "query")]
        //[FindsBy(How = How.LinkText, Using = "ЛЮДИ")]
        //[FindsBy(How = How.PartialLinkText, Using = "МНЕНИ")]
        //[FindsBy(How = How.XPath, Using = "//*[@class='catalog-masthead__title']")]
        //[FindsBy(How = How.CssSelector, Using = "#device-header-image")]
        //[FindsBy(How = How.TagName, Using = "header")]

        //[FindsBy(How = How.XPath, Using = "//div[@class='product-aside__box']//div[contains(@class,'info-price_contacts')]")]
        //[FindsBy(How = How.XPath, Using = "//*[@class='product-gallery__shaft']//div[position()=1]")]

        //[FindsBy(How = How.XPath, Using = "//*[text()='Люди']/ancestor::div[contains(@class,'main-page-news')]")]
        //[FindsBy(How = How.XPath, Using = "//*[@id='map-fullscreen-button']/child::div[contains(@class,'control_fullscreen')]")]
        //[FindsBy(How = How.XPath, Using = "//*[@id='weather-informer']/descendant::*[contains(@data-bind,'temperature')]")]
        //[FindsBy(How = How.XPath, Using = "//*[@itemprop='offerCount']/parent::*")]
        //[FindsBy(How = How.XPath, Using = "//*[@itemprop='reviewCount']/preceding-sibling::span[contains(@class,'rating_middle')]")]

        //[FindsBy(How = How.XPath, Using = "//*[text()='Важное']/ancestor::div[@class='h-hottopics']//li")]
        //[FindsBy(How = How.XPath, Using = "//*[@property='status']//li")]
        //[FindsBy(How = How.XPath, Using = "//*[@class='footer-style__list']/li")]
        //[FindsBy(How = How.XPath, Using = "//ul[contains(@class,'classifier_brand')]/li")]
        private IWebElement Locator;

        public bool IsLocatorDisplayed()
        {
            return Locator.Displayed;
        }
    }
}

using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace OnlinerTestProject.PageObjects
{
    public class HomePage
    {
        //[FindsBy(How = How.Id, Using = "")]
        //[FindsBy(How = How.Name, Using = "")]
        //[FindsBy(How = How.ClassName, Using = "")]
        //[FindsBy(How = How.LinkText, Using = "")]
        //[FindsBy(How = How.PartialLinkText, Using = "")]
        //[FindsBy(How = How.TagName, Using = "")]
        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement Locator;

        public bool IsLocatorDisplayed()
        {
            return Locator.Displayed;
        }
    }
}

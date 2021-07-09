using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjectMar.Utilities
{
    class Wait
    {
        public static void WaitForElementToBePresent(IWebDriver driver, string locator, string locatorValue, int seconds)
        {
            try {
                if (locator == "Id") {
                    var Wait = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, new TimeSpan(0, 0, seconds));
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(locatorValue)));
                }

                if (locator == "XPath")
                {
                    var Wait = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, new TimeSpan(0, 0, seconds));
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(locatorValue)));
                }

                if (locator == "CssSelector")
                {
                    var Wait = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, new TimeSpan(0, 0, seconds));
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(locatorValue)));
                }

                if (locator == "LinkText")
                {
                    var Wait = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, new TimeSpan(0, 0, seconds));
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.LinkText(locatorValue)));
                }
               } catch (Exception ex)
            {
                Assert.Fail("Test failed waiting for element to be present", ex.Message);
            }
            }
    }
}

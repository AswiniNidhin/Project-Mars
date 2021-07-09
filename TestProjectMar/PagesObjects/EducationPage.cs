using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TestProjectMar.Hooks;
using TestProjectMar.Utilities;

namespace TestProjectMar.PagesObjects
{
    class EducationPage
    {
         IWebDriver driver;
        

        //Education elements

        IWebElement Educationtab => driver.FindElement(By.LinkText("Education"));
        IWebElement EducationtAddnewBtn => driver.FindElement(By.XPath("//thead/tr[1]/th[6]"));

        IWebElement UniName => driver.FindElement(By.XPath("//input[@name='instituteName']"));
        IWebElement SelectCountry => driver.FindElement(By.XPath("//select[@name='country']"));

        IWebElement SelectTitle => driver.FindElement(By.XPath("//select[@name='title']"));
        IWebElement Degree  => driver.FindElement(By.XPath("//input[@name='degree']"));
        IWebElement Year  => driver.FindElement(By.XPath("//select[@name='yearOfGraduation']"));
        IWebElement AddEduData  => driver.FindElement(By.XPath("//div[@class='sixteen wide field']/input[1]"));

        public EducationPage()
        {
            driver = Hook.driver;
        }

        public void EduTabAddNewButton()
        {

            Wait.WaitForElementToBePresent(driver, "LinkText", "Education", 2);
            Educationtab.Click();
            Thread.Sleep(1000);
            EducationtAddnewBtn.Click();
        }
        public void EnterEduData(string University, string degreeName)

        {
            Wait.WaitForElementToBePresent(driver, "Xpath", "//input[@name='instituteName", 2);
            UniName.SendKeys(University);

            Wait.WaitForElementToBePresent(driver, "Xpath", "//select[@name='country']", 2);
            SelectElement SelectCountryUni= new SelectElement(SelectCountry);
            SelectCountryUni.SelectByText("Australia");


            Wait.WaitForElementToBePresent(driver, "Xpath", "//select[@name='title']", 2);
            SelectElement SelectDropdownTitle = new SelectElement(SelectTitle);
            SelectDropdownTitle.SelectByText("BFA");

            Wait.WaitForElementToBePresent(driver, "Xpath", "//input[@name='degree']", 2);
            Degree.SendKeys(degreeName);

            Wait.WaitForElementToBePresent(driver, "Xpath", "//select[@name='yearOfGraduation']", 2);
            SelectElement SelectYearDropdown= new SelectElement(Year);
            SelectYearDropdown.SelectByText("2020");

            Wait.WaitForElementToBePresent(driver, "Xpath", "//div[@class='sixteen wide field']/input[1]", 2);
            AddEduData.Click();
        }

        
    }
}

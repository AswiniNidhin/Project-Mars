using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TestProjectMar.Hooks;

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
            
            Thread.Sleep(1000);
            Educationtab.Click();
            Thread.Sleep(1000);
            EducationtAddnewBtn.Click();
        }
        public void EnterEduData()

        {
            Thread.Sleep(1000);
            UniName.SendKeys("Uni USQ");

            Thread.Sleep(3000);
            SelectElement SelectCountryUni= new SelectElement(SelectCountry);
            SelectCountryUni.SelectByText("Australia");


            Thread.Sleep(3000);
            SelectElement SelectDropdownTitle = new SelectElement(SelectTitle);
            SelectDropdownTitle.SelectByText("BFA");

            Thread.Sleep(3000);
            Degree.SendKeys("BioMed");

            Thread.Sleep(3000);
            SelectElement SelectYearDropdown= new SelectElement(Year);
            SelectYearDropdown.SelectByText("2020");

            Thread.Sleep(1000);
            AddEduData.Click();
        }

        
    }
}

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TestProjectMar.Hooks;
using TestProjectMar.Utilities;

namespace TestProjectMar.PagesObjects
{
    class CertificationPage
    {
       private readonly IWebDriver driver;
       


        //Certification data elements

        IWebElement CertificateTab => driver.FindElement(By.LinkText("Certifications"));

        IWebElement AddCertificateButton => driver.FindElement(By.XPath("//thead/tr[1]/th[4]/div[1]"));

        IWebElement AwardText => driver.FindElement(By.XPath("//input[@placeholder='Certificate or Award']"));

        IWebElement CertifiedAwardFromTxt => driver.FindElement(By.XPath("//input[@placeholder='Certified From (e.g. Adobe)']"));

        IWebElement CertifiedYear => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/div[1]/div[2]/div[2]/select[1]"));

        IWebElement AddCertifiedDataBtn => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/div[1]/div[3]/input[1]"));

        public CertificationPage()
        {
            driver = Hook.driver;
        }


        public void Cert_Tab_AddNewButton()
        {
            //Clicked skill tab and addnew button
            Wait.WaitForElementToBePresent(driver, "LinkText", "Certifications", 3);
            CertificateTab.Click();
            
            AddCertificateButton.Click();

        }

        public void Cert_Data(string Certificate, string CertifiedFrom) 
        {
            //enter certificate or award
            Wait.WaitForElementToBePresent(driver, "Xpath", "//input[@placeholder='Certificate or Award']", 2);
             AwardText.SendKeys(Certificate);




            //enter certified award from
            Wait.WaitForElementToBePresent(driver, "Xpath", "//input[@placeholder='Certified From (e.g. Adobe)']", 2);
            CertifiedAwardFromTxt.SendKeys(CertifiedFrom);


            //select year
            Wait.WaitForElementToBePresent(driver, "xpath", "//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/div[1]/div[2]/div[2]/select[1]", 2);
            SelectElement Cert_Year = new SelectElement(CertifiedYear);
            Cert_Year.SelectByText("2020");
           

            //click action to enter data
           

        }

        public void Certifiedaddbutton() => AddCertifiedDataBtn.Click();


    }



}


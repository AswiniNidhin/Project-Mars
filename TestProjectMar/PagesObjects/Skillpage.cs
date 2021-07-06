using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using TestProjectMar.Hooks;

namespace TestProjectMar.PagesObjects
{
    class Skillpage
    {
        IWebDriver driver;

        //Login elements
        IWebElement SigInBtn => driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
        IWebElement Email => driver.FindElement(By.XPath("//input[@name='email']"));
        IWebElement Password => driver.FindElement(By.XPath("//input[@name='password']"));
        IWebElement Submit => driver.FindElement(By.XPath("//button[contains(text(),'Login')]"));


        //Skill elements

        IWebElement Skilltab => driver.FindElement(By.LinkText("Skills"));
        IWebElement Skilladdnewbutton => driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]"));
        IWebElement TextSkill => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/div[1]/input[1]"));
        IWebElement ChooseSkill => driver.FindElement(By.XPath("//div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/div[2]/select[1]"));
        IWebElement AddSkilldata => driver.FindElement(By.XPath(" //*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
        //IWebElement TextVisible => driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[1]"));

        public Skillpage()
        {
            driver = Hook.driver;
        }
        public void NavigatetoUrl()

        {
            driver.Navigate().GoToUrl("http://localhost:5000");
        }


        public void SignIn()
        {
            Thread.Sleep(1000);
            SigInBtn.Click();
        }

        public void EnterEmailPassword()
        {

            Thread.Sleep(1000);
            Email.Click();
            Email.Clear();
            Email.SendKeys("aswini.sanal@outlook.com");
            Thread.Sleep(4000);
            Password.Click();
            Password.Clear();
            Password.SendKeys("Testing0123*");

        }

        public void ProfilepageLoggedIn()
        {

            // rememberme.Click();
            Thread.Sleep(500);
            Submit.Click();



        }


        public void ClickSkilladd()
        {
            Thread.Sleep(1000);
            Skilltab.Click();
            Thread.Sleep(1000);
            Skilladdnewbutton.Click();

        }

        public void Skilldata()
        {
            Thread.Sleep(500);
            TextSkill.SendKeys("English");
            Thread.Sleep(1000);
            ChooseSkill.Click();
            Thread.Sleep(1000);
            SelectElement chooseSkillElement = new SelectElement(ChooseSkill);
            chooseSkillElement.SelectByText("Intermediate");
            Thread.Sleep(1000);
            AddSkilldata.Click();
        }

        public void Adddata()
        {
            Thread.Sleep(1000);
            AddSkilldata.Click();
        }




        public void VerifySkillData()

        {
            
            //Assert.That(TextVisible, Is.EqualTo("English"));
            //Console.WriteLine("Succefully added data to the skill");
            try
            {
             
                IAlert alert = driver.SwitchTo().Alert();
                Debug.WriteLine(alert.Text);
                driver.SwitchTo().DefaultContent();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}

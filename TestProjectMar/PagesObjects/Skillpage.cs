using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Diagnostics;
using System.Threading;
using TestProjectMar.Hooks;
using TestProjectMar.Utilities;

namespace TestProjectMar.PagesObjects
{
    class Skillpage
    {
        IWebDriver driver;
        
       

        //Login elements
        IWebElement SigInBtn => driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
        IWebElement ProfileEmail => driver.FindElement(By.XPath("//input[@name='email']"));
        IWebElement ProfilePassword => driver.FindElement(By.XPath("//input[@name='password']"));
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
            Wait.WaitForElementToBePresent(driver, "XPath", "//*[@id='home']/div/div/div[1]/div/a", 2);
            SigInBtn.Click();
            
        }

        public void EnterEmailPassword()


        {

            
            ProfileEmail.Click();
            ProfileEmail.Clear();
            ProfileEmail.SendKeys("aswini.sanal@outlook.com");
            Wait.WaitForElementToBePresent(driver, "XPath", "//input[@name='email']", 3);
            ProfilePassword.Click();
            ProfilePassword.Clear();
            ProfilePassword.SendKeys("Testing0123*");

        }

        public void ProfilepageLoggedIn()
        {

            // rememberme.Click();
            Thread.Sleep(500);
            Submit.Click();



        }


        public void ClickSkilladd()
        {
            Wait.WaitForElementToBePresent(driver, "LinkText", "Skills", 3);
            Skilltab.Click();
            Thread.Sleep(1000);
            Skilladdnewbutton.Click();

        }

        public void Skilldata(string text)

        {
            
            TextSkill.SendKeys(text);
            Wait.WaitForElementToBePresent(driver, "xpath", "//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/div[1]/input[1]", 2); 
            ChooseSkill.Click();
            Thread.Sleep(1000);
            SelectElement chooseSkillElement = new SelectElement(ChooseSkill);
            chooseSkillElement.SelectByText("Intermediate");
           
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

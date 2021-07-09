using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TestProjectMar.Hooks;

namespace TestProjectMar.PagesObjects
{
    class Login
    {
        readonly IWebDriver driver;
        IWebElement SigInBtn => driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
        IWebElement Email => driver.FindElement(By.XPath("//input[@name='email']"));
        IWebElement Password => driver.FindElement(By.XPath("//input[@name='password']"));

     //   IWebElement rememberme => driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
        IWebElement Submit => driver.FindElement(By.XPath("//button[contains(text(),'Login')]"));



        public void SignIn()
        {

            SigInBtn.Click();

        }

        public void LoginEnterEmailPassword()
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
            Thread.Sleep(1000);
            Submit.Click();
           // return ProfilePage();
            

        }

        public Login()
        {
            driver = Hook.driver;
        }
        public void NavigatetoUrl()

        {
            driver.Navigate().GoToUrl("http://localhost:5000");
        }
    }
}

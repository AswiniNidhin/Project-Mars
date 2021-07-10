using MarsQA_1.Helpers;
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

        public void LoginEnterEmailPassword(string username, string password)
        {
            
           
            Email.Click();
            Email.Clear();
            Thread.Sleep(1000);
            Email.SendKeys(username);
           
            Password.Click();
            Password.Clear();
            Thread.Sleep(1000);
            Password.SendKeys(password);

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

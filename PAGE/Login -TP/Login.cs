using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SHORTUPLOADS.PAGE.Login__TP
{
   public class Login
    {
        public IWebDriver Driver;
        public Login (IWebDriver driver) 
        {
            Driver = driver;
            PageFactory.InitElements(Driver, this);
        }

        public void NavigateMethod() 
        {
            Driver.Navigate().GoToUrl("http://shortuploads.phpdevelopersinindia.in/");
        }

        public void ClickLogin() 
        {
            Driver.FindElement(By.CssSelector(".fa-user")).Click();
            Task.Delay(2000).Wait();
        }

        public void EnterLoginDetails() 
        {
            Driver.FindElement(By.Id("emailAddress")).SendKeys("troy1lk@gmail.com");
            Task.Delay(2000).Wait();
            Driver.FindElement(By.Id("password")).SendKeys("short123");

            Task.Delay(2000).Wait();
            Driver.FindElement(By.CssSelector("[name='mysubmit']")).Click();
            Task.Delay(2000).Wait();
        }

        public void VerifyLogin()
        {
            IWebElement VL = Driver.FindElement(By.XPath("//h5[contains(text(),'New Releases')]"));
            VL.Displayed.Should().BeTrue();
            Task.Delay(2000).Wait();
        }
    }
}

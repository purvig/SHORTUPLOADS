using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using FluentAssertions;
using NUnit.Framework.Internal;

namespace SHORTUPLOADS.PAGE.Footers___TP
{
    public class Footers
    {
        public IWebDriver Driver;
        public Footers(IWebDriver driver) 
        {
            Driver = driver;
            PageFactory.InitElements(Driver, this);
        }

        public void NavigateMethod() 
        {
            Driver.Navigate().GoToUrl("http://shortuploads.phpdevelopersinindia.in/");
        }

        public void ClickOnFooters(string link) 
        {
            switch (link) 
            {

                case "About Us":
                    IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
                    js.ExecuteScript("window.scrollTo(0, 300)");
                    Task.Delay(2000).Wait();
                    Driver.FindElement(By.LinkText("About Us")).Click();
                    Task.Delay(2000).Wait();
                    break;
                case "Privacy Policy":
                    IJavaScriptExecutor ja = (IJavaScriptExecutor)Driver;
                    ja.ExecuteScript("window.scrollTo(0, 300)");
                    Task.Delay(2000).Wait();
                    Driver.FindElement(By.LinkText("Privacy Policy")).Click();
                    Task.Delay(2000).Wait();
                    break;
                case "Terms Of Use":
                    IJavaScriptExecutor jb = (IJavaScriptExecutor)Driver;
                    jb.ExecuteScript("window.scrollTo(0, 300)");
                    Task.Delay(2000).Wait();
                    Driver.FindElement(By.LinkText("Terms Of Use")).Click();
                    Task.Delay(2000).Wait();
                    break;
                case "Contact Us":
                    IJavaScriptExecutor jc = (IJavaScriptExecutor)Driver;
                    jc.ExecuteScript("window.scrollTo(0, 300)");
                    Task.Delay(2000).Wait();
                    Driver.FindElement(By.LinkText("Contact Us")).Click();
                    Task.Delay(2000).Wait();
                    break;
                default:
                    Console.WriteLine ("no suchelement");
                    break;
                    
            }

        
        }
        public void VerifyFooters(string link)
        {
            switch (link)
            {
                case "About Us":
                    Driver.FindElement(By.CssSelector(".inner-heading > h2")).Displayed.Should().BeTrue();
                    break;
                case "Privacy Policy":
                    Driver.FindElement(By.CssSelector(".text-center > ul > li:nth-child(2) > a")).Displayed.Should().BeTrue();
                    break;
                case "Terms Of Use":
                    Driver.FindElement(By.CssSelector(".footer-links .ml-auto > li:nth-of-type(3) > a")).Displayed.Should().BeTrue();
                    break;
                case "Contact Us":
                    Driver.FindElement(By.CssSelector("[name='mysubmit']")).Displayed.Should().BeTrue();
                    break;
                default:
                    Console.WriteLine("no suchelement");
                    break;

            }


        }
    }
}




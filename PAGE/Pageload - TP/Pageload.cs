using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using SeleniumExtras.PageObjects;

namespace SHORTUPLOADS.PAGE.Pageload___TP
{
    public class Pageload
    {
        public IWebDriver Driver;
        public Pageload (IWebDriver driver) 
        {
            Driver = driver;
            PageFactory.InitElements(Driver, this);
        }

        public void NavigateMethod() 
        {
            Driver.Navigate().GoToUrl("http://shortuploads.phpdevelopersinindia.in/");
        }

        public void VerifyPageload() 
        {
            IWebElement VPL = Driver.FindElement(By.Id("navbarDropdown"));
            VPL.Displayed.Should().BeTrue();
        }
            
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using FluentAssertions;

namespace SHORTUPLOADS.PAGE.Search_PG
{
    public class Searchpage
    {
        public IWebDriver driver;

        public Searchpage(IWebDriver Driver)
        {
            driver = Driver;
            PageFactory.InitElements(driver, this);
        }
        public void NavigateMethod()
        {
            driver.Navigate().GoToUrl("https://www.shortuploads.com/");
        }
        [FindsBy(How = How.CssSelector, Using = ("#tags"))]
        public IWebElement Searchelement;
        [FindsBy(How = How.XPath,Using =("//i[@class='fa fa-search']"))]
        public IWebElement Searchbutton;

        public string LiftURL = "https://www.shortuploads.com/categories?search=Lift";
        public void SearchMethod()
        {
            Task.Delay(3000).Wait();
            Searchelement.SendKeys("Lift");
            Task.Delay(3000).Wait();
            Searchbutton.Click();
        }
        public void VerifySearch()
        {
            driver.Url.Contains(LiftURL).Should().BeTrue();
        }
    }
}

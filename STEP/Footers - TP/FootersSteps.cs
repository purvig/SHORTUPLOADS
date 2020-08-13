using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using SHORTUPLOADS.BASE;
using SHORTUPLOADS.PAGE.Footers___TP;

namespace SHORTUPLOADS.STEP.Footers___TP
{
    [Binding]
    [Scope(Tag = "footers")]
    public class FootersSteps : Hooks
    {
        public IWebDriver driver;
        public Footers browser;

        [Given(@"I navigate to shortuploads")]
        public void GivenINavigateToShortuploads()
        {
            driver = Driver;
            browser = new Footers(driver);
            browser.NavigateMethod();
        }
        
        [When(@"I click on (.*)")]
        public void WhenIClickOn(string link)
        {
            browser.ClickOnFooters(link);
        }
        
        [Then(@"I see the (.*) page")]
        public void ThenISeeThePage(string link)
        {
            browser.VerifyFooters(link);
        }
    }
}

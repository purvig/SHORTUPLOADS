using System;
using TechTalk.SpecFlow;
using SHORTUPLOADS.BASE;
using SHORTUPLOADS.PAGE.Pageload___TP;
using OpenQA.Selenium;


namespace SHORTUPLOADS.STEP
{
    [Binding]
    [Scope(Tag ="pageload")]
    public class PageLoadSteps : Hooks
    {
        public IWebDriver driver;
        public Pageload browser;

        [Given(@"I navigate to Shortuploads")]
        public void GivenINavigateToShortuploads()
        {
            driver = Driver;
            browser = new Pageload(driver);
            browser.NavigateMethod();
        }
        
        [Then(@"I see the videos")]
        public void ThenISeeTheVideos()
        {
            browser.VerifyPageload();
        }
    }
}

using System;
using TechTalk.SpecFlow;
using SHORTUPLOADS.BASE;
using SHORTUPLOADS.PAGE.Login__TP;
using OpenQA.Selenium;

namespace SHORTUPLOADS.STEP.Login___TP
{
    [Binding]
    [Scope(Tag ="login")]
    public class LoginSteps : Hooks
    {
        public IWebDriver driver;
        public Login browser;

        [Given(@"I navigate to shortuploads")]
        public void GivenINavigateToShortuploads()
        {
            driver = Driver;
            browser = new Login(driver);
            browser.NavigateMethod();
        }
        
        [When(@"I click login")]
        public void WhenIClickLogin()
        {
            browser.ClickLogin();
        }
        
        [When(@"I enter login details")]
        public void WhenIEnterLoginDetails()
        {
            browser.EnterLoginDetails();
        }
        
        [Then(@"I am signed in to shortuploads")]
        public void ThenIAmSignedInToShortuploads()
        {
            browser.VerifyLogin();
        }
    }
}

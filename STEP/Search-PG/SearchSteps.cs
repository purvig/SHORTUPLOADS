using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using SHORTUPLOADS.PAGE.Search_PG;
using SHORTUPLOADS.BASE;
using OpenQA.Selenium;



namespace SHORTUPLOADS.STEP.Searchstep_PG
{
    [Binding]
    [Scope(Tag = "search")]

    public class SearchSteps : Hooks
    {
        public IWebDriver driver;
        public Searchpage search;

        [Given(@"I navigate to shortuploads website")]
        public void GivenINavigateToShortuploadsWebsite()
        {
            driver = Driver;
            search = new Searchpage(driver);
            search.NavigateMethod();
        }

        [When(@"I search for Lift")]
        public void WhenISearchForLift()
        {
            search.SearchMethod();
        }

        [Then(@"I see the page loads with search results")]
        public void ThenISeeThePageLoadsWithSearchResults()
        {
            search.VerifySearch();
        }
    }
}
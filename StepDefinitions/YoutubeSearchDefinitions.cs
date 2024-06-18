using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace YoutubeSearch_Project.StepDefinitions
{
    [Binding]
    public sealed class YoutubeSearchDefinitions
    {
        private IWebDriver driver;
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        [Given(@"Open the browser")]
        public void GivenOpenTheBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [When(@"Enter the URL")]
        public void WhenEnterTheURL()
        {
            driver.Url = "https://www.youtube.com/";
            Thread.Sleep(5000);
        }

        [Then(@"Search for Islamic Songs")]     

        public void ThenSearchForIslamicSongs()
        {
            driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys("Islamic Songs");
            driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys(Keys.Enter);

            Thread.Sleep(5000);
            driver.Quit();
        }
    }
}

using CNNAutomation;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CNNAutomationPortalTests
{
    [TestClass]
    public class CNNHomePageTests
    {
        IWebDriver _driver;

        [TestInitialize] 
        public void Initialize()
        {
            _driver = new ChromeDriver();
        }

        [TestMethod]
        [DataRow("World")]
        [DataRow("Travel")]
        [DataRow("Style")]
        [DataRow("Sports")]
        [DataRow("Video")]
        [DataRow("Health")]
        [DataRow("Entertainment")]

        public void CorrectMenuPointsLinksTests(string menuItem)
        {

            CNNHomePage homePage = new CNNHomePage(_driver);
            Assert.IsTrue(homePage.CheckPageLink(menuItem));

        }

        [TestMethod]

        public void CheckSearchPagePisitive()
        {
            CNNSearchPage page = new CNNSearchPage(_driver);
            var results = page.GetSearchResults("Milan");
            var filteredResults = results.Where(x => x.Contains("Milan")).ToList();
            Assert.IsTrue(filteredResults.Count >= filteredResults.Count/ 2);
        }

        [TestMethod]

        public void CheckSearchPageNegative()
        {
            CNNSearchPage page = new CNNSearchPage(_driver);
            var results = page.GetSearchResults("gggggggg");
            var filteredResults = results.Where(x => x.Contains("Milan")).ToList();
            Assert.IsTrue(results.Count == 0);
        }

        [TestCleanup] 
        public void Cleanup()
        {
            _driver.Dispose();
        }
    }
}

using CNNAutomation;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CNNAutomationPortalTests
{
    [TestClass]
    public class CNNHomePageTests
    {
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
            IWebDriver driver = new ChromeDriver();

            CNNHomePage homePage = new CNNHomePage(driver);

            Assert.IsTrue(homePage.CheckPageLink(menuItem));

            
            driver.Close();
        }
    }
}
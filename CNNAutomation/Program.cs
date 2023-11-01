
using CNNAutomation;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Xml.Linq;


IWebDriver driver = new ChromeDriver();

CNNHomePage homePage = new CNNHomePage(driver);

bool isWorldPageDisplayed = homePage.CheckPageLink("World");
bool isTravelPageDisplayed = homePage.CheckPageLink("Travel");
bool isStylePageDisplayed = homePage.CheckPageLink("Style");
bool isSportsPageDisplayed = homePage.CheckPageLink("Sports");
bool isVideoPageDisplayed = homePage.CheckPageLink("Video");

Console.WriteLine($"Test result: {isWorldPageDisplayed && isTravelPageDisplayed && isStylePageDisplayed && isSportsPageDisplayed && isVideoPageDisplayed}");

driver.Close();

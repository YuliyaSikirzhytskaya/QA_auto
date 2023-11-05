
using CNNAutomation;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



IWebDriver driver = new ChromeDriver();
try
{

    var menuPointNames = new List<string> { "World", "Travel", "Style", "Sports", "Video", "Health", "Entertainment" };

    List<string> results = new List<string>();

    CNNHomePage homePage = new CNNHomePage(driver);

    foreach (var item in menuPointNames)
    {
        results.Add($"Result for {item} is:{homePage.CheckPageLink(item).ToString()}");
    };

    //bool isWorldPageDisplayed = homePage.CheckPageLink("World");
    //bool isTravelPageDisplayed = homePage.CheckPageLink("Travel");
    //bool isStylePageDisplayed = homePage.CheckPageLink("Style");
    //bool isSportsPageDisplayed = homePage.CheckPageLink("Sports");
    //bool isVideoPageDisplayed = homePage.CheckPageLink("Video");

    //Console.WriteLine($"Test result: {isWorldPageDisplayed && isTravelPageDisplayed && isStylePageDisplayed && isSportsPageDisplayed && isVideoPageDisplayed}");
}
finally { driver.Close(); }


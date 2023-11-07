
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

}
finally { driver.Close(); }


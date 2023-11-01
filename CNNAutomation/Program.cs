
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Xml.Linq;


static void CheckPage(IWebDriver driver, string linkText, string keyword) 
{


    IWebElement menuItem = driver.FindElement(By.LinkText(linkText));

    menuItem.Click();

    string title = driver.Title;
    Console.WriteLine("Page is opened: {0}", title.ToLower().Contains(keyword));

    string url = driver.Url;
    Console.WriteLine("Test case 2: {0}", url.Contains(keyword));

    driver.Url = "https://edition.cnn.com/";
}

IWebDriver driver = new ChromeDriver();

//WebDriverWait _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
driver.Url = "https://edition.cnn.com/";

driver.Manage().Window.Maximize();

IWebElement cookie = driver.FindElement(By.Id("onetrust-accept-btn-handler"));
cookie.Click();

CheckPage(driver, "World", "world");
CheckPage(driver, "Travel", "travel");
CheckPage(driver, "Style", "style");
CheckPage(driver, "Sports", "sports");
CheckPage(driver, "Video", "video");

//IWebElement travelMenuItem = driver.FindElement(By.LinkText("Travel"));
//travelMenuItem.Click();

//title = driver.Title;
//Console.WriteLine("Travel page is opened: {0}", title == "CNN Travel | Global Destinations, Tips & Video | CNN");

//url = driver.Url;
//Console.WriteLine("Test case 2: {0}",url.Contains("travel"));



driver.Close();
Console.WriteLine("Hello, World!");

using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace MailAutomationTest
{
    public class BodyLetter:MailBasePage
    {
        const string ADDRESS = "//div[contains(@aria-label, 'Текст письма')]";
        const string TestSubmin = "//div[contains(@data-tooltip, 'Отправить')]";

        public BodyLetter(IWebDriver driver) : base(driver, driver.Url)
        {
            
        }

        public void PopulateAndSendLetter(string to, string title, string body)
        {
            Wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("to")));
            var element = WebDriver.FindElement(By.Name("to")).FindElement(By.TagName("input"));
            element.Click();
            element.SendKeys(to);

            Wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("subjectbox")));
            element = WebDriver.FindElement(By.Name("subjectbox"));
            element.SendKeys(title);

            Wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath(ADDRESS)));
            element = WebDriver.FindElement(By.XPath(ADDRESS));
            element.SendKeys(body);

            element = WebDriver.FindElement(By.XPath(TestSubmin));
            element.Click();

        }
    }
}

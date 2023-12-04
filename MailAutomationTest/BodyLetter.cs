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
            WaitElementsLocatedByName("to");
            var element = FindElementByName("to").FindElement(By.TagName("input"));
            element.Click();
            element.SendKeys(to);

            WaitElementsLocatedByName("subjectbox");
            element = FindElementByName("subjectbox");
            element.SendKeys(title);

            WaitElementsLocatedByXpath(ADDRESS);
            element = FindElementByXpath(ADDRESS);
            element.SendKeys(body);

            element = FindElementByXpath(TestSubmin);
            element.Click();

        }
    }
}

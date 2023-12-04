using OpenQA.Selenium;

namespace MailAutomationTest
{
    public class MainPage : MailBasePage
    {
        const string BODY_MESSAGE_REPLY_Prumpkin = "Hello, Prumpkin. I'm ready.";
        const string TITLE_MESSAGE = "//h2[contains(text(), '";
        const string BODY_MESSAGE = "//div[contains(text(), '";
        const string UNREAD_LETTER = "//tr[contains(@class, 'zA zE')]";
        const string REPLY_BUTTON = "//span[contains(@class, 'ams bkH')]";
        const string REPLY_BODY = "//div[contains(@aria-label, 'Текст письма')]";
        const string SEND_BUTTON = "//div[contains(@role, 'button') and contains(@class, 'T-I J-J5-Ji aoO v7 T-I-atl L3')]";
        const string INCOMING_MESSAGE = "//div[contains(@data-tooltip, 'Входящие')]";
        const string NEW_LETTER = "//div[contains(@class, 'T-I T-I-KE L3')]";
        public MainPage(IWebDriver driver) : base(driver, driver.Url)
        {

        }

        public bool CheckLetter(string title, string body, int retry = 0) 
        {
            if (retry > 20) { return false; }

            var element = FindFirstElementsByXpath(UNREAD_LETTER);

            if (element != null)
            {
                element.Click();
                var titleToCheck = GetElementByXpath(TITLE_MESSAGE + title + "')]").Text;
                var bodyToCheck = GetElementByXpath(BODY_MESSAGE + body + "')]").Text;
                if (!string.IsNullOrEmpty(titleToCheck) && !string.IsNullOrEmpty(bodyToCheck)) 
                {
                    return true;
                }
                GetElementByXpath(INCOMING_MESSAGE).Click();
                return CheckLetter(title, body);
            }

            Thread.Sleep(30000);

            GetElementByXpath(INCOMING_MESSAGE).Click();
            return CheckLetter(title, body, ++retry);
        }
        public void ClickButtonLogin()
        {
            var element = GetElementByXpath(NEW_LETTER);
            element.Click();
        }
        public void ReplyLetter() 
        {
            GetElementByXpath(REPLY_BUTTON).Click();
            var replyMessage = FindElementByXpath(REPLY_BODY);
            replyMessage.SendKeys(BODY_MESSAGE_REPLY_Prumpkin);
            replyMessage.Click();
            GetElementByXpath(SEND_BUTTON).Click();

        }
    }
}

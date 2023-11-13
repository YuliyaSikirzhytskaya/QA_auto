using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Chrome;
using System.Security.Cryptography.X509Certificates;

namespace MailAutomationTest
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            IWebDriver driver1 = new ChromeDriver();

            const string MAIN_PAGE = "https://www.google.com/intl/ru/gmail/about/";
            const string LOGIN_1 = "prumpkinTest1@gmail.com";
            const string PASS_1 = "1qaz!QAZ2wsx@WSX";
            const string LOGIN_2 = "frumpkinTest1@gmail.com";
            const string PASS_2 = "1qaz!QAZ2wsx@WSX";
            const string LOGIN_BUTTON_XPATH = "//input[contains(@id, 'identifierId')]";
            const string PASS_BUTTON_XPATH = "//input[contains(@autocomplete, 'current-password')]";
            const string BUTTON_NEXT_XPATH = "//div[contains(@id, 'identifierNext')]";
            const string BUTTON_NEXT_PASS_XPATH = "//div[contains(@id, 'passwordNext')]";
            const string NEW_LETTER = "//div[contains(@class, 'T-I T-I-KE L3')]";
            const string TITLE_PEQUEST = "Hello, Frumpkin";
            const string BODY_LETTER = "Hello dear friend! I have a proposition for you.";


            var loginPage = new LoginPage(driver1, MAIN_PAGE);

            loginPage.ClickButtonLogin();
            //loginPage.FieldUpdate(LOGIN_1, LOGIN_BUTTON_XPATH);
            //loginPage.ClickButtonLogin(BUTTON_NEXT_XPATH); 
            //loginPage.FieldUpdate(PASS_1, PASS_BUTTON_XPATH);
            //loginPage.ClickButtonLogin(BUTTON_NEXT_PASS_XPATH);


            //var mainPage = new MainPage(driver);
            //mainPage.ClickButtonLogin(NEW_LETTER);
            //var bodyLetter = new BodyLetter(driver);
            //bodyLetter.PopulateAndSendLetter(LOGIN_2, TITLE_PEQUEST, BODY_LETTER);


            //loginPage.AccountExit();
            //loginPage.ClickButtonLogin();
            //loginPage.ChangeAccount();
            //Thread.Sleep(5000);
            loginPage.FieldUpdate(LOGIN_2, LOGIN_BUTTON_XPATH);
            loginPage.ClickButtonLogin(BUTTON_NEXT_XPATH);
            loginPage.FieldUpdate(PASS_2, PASS_BUTTON_XPATH);
            loginPage.ClickButtonLogin(BUTTON_NEXT_PASS_XPATH);
            Thread.Sleep(3000);
            var mainPage = new MainPage(driver1);
            mainPage.CheckLetter();

            loginPage.AccountExit();
            loginPage.ClickButtonLogin();
            loginPage.ChangeAccount();
            Thread.Sleep(5000);

            loginPage.FieldUpdate(LOGIN_1, LOGIN_BUTTON_XPATH);
            loginPage.ClickButtonLogin(BUTTON_NEXT_XPATH);
            loginPage.FieldUpdate(PASS_1, PASS_BUTTON_XPATH);
            loginPage.ClickButtonLogin(BUTTON_NEXT_PASS_XPATH);
            

            driver1.Close();
        }
    }
}
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailAutomationTest
{
    public class MainPage : MailBasePage
    {
        public MainPage(IWebDriver driver) : base(driver, driver.Url)
        {

        }
    }
}

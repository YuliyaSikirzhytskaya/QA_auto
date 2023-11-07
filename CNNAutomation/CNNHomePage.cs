using OpenQA.Selenium;



namespace CNNAutomation
{
    public class CNNHomePage:CNNBasePage
    {
    
        const string HOME_URL = "https://edition.cnn.com/";
       
        const string MENU_POINTS_XPATH = "//a[contains(@class, 'header__nav-item-link')]";


        public CNNHomePage(IWebDriver driver): base(driver, "https://edition.cnn.com/") 
        {
          
        }

        public bool CheckPageLink(string menuPointName)
        {
            ClickMenuPoint(menuPointName);
          

            return IsTitleContains(menuPointName);
    }
}

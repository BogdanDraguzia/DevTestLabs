using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace RozetkaTestAutomationFrameworkUsage.Pages
{
    public class BasePage
    {
        protected IWebDriver Driver;

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }
    }
}

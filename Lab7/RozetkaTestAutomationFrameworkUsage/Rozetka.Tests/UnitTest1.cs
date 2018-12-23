using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using RozetkaTestAutomationFrameworkUsage.Contexts.Actions;
using RozetkaTestAutomationFrameworkUsage.Contexts.States;
using RozetkaTestAutomationFrameworkUsage.Helpers;
using RozetkaTestAutomationFrameworkUsage.Pages;
using RozetkaTestAutomationFrameworkUsage.Utils;

namespace Rozetka.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver driver;
        private readonly string _url = "https://rozetka.com.ua/tihoe-vino/c4649052/colour-70004=362643/";

        [TestInitialize]
        public void TestInitialize()
        {
            var options = new ChromeOptions();
            options.AddArgument("start-maximized");

            driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl(_url);
            new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(driver1 =>
                ((IJavaScriptExecutor) driver).ExecuteScript("return document.readyState").Equals("complete"));
        }

        [TestCleanup]
        public void TestFinalize()
        {
            driver.Close();
        }

        [TestMethod]
        public void ButtonIsDisplayed()
        {
            //Arrange
            var wineResultsPage = new WineListPage(driver);
            var goodPage = new GoodsItemPage(driver);
            var checkOutPage = new CheckOutPage(driver);
            var wait = new Waiters(driver);
            var country = "Украина";
            var user = new User();
            var minPriceValueToSet = 100;
            var maxPriceValueToSet = 2000;

            //Act
            FilteringActions.FilterByPriceRange(wineResultsPage, minPriceValueToSet, maxPriceValueToSet, wait);
            wineResultsPage.ClickOnMore(wait).ChooseCountry(country, wait);
            ResultSetActions.SelectElement(wineResultsPage, 0, wait);
            MainApllicationActions.ClickOnButtonBuy(goodPage, wait).SubmitOfferButton(wait);
            AddUserDateActions.Add(checkOutPage, user);
            MainApllicationActions.ClickOnButtonContinue(checkOutPage).ClickOnNotCall(wait);

            //Assert
            GoodVerificationStates.VerifyMakeOrderIsDispalyed(checkOutPage);
        }
    }
}
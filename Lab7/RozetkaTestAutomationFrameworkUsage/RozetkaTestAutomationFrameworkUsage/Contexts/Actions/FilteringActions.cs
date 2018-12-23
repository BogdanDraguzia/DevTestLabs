using RozetkaTestAutomationFrameworkUsage.Pages;
using RozetkaTestAutomationFrameworkUsage.Utils;
using OpenQA.Selenium;

namespace RozetkaTestAutomationFrameworkUsage.Contexts.Actions
{
    public static class FilteringActions
    {
        public static void FilterByPriceRange(WineListPage page, int? minPrice, int? maxPrice, Waiters wait)
        {
            SetPrice(page, minPrice, maxPrice).SubmitPriceFilter(wait);
        }

        public static WineListPage SetPrice(this WineListPage page, int? minPrice, int? maxPrice)
        {
            page.SetMinimumPrice(minPrice);
            page.SetMaximumPrice(maxPrice);
            return page;
        }

        public static WineListPage SubmitPriceFilter(this WineListPage page,Waiters wait)
        {
            wait.WaitForClickableElement(By.Id(page.LocFilter));
            page.FilterByPrice.Click();
            return page;
        }

    }
}

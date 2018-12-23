using OpenQA.Selenium;
using RozetkaTestAutomationFrameworkUsage.Pages;
using RozetkaTestAutomationFrameworkUsage.Utils;
using System.Threading;

namespace RozetkaTestAutomationFrameworkUsage.Contexts.Actions
{
    public static class ResultSetActions
    {
        public static void SelectElement(WineListPage page, int elemetIndex, Waiters wait)
        {
            wait.WaitForVisibilityElement(By.CssSelector(page.LocResSet));
            page.ResultSet[elemetIndex].Click();
        }
    }
}

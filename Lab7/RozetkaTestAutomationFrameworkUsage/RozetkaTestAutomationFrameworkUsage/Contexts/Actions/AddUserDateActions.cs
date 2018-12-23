using RozetkaTestAutomationFrameworkUsage.Helpers;
using RozetkaTestAutomationFrameworkUsage.Pages;


namespace RozetkaTestAutomationFrameworkUsage.Contexts.Actions
{
    public class AddUserDateActions
    {

        public static void Add(CheckOutPage page, User user)
        {
            page.Enter(page.Name, user.Getname());
            page.Enter(page.Phone, user.Getphone());
            page.Enter(page.Email, user.Getemail());
        }
    }
}

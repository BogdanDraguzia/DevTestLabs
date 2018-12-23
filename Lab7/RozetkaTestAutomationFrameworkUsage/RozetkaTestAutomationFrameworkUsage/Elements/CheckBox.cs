using OpenQA.Selenium;

namespace RozetkaTestAutomationFrameworkUsage.Elements
{
    public class CheckBox : Element
    {
        public CheckBox(IWebElement nativeElement) : base(nativeElement) { }

        public CheckBox Click(CheckBox element)
        {
            if(!element.Selected) element.Click();
            return this;
        }
    }
}

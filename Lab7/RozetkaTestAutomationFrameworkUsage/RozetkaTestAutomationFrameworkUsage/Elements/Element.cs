using System.Collections.ObjectModel;
using System.Drawing;
using OpenQA.Selenium;

namespace RozetkaTestAutomationFrameworkUsage.Elements
{
    public abstract class Element : IWebElement
    {
        private readonly IWebElement _nativeElement;

        public Element(IWebElement nativeElement)
        {
            _nativeElement = nativeElement;
        }

        public void Clear()
        {
            _nativeElement.Clear();
        }

        public void SendKeys(string value)
        {
            _nativeElement.SendKeys(value);
        }

        public void Submit()
        {
            _nativeElement.Submit();
        }

        public void Click()
        {
            _nativeElement.Click();
        }

        public string GetAttribute(string attributeName)
        {
            return _nativeElement.GetAttribute(attributeName);
        }

        public string GetProperty(string propertyName)
        {
            return _nativeElement.GetProperty(propertyName);
        }

        public string GetCssValue(string propertyName)
        {
            return _nativeElement.GetCssValue(propertyName);
        }

        public string TagName => _nativeElement.TagName;

        public string Text => _nativeElement.Text;

        public bool Enabled => _nativeElement.Enabled;

        public bool Selected => _nativeElement.Selected;

        public Point Location => _nativeElement.Location;

        public Size Size => _nativeElement.Size;

        public bool Displayed => _nativeElement.Displayed;

        public IWebElement FindElement(By by)
        {
            return _nativeElement.FindElement(by);
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return _nativeElement.FindElements(by);
        }
    }
}
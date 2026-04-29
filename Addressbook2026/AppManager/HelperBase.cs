using OpenQA.Selenium;

namespace Addressbook2026.Helpers;

public class HelperBase
{
    protected IWebDriver webDriver;

    public HelperBase(IWebDriver webDriver)
    {
        this.webDriver = webDriver; 
    }

    public void InsertText(By locator, string text)
    {
        if (text != null)
        {
            webDriver.FindElement(locator).Click();
            webDriver.FindElement(locator).Clear();
            webDriver.FindElement(locator).SendKeys(text);
        }
    }
}

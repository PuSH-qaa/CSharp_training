using OpenQA.Selenium;

namespace Addressbook2026.Helpers;

public class NavigationHelper : HelperBase
{
    public NavigationHelper(IWebDriver webDriver) : base(webDriver)
    {
    }

    public void ClickHome()
    {
        webDriver.FindElement(By.XPath("//*[@id= 'nav']//a[contains(normalize-space(), 'home')]")).Click();
    }

    public void ClickAddNew()
    {
        webDriver.FindElement(By.XPath("//*[@id= 'nav']//a[contains(normalize-space(), 'add new')]")).Click();
    }

    public void ClickGroups()
    {
        webDriver.FindElement(By.XPath("//*[@id= 'nav']//a[contains(normalize-space(), 'groups')]")).Click();
    }

}

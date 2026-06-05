using OpenQA.Selenium;

namespace Addressbook2026.Helpers;

public class NavigationHelper : HelperBase
{
    private string baseUrl;
    public NavigationHelper(IWebDriver webDriver, string baseUrl) : base(webDriver)
    {
        this.baseUrl = baseUrl;
    }

    public void ClickHome()
    {
        if (!(webDriver.Url == baseUrl))
            webDriver.FindElement(By.XPath("//*[@id= 'nav']//a[contains(normalize-space(), 'home')]")).Click();
    }

    public void ClickAddNew()
    {
        if (!(webDriver.Url == baseUrl + "/edit.php"))
            webDriver.FindElement(By.XPath("//*[@id= 'nav']//a[contains(normalize-space(), 'add new')]")).Click();
    }

    public void ClickGroups()
    {
        if (!(webDriver.Url == baseUrl + "/group.php" && IsElementPresent(By.Name("new"))))
        webDriver.FindElement(By.XPath("//*[@id= 'nav']//a[contains(normalize-space(), 'groups')]")).Click();
    }
}

using Addressbook2026.Helpers;
using OpenQA.Selenium;

namespace Addressbook2026;

public class LoginHelper : HelperBase
{
    private string baseUrl;

    public LoginHelper(IWebDriver driver, string baseURL) : base(driver)
    {
        this.baseUrl = baseURL;
    }

    public void OpenAddressbookPage()
    {
        webDriver.Navigate().GoToUrl(baseUrl);
    }

    public void EnterLoginAndPass(AccountData accountData)
    {
        webDriver.FindElement(By.Name("user")).Click();
        webDriver.FindElement(By.Name("user")).Clear();
        webDriver.FindElement(By.Name("user")).SendKeys(accountData.UserName);
        webDriver.FindElement(By.Name("pass")).Click();
        webDriver.FindElement(By.Name("pass")).Clear();
        webDriver.FindElement(By.Name("pass")).SendKeys(accountData.Password);
        webDriver.FindElement(By.XPath("//input[@value='Login']")).Submit();
    }

    public void ClickLogout()
    {
        webDriver.FindElement(By.XPath("//*[@name = 'logout']/a")).Submit();
    }
}

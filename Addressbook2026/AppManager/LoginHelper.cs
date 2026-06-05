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
        if (IsLoggedIn())
        {
            if (IsLoggedIn(accountData))
            {
                return;
            }

            ClickLogout();
        }
        InsertText(By.Name("user"), accountData.UserName);
        InsertText(By.Name("pass"), accountData.Password);
        webDriver.FindElement(By.XPath("//input[@value='Login']")).Click();
    }

    public void ClickLogout()
    {
        if (IsLoggedIn())
        webDriver.FindElement(By.XPath("//*[@name = 'logout']/a")).Click();
    }

    public bool IsLoggedIn()
    {
        return IsElementPresent(By.Name("logout"));
    }

    public bool IsLoggedIn(AccountData accountData)
    {
        return IsLoggedIn() &&
            webDriver.FindElement(By.Name("logout")).FindElement(By.TagName("b")).Text 
            == "(" + accountData.UserName + ")";
    }
}

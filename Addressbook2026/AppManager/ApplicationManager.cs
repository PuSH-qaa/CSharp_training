using Addressbook2026.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Addressbook2026;

public class ApplicationManager
{
    public IWebDriver? webDriver;
    public string? baseURL;


    public LoginHelper? LoginHelper { get; set; }

    public NavigationHelper? NavigationHelper { get; set; }

    public GroupHelper? GroupHelper { get; set; }

    public ContactHelper? ContactHelper { get; set; }

    

    public ApplicationManager()
    {
        webDriver = new ChromeDriver();
        baseURL = "http://localhost/addressbook/";

        LoginHelper = new LoginHelper(webDriver, baseURL);
        NavigationHelper = new NavigationHelper(webDriver);
        GroupHelper = new GroupHelper(webDriver);
        ContactHelper = new ContactHelper(webDriver);
    }

    public void Stop()
    {
        webDriver.Quit();
        webDriver.Dispose();
    }
}

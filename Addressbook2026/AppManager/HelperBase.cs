using OpenQA.Selenium;

namespace Addressbook2026.Helpers;

public class HelperBase
{
    protected IWebDriver webDriver;

    public HelperBase(IWebDriver webDriver)
    {
        this.webDriver = webDriver; 
    }
}

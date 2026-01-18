using OpenQA.Selenium;

namespace Addressbook2026.Helpers;

public class ContactHelper : HelperBase
{
    public ContactHelper(IWebDriver webDriver) : base(webDriver)
    {
    }

    public void CreateNewContact(ContactData contactData)
    {
        webDriver.FindElement(By.Name("firstname")).Click();
        webDriver.FindElement(By.Name("firstname")).Clear();
        webDriver.FindElement(By.Name("firstname")).SendKeys(contactData.FirstName);
        webDriver.FindElement(By.Name("lastname")).Click();
        webDriver.FindElement(By.Name("lastname")).Clear();
        webDriver.FindElement(By.Name("lastname")).SendKeys(contactData.LastName);
        var EnterButton = webDriver.FindElements(By.Name("submit")).LastOrDefault();
        EnterButton.Submit();
    }

    public void ClickHomePageAfterAnyActionWithContact()
    {
        webDriver.FindElement(By.XPath("//*[@class='msgbox']//*[contains(text(),'home page')]")).Click();
    }
}

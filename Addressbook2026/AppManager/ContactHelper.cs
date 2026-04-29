using OpenQA.Selenium;

namespace Addressbook2026.Helpers;

public class ContactHelper : HelperBase
{
    public ContactHelper(IWebDriver webDriver) : base(webDriver)
    {
    }

    public void CreateNewContact(ContactData contactData)
    {
        FillContactData(contactData);
        webDriver.FindElements(By.Name("submit")).LastOrDefault().Click();
    }

    public void UpdateContact(ContactData contactData)
    {
        FillContactData(contactData);
        webDriver.FindElements(By.Name("update")).LastOrDefault().Click();
    }

    public void ClickHomePageAfterAnyActionWithContact()
    {
        webDriver.FindElement(By.XPath("//*[@class='msgbox']//*[contains(text(),'home page')]")).Click();
    }

    public void SelectContact(ContactData contactData)
    {
        webDriver.FindElement(By.XPath($"//tr[td[normalize-space()='{contactData.FirstName}']"
            + $"and td[normalize-space()='{contactData.LastName}']]//input[@type='checkbox']")).Click();
    }

    public void InitEditContact(ContactData contactData)
    {
        webDriver.FindElement(By.XPath($"//tr[td[normalize-space()='{contactData.FirstName}']"
            + $"and td[normalize-space()='{contactData.LastName}']]//a[img[@title='Edit']]")).Click();
    }

    public void RemoveContact()
    {
        webDriver.FindElement(By.Name("delete")).Click();
    }

    private void FillContactData(ContactData contactData)
    {
        InsertText(By.Name("firstname"), contactData.FirstName);
        InsertText(By.Name("lastname"), contactData.LastName);
    }
}

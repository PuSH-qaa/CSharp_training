using OpenQA.Selenium;


namespace Addressbook2026.Helpers;

public class GroupHelper : HelperBase
{
    public GroupHelper(IWebDriver webDriver) : base(webDriver)
    {
    }

    public void InitNewGroupCreation()
    {
        webDriver.FindElement(By.Name("new")).Submit();
    }

    public void CreateNewGroup(GroupData groupData)
    {
        webDriver.FindElement(By.Name("group_name")).Click();
        webDriver.FindElement(By.Name("group_name")).Clear();
        webDriver.FindElement(By.Name("group_name")).SendKeys(groupData.GroupName);
        webDriver.FindElement(By.Name("group_header")).Click();
        webDriver.FindElement(By.Name("group_header")).Clear();
        webDriver.FindElement(By.Name("group_header")).SendKeys(groupData.GroupHeader);
        webDriver.FindElement(By.Name("group_footer")).Click();
        webDriver.FindElement(By.Name("group_footer")).Clear();
        webDriver.FindElement(By.Name("group_footer")).SendKeys(groupData.GroupFooter);
        webDriver.FindElement(By.XPath("//input[@value='Enter information']")).Submit();
    }

    public void SelectAddedGroup(GroupData groupData)
    {
        webDriver.FindElement(By.XPath($"//span[contains(normalize-space(.), " +
            $"'{groupData.GroupName}')]//input")).Click();
    }

    public void RemoveGroup()
    {
        webDriver.FindElements(By.Name("delete")).LastOrDefault().Submit();
    }

    public void ClickHomePageAfterAnyActionWithGroup()
    {
        webDriver.FindElement(By.XPath("//i[text() = 'return to the ']/*[normalize-space() = 'group page']")).Click();
    }
}

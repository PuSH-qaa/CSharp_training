using OpenQA.Selenium;

namespace Addressbook2026.Helpers;

public class GroupHelper : HelperBase
{
    public GroupHelper(IWebDriver webDriver) : base(webDriver)
    {
    }

    public void InitNewGroupCreation()
    {
        webDriver.FindElement(By.Name("new")).Click();
    }

    public void CreateNewGroup(GroupData groupData)
    {
        FillGroupData(groupData);
        webDriver.FindElement(By.XPath("//input[@value='Enter information']")).Click();
    }

    public void UpdateGroupData(GroupData groupData)
    {
        FillGroupData(groupData);
        webDriver.FindElement(By.XPath("//input[@value='Update']")).Click();
    }

    public void SelectAddedGroup(GroupData groupData)
    {
        webDriver.FindElement(By.XPath($"//span[contains(normalize-space(.), " +
            $"'{groupData.GroupName}')]//input")).Click();
    }

    public void RemoveGroup()
    {
        webDriver.FindElements(By.Name("delete")).LastOrDefault().Click();
    }

    public void InitEditGroup()
    {
        webDriver.FindElements(By.Name("edit")).FirstOrDefault().Click();
    }

    public void ClickGroupPageAfterAnyActionWithGroup()
    {
        webDriver.FindElement(By.XPath("//i[text() = 'return to the ']/*[normalize-space() = 'group page']")).Click();
    }

    private void FillGroupData(GroupData groupData)
    {
        InsertText(By.Name("group_name"), groupData.GroupName);
        InsertText(By.Name("group_header"), groupData.GroupHeader);
        InsertText(By.Name("group_footer"), groupData.GroupFooter);
    }
}

namespace Addressbook2026;

internal class GroupRemovalTests : TestBase
{
    [Test]
    public void RemoveGroupTest()
    {
        applicationManager.LoginHelper.OpenAddressbookPage();
        applicationManager.LoginHelper.EnterLoginAndPass(new AccountData("admin", "secret"));
        applicationManager.NavigationHelper.ClickGroups();
        applicationManager.GroupHelper.InitNewGroupCreation();
        GroupData groupData = new GroupData(
            random.Next(1, 999).ToString()
            , random.Next(1, 999).ToString()
            , random.Next(1, 999).ToString());
        applicationManager.GroupHelper.CreateNewGroup(groupData);
        applicationManager.GroupHelper.ClickHomePageAfterAnyActionWithGroup();
        applicationManager.GroupHelper.SelectAddedGroup(groupData);
        applicationManager.GroupHelper.RemoveGroup();
        applicationManager.GroupHelper.ClickHomePageAfterAnyActionWithGroup();
    }
}

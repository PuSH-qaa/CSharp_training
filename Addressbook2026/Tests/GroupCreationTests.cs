namespace Addressbook2026;

[TestFixture]
public class GroupCreationTests : TestBase
{
    [Test]
    public void AddNewGroupTest()
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
    }
}
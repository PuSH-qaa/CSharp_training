namespace Addressbook2026;

[TestFixture]
public class GroupCreationTests : TestBase
{
    [Test]
    public void AddNewGroupTest()
    {
        applicationManager.NavigationHelper.ClickGroups();
        applicationManager.GroupHelper.InitNewGroupCreation();
        GroupData groupData = new GroupData(
            random.Next(1, 999).ToString()
            , random.Next(1, 999).ToString()
            , random.Next(1, 999).ToString());
        applicationManager.GroupHelper.CreateNewGroup(groupData);
        applicationManager.GroupHelper.ClickGroupPageAfterAnyActionWithGroup();
    }

    [Test]
    public void AddNewGroupWithEmptyNamesTest()
    {
        applicationManager.NavigationHelper.ClickGroups();
        applicationManager.GroupHelper.InitNewGroupCreation();
        GroupData groupData = new GroupData(
            ""
            , ""
            , "");
        applicationManager.GroupHelper.CreateNewGroup(groupData);
        applicationManager.GroupHelper.ClickGroupPageAfterAnyActionWithGroup();
    }
}
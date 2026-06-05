namespace Addressbook2026;

[TestFixture]
public class GroupRemovalTests : AuthTestBase
{
    [Test]
    public void RemoveGroupTest()
    {
        applicationManager.NavigationHelper.ClickGroups();
        applicationManager.GroupHelper.InitNewGroupCreation();
        GroupData groupData = new GroupData(
            random.Next(1, 999).ToString()
            , random.Next(1, 999).ToString()
            , random.Next(1, 999).ToString());
        applicationManager.GroupHelper.CreateNewGroup(groupData);
        applicationManager.GroupHelper.ClickGroupPageAfterAnyActionWithGroup();
        applicationManager.GroupHelper.SelectAddedGroup(groupData);
        applicationManager.GroupHelper.RemoveGroup();
        applicationManager.GroupHelper.ClickGroupPageAfterAnyActionWithGroup();
    }
}

namespace Addressbook2026;

[TestFixture]
public class GroupCreationTests : AuthTestBase
{
    [Test]
    public void AddNewGroupTest()
    {
        applicationManager.NavigationHelper.ClickGroups();

        var oldGroupList = applicationManager.GroupHelper.GetGroupList();

        applicationManager.GroupHelper.InitNewGroupCreation();
        GroupData groupData = new GroupData(
            random.Next(1, 999).ToString()
            , random.Next(1, 999).ToString()
            , random.Next(1, 999).ToString());
        applicationManager.GroupHelper.CreateNewGroup(groupData);
        applicationManager.GroupHelper.ClickGroupPageAfterAnyActionWithGroup();

        var  newGroupList = applicationManager.GroupHelper.GetGroupList();

        Assert.That(oldGroupList.Count + 1, Is.EqualTo(newGroupList.Count));
    }

    [Test]
    public void AddNewGroupWithEmptyNamesTest()
    {
        applicationManager.NavigationHelper.ClickGroups();

        var oldGroupList = applicationManager.GroupHelper.GetGroupList();

        applicationManager.GroupHelper.InitNewGroupCreation();
        GroupData groupData = new GroupData(
            ""
            , ""
            , "");
        applicationManager.GroupHelper.CreateNewGroup(groupData);
        applicationManager.GroupHelper.ClickGroupPageAfterAnyActionWithGroup();

        var newGroupList = applicationManager.GroupHelper.GetGroupList();

        Assert.That(oldGroupList.Count + 1, Is.EqualTo(newGroupList.Count));
    }
}
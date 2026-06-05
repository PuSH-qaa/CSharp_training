namespace Addressbook2026;

[TestFixture]
public class EditGroupTests : AuthTestBase
{
    [Test]
    public void EditGroupTest()
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
        applicationManager.GroupHelper.InitEditGroup();
        groupData.GroupName = "NewName" + groupData.GroupName;
        groupData.GroupHeader = "NewHeader" + groupData.GroupHeader;
        groupData.GroupFooter = "NewFooter" + groupData.GroupFooter;
        applicationManager.GroupHelper.UpdateGroupData(groupData);
        applicationManager.GroupHelper.ClickGroupPageAfterAnyActionWithGroup();
    }

}

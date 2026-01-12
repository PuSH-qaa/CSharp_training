namespace Addressbook2026;

internal class GroupRemovalTests : TestBase
{
    [Test]
    public void RemoveGroupTest()
    {
        OpenHomePage();
        EnterLoginAndPass(new AccountData("admin", "secret"));
        OpenGroupPage();
        InitNewGroupCreation();
        GroupData groupData = new GroupData(
            random.Next(1, 999).ToString()
            , random.Next(1, 999).ToString()
            , random.Next(1, 999).ToString());
        CreateNewGroup(groupData);
        ClickHomePageAfterAnyActionWithGroup();
        SelectAddedGroup(groupData);
        RemoveGroup();
        ClickHomePageAfterAnyActionWithGroup();
    }
}

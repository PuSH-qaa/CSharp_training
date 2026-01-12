namespace Addressbook2026;

[TestFixture]
public class GroupCreationTests : TestBase
{
    [Test]
    public void AddNewGroupTest()
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
    }
}
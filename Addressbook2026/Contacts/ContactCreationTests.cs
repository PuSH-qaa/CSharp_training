namespace Addressbook2026;

[TestFixture]
public class ContactCreationTests : TestBase
{
    [Test]
    public void AddNewContactTest()
    {
        OpenHomePage();
        EnterLoginAndPass(new AccountData("admin", "secret"));
        InitNewContactCreation();
        ContactData contactData = new ContactData(
            random.Next(1, 999).ToString("D5")
            , random.Next(1, 999).ToString("D5"));
        CreateNewContact(contactData);
        ClickHomePageAfterAnyActionWithContact();
    }


}
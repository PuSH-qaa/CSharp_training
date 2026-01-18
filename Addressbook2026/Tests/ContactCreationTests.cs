namespace Addressbook2026;

[TestFixture]
public class ContactCreationTests : TestBase
{
    [Test]
    public void AddNewContactTest()
    {
        applicationManager.LoginHelper.OpenAddressbookPage();
        applicationManager.LoginHelper.EnterLoginAndPass(new AccountData("admin", "secret"));
        applicationManager.NavigationHelper.ClickAddNew();
        ContactData contactData = new ContactData(
            random.Next(1, 999).ToString("D5")
            , random.Next(1, 999).ToString("D5"));
        applicationManager.ContactHelper.CreateNewContact(contactData);
        applicationManager.ContactHelper.ClickHomePageAfterAnyActionWithContact();
    }


}
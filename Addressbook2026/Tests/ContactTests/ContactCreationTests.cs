namespace Addressbook2026;

[TestFixture]
public class ContactCreationTests : AuthTestBase
{
    [Test]
    public void AddNewContactTest()
    {
        applicationManager.NavigationHelper.ClickAddNew();
        ContactData contactData = new ContactData(
            random.Next(1, 999).ToString("D5")
            , random.Next(1, 999).ToString("D5"));
        applicationManager.ContactHelper.CreateNewContact(contactData);
        applicationManager.ContactHelper.ClickHomePageAfterAnyActionWithContact();
    }

    [Test]
    public void AddNewContactWithEmptyFieldsTest()
    {
        applicationManager.NavigationHelper.ClickAddNew();
        ContactData contactData = new ContactData(
            ""
            , "");
        applicationManager.ContactHelper.CreateNewContact(contactData);
        applicationManager.ContactHelper.ClickHomePageAfterAnyActionWithContact();
    }
}
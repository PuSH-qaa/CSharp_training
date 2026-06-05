namespace Addressbook2026;

[TestFixture]
public class EditContactTests : AuthTestBase
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

        applicationManager.ContactHelper.InitEditContact(contactData);
        contactData.FirstName = "NewFirstName" + contactData.FirstName;
        contactData.LastName = "NewLastName" + contactData.LastName;
        applicationManager.ContactHelper.UpdateContact(contactData);
        applicationManager.ContactHelper.ClickHomePageAfterAnyActionWithContact();
    }
}

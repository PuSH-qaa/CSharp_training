namespace Addressbook2026;

[TestFixture]
public class ContactRemovalTests : TestBase
{
    [Test]
    public void RemoveContactTest()
    {
        applicationManager.NavigationHelper.ClickAddNew();
        ContactData contactData = new ContactData(
            random.Next(1, 999).ToString("D5")
            , random.Next(1, 999).ToString("D5"));
        applicationManager.ContactHelper.CreateNewContact(contactData);
        applicationManager.ContactHelper.ClickHomePageAfterAnyActionWithContact();
        applicationManager.ContactHelper.SelectContact(contactData);
        applicationManager.ContactHelper.RemoveContact();
        applicationManager.ContactHelper.ClickHomePageAfterAnyActionWithContact();
    }
}

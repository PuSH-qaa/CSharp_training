namespace Addressbook2026;

internal class ContactData
{
    public ContactData(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string FirstName { get; set; }

    public string LastName { get; set; }
}

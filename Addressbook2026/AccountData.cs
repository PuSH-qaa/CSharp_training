namespace Addressbook2026;

internal class AccountData
{
    public AccountData(string username, string password) 
    {
        UserName = username;
        Password = password;
    }

    public string UserName { get; set; }
    public string Password { get; set; }
}

using NUnit.Framework;

namespace Addressbook2026;

[TestFixture]
public class LoginTests : TestBase
{
    [Test]
    public void LoginWithValidCredentials()
    {
        AccountData account = new AccountData("admin", "secret");

        applicationManager.LoginHelper.ClickLogout();
        applicationManager.LoginHelper.EnterLoginAndPass(account);

        Assert.That(applicationManager.LoginHelper.IsLoggedIn(account));
    }

    [Test]
    public void LoginWithInvalidCredentials()
    {
        AccountData account = new AccountData("admin", "secret1");

        applicationManager.LoginHelper.ClickLogout();
        applicationManager.LoginHelper.EnterLoginAndPass(account);

        Assert.That(!applicationManager.LoginHelper.IsLoggedIn(account));
    }
}

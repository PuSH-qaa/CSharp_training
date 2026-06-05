
namespace Addressbook2026;

public class AuthTestBase : TestBase
{
    [OneTimeSetUp]
    public void SetupLogin()
    {
        applicationManager.LoginHelper.EnterLoginAndPass(new AccountData("admin", "secret"));
    }
}

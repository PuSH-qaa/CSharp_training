namespace Addressbook2026;

[SetUpFixture]
public class TestSuiteFixture
{
    [OneTimeSetUp]
    public void GlobalSetup()
    {
        ApplicationManager app = ApplicationManager.GetInstance();
        app.LoginHelper.OpenAddressbookPage();
        app.LoginHelper.EnterLoginAndPass(new AccountData("admin", "secret"));
    }

    [OneTimeTearDown]
    public void Cleanup()
    {
        ApplicationManager.GetInstance().Stop();
    }
}

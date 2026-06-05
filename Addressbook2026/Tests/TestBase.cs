namespace Addressbook2026;

public class TestBase
{
    protected Random? random = new();

    protected ApplicationManager applicationManager;

    [OneTimeSetUp]
    public void SetupApplicationManager()
    {
        applicationManager = new ApplicationManager();
    }

    [OneTimeTearDown]
    public void StopApplicationManager() 
    {
        applicationManager?.Stop();
    }
}
namespace Addressbook2026;

public class TestBase
{
    protected Random? random;

    protected ApplicationManager applicationManager;

    [SetUp]
    public void SetupTest()
    {
        applicationManager = new ApplicationManager();

        random = new Random();
    }

    [TearDown]
    public void TeardownTest()
    {
        applicationManager.Stop();
    }
}

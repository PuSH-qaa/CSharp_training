namespace Addressbook2026;

public class TestBase
{
    protected Random? random;

    protected ApplicationManager applicationManager;

    [SetUp]
    public void SetupTest()
    {
        applicationManager = ApplicationManager.GetInstance();
        random = new Random();
    }
}

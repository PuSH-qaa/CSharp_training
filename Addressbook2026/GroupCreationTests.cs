using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Addressbook2026;

[TestFixture]
public class GroupCreationTests
{
    private IWebDriver webDriver;
    private string baseURL;
    private Random random;


    [SetUp]
    public void SetupTest()
    {
        webDriver = new ChromeDriver();
        baseURL = "http://localhost/addressbook/";
        random = new Random();
    }

    [TearDown]
    public void TeardownTest()
    {
        webDriver.Quit();
        webDriver.Dispose();
    }

    [Test]
    public void AddNewGroupTest()
    {
        OpenHomePage();
        EnterLoginAndPass(new AccountData("admin", "secret"));
        OpenGroupPage();
        InitNewGroupCreation();
        CreateNewGroup(new GroupData(
            random.Next(1, 999).ToString()
            , random.Next(1, 999).ToString()
            , random.Next(1, 999).ToString()));
        ClickHomePageOnConfirmationPage();
    }

    private void ClickHomePageOnConfirmationPage()
    {
        webDriver.FindElement(By.XPath("//i[text() = 'return to the ']/*[normalize-space() = 'group page']")).Click();
    }

    private void CreateNewGroup(GroupData groupData)
    {
        webDriver.FindElement(By.Name("group_name")).Click();
        webDriver.FindElement(By.Name("group_name")).Clear();
        webDriver.FindElement(By.Name("group_name")).SendKeys(groupData.GroupName);
        webDriver.FindElement(By.Name("group_header")).Click();
        webDriver.FindElement(By.Name("group_header")).Clear();
        webDriver.FindElement(By.Name("group_header")).SendKeys(groupData.GroupHeader);
        webDriver.FindElement(By.Name("group_footer")).Click();
        webDriver.FindElement(By.Name("group_footer")).Clear();
        webDriver.FindElement(By.Name("group_footer")).SendKeys(groupData.GroupFooter);
        webDriver.FindElement(By.XPath("//input[@value='Enter information']")).Submit();
    }

    private void InitNewGroupCreation()
    {
        webDriver.FindElement(By.Name("new")).Submit();
    }

    private void EnterLoginAndPass(AccountData accountData)
    {
        webDriver.FindElement(By.Name("user")).Click();
        webDriver.FindElement(By.Name("user")).Clear();
        webDriver.FindElement(By.Name("user")).SendKeys(accountData.UserName);
        webDriver.FindElement(By.Name("pass")).Click();
        webDriver.FindElement(By.Name("pass")).Clear();
        webDriver.FindElement(By.Name("pass")).SendKeys(accountData.Password);
        webDriver.FindElement(By.XPath("//input[@value='Login']")).Submit();
    }

    private void OpenGroupPage()
    {
        webDriver.FindElement(By.XPath("//*[normalize-space()='groups']")).Click();
    }

    private void OpenHomePage()
    {
        webDriver.Navigate().GoToUrl(baseURL);
    }
}
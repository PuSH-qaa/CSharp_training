using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Addressbook2026;

[TestFixture]
public class ContactCreationTests
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
    public void AddNewContactTest()
    {
        OpenHomePage();
        EnterLoginAndPass(new AccountData("admin", "secret"));
        InitNewContactCreation();
        CreateNewContact(new ContactData(
            random.Next(1, 999).ToString("D5")
            , random.Next(1, 999).ToString("D5")));
        ClickHomePageOnConfirmationPage();
    }

    private void OpenHomePage()
    {
        webDriver.Navigate().GoToUrl(baseURL);
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
        webDriver.FindElement(By.XPath("//*[normalize-space()='groups']")).Click();
    }

    private void InitNewContactCreation()
    {
        webDriver.FindElement(By.XPath("//*[normalize-space()='add new']")).Click();
    }

    private void CreateNewContact(ContactData contactData)
    {
        webDriver.FindElement(By.Name("firstname")).Click();
        webDriver.FindElement(By.Name("firstname")).Clear();
        webDriver.FindElement(By.Name("firstname")).SendKeys(contactData.FirstName);
        webDriver.FindElement(By.Name("lastname")).Click();
        webDriver.FindElement(By.Name("lastname")).Clear();
        webDriver.FindElement(By.Name("lastname")).SendKeys(contactData.LastName);
        var EnterButton = webDriver.FindElements(By.Name("submit")).LastOrDefault();
        EnterButton.Submit();
    }

    private void ClickHomePageOnConfirmationPage()
    {
        webDriver.FindElement(By.XPath("//*[@class='msgbox']//*[contains(text(),'home page')]")).Click();
    }
}
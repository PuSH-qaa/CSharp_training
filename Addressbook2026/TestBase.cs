using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Addressbook2026
{
    public class TestBase
    {
        protected IWebDriver webDriver;
        protected string baseURL;
        protected Random random;

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

        protected void OpenHomePage()
        {
            webDriver.Navigate().GoToUrl(baseURL);
        }

        protected void EnterLoginAndPass(AccountData accountData)
        {
            webDriver.FindElement(By.Name("user")).Click();
            webDriver.FindElement(By.Name("user")).Clear();
            webDriver.FindElement(By.Name("user")).SendKeys(accountData.UserName);
            webDriver.FindElement(By.Name("pass")).Click();
            webDriver.FindElement(By.Name("pass")).Clear();
            webDriver.FindElement(By.Name("pass")).SendKeys(accountData.Password);
            webDriver.FindElement(By.XPath("//input[@value='Login']")).Submit();
        }

        protected void ClickHomePageAfterAnyActionWithGroup()
        {
            webDriver.FindElement(By.XPath("//i[text() = 'return to the ']/*[normalize-space() = 'group page']")).Click();
        }

        protected void CreateNewGroup(GroupData groupData)
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

        protected void SelectAddedGroup(GroupData groupData)
        {
            webDriver.FindElement(By.XPath($"//span[contains(normalize-space(.), " +
                $"'{groupData.GroupName}')]//input")).Click();
        }

        protected void RemoveGroup()
        {
            webDriver.FindElements(By.Name("delete")).LastOrDefault().Submit();
        }

        protected void InitNewGroupCreation()
        {
            webDriver.FindElement(By.Name("new")).Submit();
        }

        protected void OpenGroupPage()
        {
            webDriver.FindElement(By.XPath("//*[normalize-space()='groups']")).Click();
        }

        protected void InitNewContactCreation()
        {
            webDriver.FindElement(By.XPath("//*[normalize-space()='add new']")).Click();
        }

        protected void CreateNewContact(ContactData contactData)
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

        protected void ClickHomePageAfterAnyActionWithContact()
        {
            webDriver.FindElement(By.XPath("//*[@class='msgbox']//*[contains(text(),'home page')]")).Click();
        }
    }
}

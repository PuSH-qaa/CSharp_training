using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Addressbook2026;

[TestFixture]
public class UnitTest1
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
        webDriver.Navigate().GoToUrl(baseURL);
        webDriver.FindElement(By.Name("user")).Click(); 
        webDriver.FindElement(By.Name("user")).Clear(); 
        webDriver.FindElement(By.Name("user")).SendKeys("admin"); 
        webDriver.FindElement(By.Name("pass")).Click(); 
        webDriver.FindElement(By.Name("pass")).Clear(); 
        webDriver.FindElement(By.Name("pass")).SendKeys("secret"); 
        webDriver.FindElement(By.XPath("//input[@value='Login']")).Submit(); 
        webDriver.FindElement(By.XPath("//*[normalize-space()='groups']")).Click(); 
        webDriver.FindElement(By.Name("new")).Submit(); 
        webDriver.FindElement(By.Name("group_name")).Click(); 
        webDriver.FindElement(By.Name("group_name")).Clear(); 
        webDriver.FindElement(By.Name("group_name")).SendKeys(random.Next(1, 999).ToString()); 
        webDriver.FindElement(By.Name("group_header")).Click(); 
        webDriver.FindElement(By.Name("group_header")).Clear(); 
        webDriver.FindElement(By.Name("group_header")).SendKeys(random.Next(1, 999).ToString()); 
        webDriver.FindElement(By.Name("group_footer")).Click(); 
        webDriver.FindElement(By.Name("group_footer")).Clear(); 
        webDriver.FindElement(By.Name("group_footer")).SendKeys(random.Next(1, 999).ToString()); 
        webDriver.FindElement(By.XPath("//input[@value='Enter information']")).Submit(); 
        webDriver.FindElement(By.XPath("//i[text() = 'return to the ']/*[normalize-space() = 'group page']")).Click();
    }
}
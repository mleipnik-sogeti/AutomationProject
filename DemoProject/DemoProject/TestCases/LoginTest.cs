using DemoProject.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

namespace DemoProject.TestCases
{
    class LoginTest
    {
        [Test]
        public void LoginButton()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://developer.bestbuy.com/";

            // From homepage, click login button
            var homePage = new HomePage();
            PageFactory.InitElements(driver, homePage);
            homePage.Login.Click();

            // In login page, enter email and password and submit
            var loginPage = new LoginPage();
            PageFactory.InitElements(driver, loginPage);
            loginPage.UserName.SendKeys("abc@123.com");
            loginPage.Password.SendKeys("Password!?");
            loginPage.Submit.Click();

            // Close driver
            //driver.Quit();

        }
        
    }
}

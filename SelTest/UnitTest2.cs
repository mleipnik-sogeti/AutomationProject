using System;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SelBasic.BestBuy;

namespace sel_test
{
    public class UnitTest2
    {
        IWebDriver driver;
        [SetUp]
        public void ready()
        {
            driver = new FirefoxDriver(Environment.CurrentDirectory);

        }


        [Test]
        public void bbSignInTest()
        {
            driver.Url = "https://developer.bestbuy.com/";
            BBHome hpage = new BBHome(driver);
            LogInPage lpage = new LogInPage(hpage.driver);
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\smoodywo\Documents\practiceProjects\WHF_Practice\bestBuyLog.txt");
            hpage.loginBtn.Click();
            Thread.Sleep(1500);
            string pgTitle = driver.Title;
            Assert.That(pgTitle, Is.EqualTo("Sign In to Developer.BestBuy.com"));
            lpage.loginEmail(lines[0]);
            lpage.loginPassword(lines[1]);
            lpage.logInSnd();
            Thread.Sleep(1500);
            // IList<IWebElement> temp2 = bbCommon.driver.FindElements(By.LinkText("DASHBOARD"));
            Assert.That(driver.Title, Is.EqualTo("Best Buy | Official Online Store | Shop Now & Save"));
            driver.Url = "https://developer.bestbuy.com/";
            IList<IWebElement> temp = hpage.driver.FindElements(By.LinkText("DASHBOARD"));
            Assert.That(temp.Count, Is.EqualTo(1));

            // lpage.close();
            
        }

        [Test]
        public void BBHomeTest()
        {
            // page = new bbHome();
            driver.Url = "https://developer.bestbuy.com/";
            BBHome hpage = new BBHome(driver);
            Assert.That(hpage.title, Is.EqualTo("Best Buy Developer Portal"));
            hpage.documentation.Click();
            Assert.That(hpage.title, Is.EqualTo("Documentation"));
            hpage.support.Click();
            Assert.That(hpage.title, Is.EqualTo("Support"));
            hpage.apiStatus.Click();
            Assert.That(hpage.title, Is.EqualTo("API Status"));
            // page.home.Click();
            // Assert.That(page.title, Is.EqualTo("Best Buy Developer Portal"));
            // hpage.close();

        }

        [TearDown]
        public void cleanup()
        {
            driver.Close();
        }

    }
}
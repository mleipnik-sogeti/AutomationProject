using System;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SelBasic.BestBuy;

namespace SelTest
{
    public class UnitTest2
    {
        IWebDriver driver;
        [SetUp]
        public void ready()
        {
            driver = new FirefoxDriver(Environment.CurrentDirectory);
            driver.Url = "https://developer.bestbuy.com/";

        }


        [Test]
        public void bbSignInTest()
        {
            
            BBHome hpage = new BBHome(driver);
            LogInPage lpage = new LogInPage(hpage.driver);
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\smoodywo\Documents\practiceProjects\WHF_Practice\bestBuyLog.txt");
            hpage.loginBtn.Click();
            Thread.Sleep(2000);

            string pgTitle = driver.Title;
            Assert.That(pgTitle, Is.EqualTo("Sign In to Developer.BestBuy.com"));
            lpage.loginEmail(lines[0]);
            lpage.loginPassword(lines[1]);
            lpage.logInSnd();
            Thread.Sleep(2000);

            Assert.That(driver.Title, Is.EqualTo("Best Buy | Official Online Store | Shop Now & Save"));
            driver.Url = "https://developer.bestbuy.com/";
            IList<IWebElement> temp = hpage.driver.FindElements(By.LinkText("DASHBOARD"));
            Assert.That(temp.Count, Is.EqualTo(1));            
        }

        [Test]
        public void BBHeaderTest()
        {
            // driver.Url = "https://developer.bestbuy.com/";
            BBHome hpage = new BBHome(driver);
            Assert.That(hpage.title, Is.EqualTo("Best Buy Developer Portal"));
            hpage.documentation.Click();
            Assert.That(hpage.title, Is.EqualTo("Documentation"));
            hpage.support.Click();
            Assert.That(hpage.title, Is.EqualTo("Support"));
            hpage.apiStatus.Click();
            Assert.That(hpage.title, Is.EqualTo("API Status"));
        }

        [Test]
        [Category("HomePage")]
        public void BBHomeTestDoc()
        {
           BBHome hpage = new BBHome(driver); 
           hpage.docBdy.Click();
           Assert.That(hpage.title, Is.EqualTo("Documentation"));
        }

        [Test]
        [Category("HomePage")]
        public void BBHomeTestTApi()
        {
           BBHome hpage = new BBHome(driver); 
           hpage.tryApi.Click();
           Assert.That(hpage.title, Is.EqualTo("Best Buy APIs :: Query Builder"));
        }

        [Test]
        [Category("HomePage")]
        public void BBHomeTestPlyGrnd()
        {
           BBHome hpage = new BBHome(driver); 
           hpage.plyGrnd.Click();
           Assert.That(hpage.driver.Url, Is.EqualTo("https://github.com/BestBuy/api-playground"));
        }

        [Test]
        [Category("HomePage")]
        public void BBHomeTestDevSup()
        {
           BBHome hpage = new BBHome(driver); 
           hpage.devSup.Click();
           Assert.That(hpage.title, Is.EqualTo("Support"));
        }

        [TearDown]
        public void cleanup()
        {
            driver.Close();
        }

    }
}
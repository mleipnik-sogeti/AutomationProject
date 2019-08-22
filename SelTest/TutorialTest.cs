using System;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SelBasic.BestBuy;

namespace SelTest
{
    public class TutorialTest
    {
        IWebDriver driver;

        //Setup is run before every test case.
        // I have my set up set a driver and url as this would happen for every test
        [SetUp]
        public void ready()
        {
            driver = new FirefoxDriver(Environment.CurrentDirectory);
            driver.Url = "https://developer.bestbuy.com/";

        }

        //Test can have catagories as well as several other properties
        [Test]
        [Category("Tutorial")]
        public void bbSignInTest()
        {
            //Construct a home page object and a login page object
            //Get my username and password from a text file
            //In your Test case remember to create your own username and password and set its path
            BBHome hpage = new BBHome(driver);
            LogInPage lpage = new LogInPage(hpage.driver);
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\smoodywo\Documents\practiceProjects\WHF_Practice\bestBuyLog.txt");
            hpage.loginBtn.Click();
            Thread.Sleep(2000);

            //Moving over to the title page, send keys acquired from the text file from earlier
            //here we are also asserting that the previous link worked and that we are on the correct page
            string pgTitle = driver.Title;
            Assert.That(pgTitle, Is.EqualTo("Sign In to Developer.BestBuy.com"));
            lpage.loginEmail(lines[0]);
            lpage.loginPassword(lines[1]);
            lpage.logInSnd();
            Thread.Sleep(2000);

            //Here The assert statement test to make sure that the proper page has apeared and that the elements have changed.
            Assert.That(driver.Title, Is.EqualTo("Best Buy | Official Online Store | Shop Now & Save"));
            driver.Url = "https://developer.bestbuy.com/";
            IList<IWebElement> temp = hpage.driver.FindElements(By.LinkText("DASHBOARD"));
            Assert.That(temp.Count, Is.EqualTo(1));            
        }

        //TearDown in run after every test.
        [TearDown]
        public void cleanup()
        {
            driver.Close();
        }
        
    }
}
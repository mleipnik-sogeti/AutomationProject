
using System;
using OpenQA.Selenium;

//This class is for the common header accross all pages on the developer.besbuy.com
//It inherits form the selenium base class I created.
namespace SelBasic.BestBuy
{
    public class BBCommon : SelBase
    {
        
        // #############By definitions###############
        private By headerPth = By.ClassName("header");
        private By homeLinkPth = By.XPath("/html/body/div[1]/div[1]/div[1]/a");
        private By ourApisPth = By.LinkText("OUR APIS");
        private By documentationPth = By.LinkText("DOCUMENTATION");
        private By supportPth = By.LinkText("SUPPORT");
        private By logInPth = By.LinkText("LOGIN");
        private By signUpPth= By.LinkText("SIGN UP");
        private By apiStatusPth = By.LinkText("API STATUS");
        private By newsLetterPth = By.LinkText("NEWSLETTER");

        private By logOutPth = By.LinkText("LOGOUT");

        //#############Props###############################
        public IWebElement header => driver.FindElement(headerPth);

        public IWebElement home => driver.FindElement(homeLinkPth);

        public IWebElement ourApis => header.FindElement(ourApisPth);

        public IWebElement documentation => header.FindElement(documentationPth);

        public IWebElement support => header.FindElement(supportPth);

        public IWebElement loginBtn => header.FindElement(logInPth);

        public IWebElement signUpBtn => header.FindElement(signUpPth);

        public IWebElement apiStatus => header.FindElement(apiStatusPth);

        public IWebElement newsletter => header.FindElement(newsLetterPth);

        //########Constructors######################
        public BBCommon()
        {
            
        }
        public BBCommon(IWebDriver dvr)
        {
            driver = dvr;
            Console.WriteLine("completed base constructor");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        //Functions###########################
        public void logout()
        {
            if(driver.FindElement( By.LinkText("LOGOUT")).Displayed)
            {
                driver.FindElement( By.LinkText("LOGOUT")).Click();
            }
            else Console.WriteLine("not signed in");
        }
        public void signUp() => signUpBtn.Click();

    }
}
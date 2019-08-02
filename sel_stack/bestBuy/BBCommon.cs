
using System;
using OpenQA.Selenium;

namespace sel_stack.bestBuy
{
    public class BBCommon : SelBase
    {
        

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

        public BBCommon()
        {
            
        }
        public BBCommon(IWebDriver dvr)
        {
            driver = dvr;
            Console.WriteLine("completed base constructor");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }


        public IWebElement Header => driver.FindElement(headerPth);

        public IWebElement home => driver.FindElement(homeLinkPth);

        public IWebElement ourApis => Header.FindElement(ourApisPth);

        public IWebElement documentation => Header.FindElement(documentationPth);

        public IWebElement support => Header.FindElement(supportPth);

        public IWebElement loginBtn => Header.FindElement(logInPth);

        public IWebElement signUpBtn => Header.FindElement(signUpPth);

        public IWebElement apiStatus => Header.FindElement(apiStatusPth);

        public IWebElement newsletter => Header.FindElement(newsLetterPth);


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
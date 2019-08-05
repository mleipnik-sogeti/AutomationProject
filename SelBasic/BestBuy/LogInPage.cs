using System;
using System.Threading;
using OpenQA.Selenium;

namespace SelBasic.BestBuy
{
    public class LogInPage : SelBase
    {
        private By passwordPth = By.Id("fld-p1");
        private By emailPth = By.Id("fld-e");
        private By signInPth = By.XPath("/html/body/div[1]/section/main/div[1]/div/div/div/form/button");
        private By crtActPth = By.LinkText("Create Account");
        

        public LogInPage(IWebDriver dvr) => driver = dvr;

        public void loginEmail(string email)
        {
            IWebElement emailInput = driver.FindElement(emailPth);
            emailInput.SendKeys(email);
        }
         

        public void loginPassword(string password)
        {
            IWebElement pwInput = driver.FindElement(passwordPth);
            pwInput.SendKeys(password);
        } 

        public void logInSnd() => driver.FindElement(signInPth).Click();
        public void crtAct() => driver.FindElement(crtActPth).Click();
    }
}
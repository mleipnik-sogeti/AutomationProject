using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DemoProject.PageObjects
{
    class LoginPage
    {
        private IWebDriver driver;

        /* 
            Find username/email field by using its ID 
            Creates a PageObject and names it 'UserName'
        */
        [FindsBy(How = How.Id, Using = "fld-e")]
        public IWebElement UserName { get; set; }

        // Find password form field and creates PageObject Password
        [FindsBy(How = How.Id, Using = "fld-p1")]
        public IWebElement Password { get; set; }

        /* 
            Find submit/sign-in button by using its XPath
            Creates a PageObject and names it 'Submit'
        */
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/main/div[1]/div/div/div/form/button")]
        public IWebElement Submit { get; set; }

    }
}

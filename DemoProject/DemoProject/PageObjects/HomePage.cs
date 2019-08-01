using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DemoProject.PageObjects
{
    class HomePage
    {
        private IWebDriver driver;

        /* 
            Find login button by using its XPath 
            Creates a PageObject and names it 'Login'
        */
        
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div[1]/ul[1]/li/a[1]")]
        public IWebElement Login { get; set; }

    }
}

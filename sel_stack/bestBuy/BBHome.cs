using OpenQA.Selenium;


namespace sel_stack.bestBuy
{
    public class BBHome : BBCommon
    {
        private By getApiKeyPth = By.LinkText("Get API Key");
        public BBHome(IWebDriver dvr)
        {
            driver = dvr;
        }
        
        public IWebElement getApiKey() => driver.FindElement(getApiKeyPth);
    }
}
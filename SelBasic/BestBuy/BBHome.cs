using OpenQA.Selenium;


namespace SelBasic.BestBuy
{
    public class BBHome : BBCommon
    {
        private By apiKeyPth = By.LinkText("Get API Key");
        private By bodyPth = By.ClassName("maincontainer");
        private By documentPth = By.LinkText("Documentation");
        private By bodDocPth = By.LinkText("Documentation");
        private By tryApiPth = By.LinkText("Try our APIs");
        private By plyGrndPth = By.LinkText("API Playground");
        private By devSupPth = By.LinkText("Developer Support");

        public IWebElement docBdy => driver.FindElement(bodyPth).FindElement(bodDocPth);
        public IWebElement tryApi => driver.FindElement(bodyPth).FindElement(tryApiPth);
        public IWebElement plyGrnd => driver.FindElement(bodyPth).FindElement(plyGrndPth);
        public IWebElement devSup => driver.FindElement(bodyPth).FindElement(devSupPth);
        public BBHome(IWebDriver dvr)
        {
            driver = dvr;
        }
        
        public IWebElement getApiKey() => driver.FindElement(apiKeyPth);
    }
}
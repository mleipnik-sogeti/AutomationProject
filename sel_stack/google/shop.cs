using OpenQA.Selenium;
using System.Collections.Generic;

namespace google
{
    public class shop : common
    {
        private IWebElement _phones;
        public IWebElement phones
        {
            get { return driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div[1]/div[1]/div[3]/button[1]"));}
            set { _phones = value;}
        }
        
    }
}
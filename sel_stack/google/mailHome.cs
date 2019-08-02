using OpenQA.Selenium;
using System.Collections.Generic;

namespace google
{
    public class mailHome : common
    {
        private IWebElement _inbox;
        public IWebElement inbox
        {
            get { return driver.FindElement(By.Id(":4s"));}
            set { _inbox = value;}
        }
        
        public IList<IWebElement> getMailList()
        {
            return driver.FindElements(By.XPath("//*[@id=\":2q\"]"));
        }
        
        
    }
}
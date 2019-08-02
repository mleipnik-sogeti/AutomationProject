using System.Collections.Generic;
using OpenQA.Selenium;

namespace google
{
    public class about : common
    {
        private IWebElement _products;
        public IWebElement  products
        {
            get { return driver.FindElement(By.XPath("/html/body/header/div/nav/ul/li[2]/a"));}
            set { _products = value;}
        }
        
        public IList<IWebElement> caroselList()
        {
            return driver.FindElements(By.ClassName("carousel-slide-content"));
        }
        

    }
}
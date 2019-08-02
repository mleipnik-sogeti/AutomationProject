using System.Collections.Generic;
using OpenQA.Selenium;

namespace sel_stack.bestBuy
{
    public class SelBase
    {
        public IWebDriver driver;

        public IList<IWebElement> getAnchors() => driver.FindElements(By.TagName("a"));
        public string title => driver.Title;


        public void close()
        {
            driver.Close();
        }

    }
}
using System.Collections.Generic;
using OpenQA.Selenium;

//My Selenium base class establishing the necesities accross all page models

namespace SelBasic.BestBuy
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
using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace sel_stack.wiki
{
    public class wikiHome : wikicommon
    {
        public wikiHome()
        {
             // driver = new FirefoxDriver(Environment.CurrentDirectory);
            driver.Url = "http://www.wikipedia.org";
            driver.FindElement(By.XPath("/html/body/div[1]/div[1]/a/strong")).Click();
            // Console.WriteLine("completed base constructor");
            Console.WriteLine("completed child consttructor");
        }

        public IList<IWebElement> listAnch()
        {
            IWebElement body = driver.FindElement(By.Id("content"));
            return body.FindElements(By.TagName("a"));

            // foreach(IWebElement item in aList)
            // {
            //     Console.WriteLine(item.Text);
            // }
        }
    }
}
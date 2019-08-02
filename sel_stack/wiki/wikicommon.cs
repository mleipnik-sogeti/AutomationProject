using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace sel_stack.wiki
{
    public class wikicommon
    {
        static public IWebDriver driver = new FirefoxDriver(Environment.CurrentDirectory);

        public wikicommon()
        {
            Console.WriteLine("completed base constructor");

        }

        public void close()
        {
            driver.Close();
        }
        
    }
}
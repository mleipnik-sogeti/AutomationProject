using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace google
{
    public class common
    {
        static public IWebDriver driver = new FirefoxDriver(Environment.CurrentDirectory);

        public common()
        {
            Console.WriteLine("completed base constructor");

        }

        public void close()
        {
            driver.Close();
        }
    }
}
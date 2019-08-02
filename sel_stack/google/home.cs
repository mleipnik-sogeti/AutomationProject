using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace google
{
    public class home : common
    {
        private IWebElement _query;
        public IWebElement query
        {
            get { return driver.FindElement(By.Name("q"));}
            set { _query = value;}
        }
        
        private IWebElement _usr;
        public IWebElement usr
        {
            get { return driver.FindElement(By.LinkText("Sign in"));}
            set { _usr = value;}
        }
        private IWebElement _abt;
        public IWebElement abt
        {
            get { return driver.FindElement(By.LinkText("About"));}
            set { _abt = value;}
        }

        private IWebElement _mail;
        public IWebElement mail
        {
            get { return driver.FindElement(By.LinkText("Gmail"));}
            set { _mail = value;}
        }
        
        private IWebElement _img;
        public IWebElement img
        {
            get { return driver.FindElement(By.LinkText("Images"));}
            set { _img = value;}
        }
        
        private IWebElement _store;
        public IWebElement store
        {
            get { return driver.FindElement(By.LinkText("Store"));}
            set { _store = value;}
        }
        
        private IWebElement _sbtn;
        public IWebElement sbtn
        {
            get { return driver.FindElement(By.Name("btnK"));}
            set { _sbtn = value;}
        }
        
        private IWebElement _lucky;
        public IWebElement lucky
        {
            get { return driver.FindElement(By.Name("btnI"));}
            set { _lucky = value;}
        }
        
        
        public home()
        {
            // driver = new FirefoxDriver(Environment.CurrentDirectory);
            Console.WriteLine("entered child constructor");
            driver.Url = "http://www.google.com";
            Console.WriteLine("pass 1");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            IWebElement myDynamicElement = wait.Until<IWebElement>(d => d.FindElement(By.Name("q")));
            Console.WriteLine("completed child consttructor");

        }
        public void search( string input)
        {
            Console.WriteLine("starting search");
            IWebElement query = driver.FindElement(By.Name("q"));
    
            query.SendKeys(input);
    
            query.Submit();
        }

        public string title()
        {
            return driver.Title;
        }

        // public void close()
        // {
        //     driver.Close();
        // }
    }
}
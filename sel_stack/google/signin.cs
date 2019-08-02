using System;
using OpenQA.Selenium;

namespace google
{
    public class signin : common
    {

        private IWebElement _nxt;
        public IWebElement nxt
        {
            get { return driver.FindElement(By.Id("identifierNext"));}
            private set { _nxt = value;}
        }

        private IWebElement _nxtp;
        public IWebElement nxtp
        {
            get { return driver.FindElement(By.Id("passwordNext"));}
            private set { _nxtp = value;}
        }
        
        private IWebElement _identifier;
        public IWebElement identifier
        {
            get { return driver.FindElement(By.Name("identifier"));}
            private set { _identifier = value;}
        }
        
        private IWebElement _pword;
        public IWebElement pword
        {
            get { return driver.FindElement(By.Name("password"));}
            private set { _pword = value;}
        }
        

        public signin()
        {
            Console.WriteLine("signin page created");

        }

        
    }
}
using System;
using OpenQA.Selenium;
using System.Threading;
using System.Collections.Generic;


namespace google
{
    public class test
    {
        static public void signin(home _home)
        {
            Console.WriteLine("enter sign in");
            _home.usr.Click();
            signin sin = new signin();
            sin.identifier.SendKeys("");
            Console.WriteLine("keys sent");
            sin.nxt.Click();
            sin.pword.SendKeys("");
            sin.nxtp.Click();
        }

        static public void checkMail(home _home)
        {
            Console.WriteLine("entering check mail");
            _home.mail.Click();
            mailHome ml = new mailHome();
            Thread.Sleep(5000);
            IList<IWebElement> mlist = ml.getMailList();
            // common.driver.SwitchTo().frame();
            mlist[0].Click();
        }

        static public void shopForPhones(home _home)
        {
            Console.WriteLine("entered shop for phones");
            _home.store.Click();
            shop shp = new shop();
            shp.phones.Click();

        }
        
    }
}
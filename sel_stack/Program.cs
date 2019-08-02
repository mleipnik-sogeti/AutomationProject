using System;
using System.Collections.Generic;
using System.Threading;
using OpenQA.Selenium;
using sel_stack.wiki;
using google;
using sel_stack.bestBuy;

namespace sel_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("starting..");
            var ghome = new home();
            ghome.search("hello world");

            Console.WriteLine(ghome.title());
            ghome.close();
            
            Console.WriteLine("finished..");        

            
        }

        public int blankFunc()
        {
            return 5;
        }

        static public void randWikiSearch()
        {
            Random rnd = new Random();

            wikiHome wHome = new wikiHome();
            IList<IWebElement> page1 = wHome.listAnch();
            // shopForPhones(ghome);
            for(int i = 0; i< 3; i++)
            {
                page1 = wHome.listAnch();
                IWebElement elm = page1[rnd.Next(15, (int)(Math.Floor((double)page1.Count/2)))];
                Console.WriteLine(elm.Text);
                elm.Click();
                Thread.Sleep(1000);
            }
            Thread.Sleep(5000);
            wHome.close();
        }
        
    }
}

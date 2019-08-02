using NUnit.Framework;
using sel_stack;
using google;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Tests
{
    public class Tests
    {
        home ghome;

        [SetUp]
        public void Setup()
        {
            // ghome = new home();
        }

        // [Test]
        // public void Test1()
        // {
        //     ghome = new home();
        //     ghome.search("hello world");
        //     Assert.IsTrue(ghome.title() == "hello world - Google Search",$"expected value \"hello world -Google Search\" was not received instead {ghome.title()}");
        //     ghome.close();
        // }


        [TearDown]
		public void closeBrowser()
        {
        }
    }
}
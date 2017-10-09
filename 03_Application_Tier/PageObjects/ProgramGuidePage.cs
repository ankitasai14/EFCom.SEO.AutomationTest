using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Collections;
using RelevantCodes.ExtentReports.Model;
using Rentals._02_Utility_Tier;
using System;
using OpenQA.Selenium.Support.UI;

namespace Rentals._03_Application_Tier.PageObjects
{
    [TestClass]
    public class ProgramGuidePage
    {
        public IWebDriver oWebDriver;
        public Hashtable oHashTable;
        public ProgramGuidePage(IWebDriver webDriver)
        {
            oWebDriver = webDriver;
       
        }



      
        [FindsBy(How = How.XPath, Using = "//li[1]/div/a/span")]
        public IWebElement ALLAge { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[2]/div/a/span")]
        public IWebElement ALLLanguage { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[3]/div/a/span")]
        public IWebElement ALLCountries { get; set; }

        [FindsBy(How = How.CssSelector, Using = "//li[4]/div/a/span")]
        public IWebElement Topic { get; set; }



        [FindsBy(How = How.XPath, Using = "//li[1]/div/ul/li")]
        public List<IWebElement> listOfAges { get; set; }
      
        [FindsBy(How = How.XPath, Using = "//li[2]/div/ul/li")]
        public List<IWebElement> listOfLangauge { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[3]/div/ul/li")]
        public List<IWebElement> listOfMarkets { get; set; }


        [FindsBy(How = How.XPath, Using = "//li[4]/div/ul/li")]
        public List<IWebElement> listOfTopics { get; set; }




    }
}

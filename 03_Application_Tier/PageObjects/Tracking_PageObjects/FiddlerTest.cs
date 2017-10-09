using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using Rentals._02_Utility_Tier;
using OpenQA.Selenium;
using System.IO;
using OpenQA.Selenium.Chrome;
using Rentals._03_Application_Tier.ApplicationTests;

namespace Rentals._03_Application_Tier.PageObjects.Tracking_PageObjects
{
    [TestClass]
    public class FiddlerTest : TestDriver
    {


        public static IWebDriver driver;

        public void SettingProxy_Fiddler(string userAgent, FiddlerTrackSettings FiddlerSettings, ref IWebDriver driver)
        {
            ChromeOptions options = null;


            options = new ChromeOptions();
            options.AddArgument("no-sandbox");
            options.AddArgument("--start-maximized");
            options.AddArgument("--test-type");
            var proxyPort = FiddlerHelper.StartFiddlerProxy(0, FiddlerSettings.URLsToTrack);

            var seleniumProxy = new OpenQA.Selenium.Proxy();
            seleniumProxy.HttpProxy = String.Format("127.0.0.1:{0}", proxyPort);
            seleniumProxy.SslProxy = String.Format("127.0.0.1:{0}", proxyPort);
            //options.Proxy = proxy;
            
            var fileName = "";


            string path = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\Selenium.Chrome.WebDriver.2.30\driver", fileName);

            options.Proxy = seleniumProxy;
            if (!String.IsNullOrEmpty(userAgent))
            {
                options.AddArgument("--user-agent=" + userAgent);
            }

            if (FiddlerSettings != null && FiddlerSettings.IsFiddlerTrackingRequired == true)
            {
                driver = new ChromeDriver(path, options, TimeSpan.FromSeconds(100));
            }

            driver.Manage().Cookies.DeleteAllCookies();
          

        }
      
    }
}

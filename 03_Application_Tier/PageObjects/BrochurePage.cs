using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rentals._02_Utility_Tier;
using OpenQA.Selenium;
using System.Collections;
using Rentals._01_Configuration_Tier.EnvironmentFiles;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.Globalization;

namespace Rentals._03_Application_Tier.PageObjects
{
    [TestClass]
    public class BrochurePage
    {

        public IWebDriver oWebDriver;
        public Dictionary<string, string> oHashTable;

        public BrochurePage(IWebDriver webDriver)
        {
            oWebDriver = webDriver;
        }

        enum  ProductCode
        {
            hsy,
            ilc,
            ils,
        };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="UrlCode"></param>
        /// <param name="MarketUrl"></param>
        /// <returns></returns>
        [TestMethod]
        public BrochurePage ProgramGuide_ProductCode(string UrlCode, string MarketUrl)
        {
            bool check = false;
          
            try
            {
                switch (UrlCode)
                {                   
                    case "p=hsy":
                        if (WebPageUtility.naviGateToUrl(MarketUrl, Env.strBrowserTitle, UrlCode))
                        {
                            Reporter.ReportEvent("Pass", "[Navigation Done to URL] - " + Env.strCurrentURL, " [and has EF Program Guide ]");
                        }
                        if (oWebDriver.PageSource.Contains("p=hsy"))
                        {
                            check = true;
                        }
                        break;

                    case "p=ilc":
                        WebPageUtility.naviGateToUrl(MarketUrl, Env.strBrowserTitle, UrlCode);
                        {
                            Reporter.ReportEvent("Pass", "[Navigation Done to URL] - " + Env.strCurrentURL, " [and has EF Program Guide ]");
                        }
                        if (oWebDriver.PageSource.Contains("p=hsy"))
                        {
                            check = true;
                        }
                        break;

                    case "p=ils":
                        if (WebPageUtility.naviGateToUrl(MarketUrl, Env.strBrowserTitle, UrlCode))
                        {
                            Reporter.ReportEvent("Pass", "[Navigation Done to URL] - " + Env.strCurrentURL, " [and has EF Program Guide ]");
                        }
                        if (oWebDriver.PageSource.Contains("p=hsy"))
                        {
                            check = true;
                        }
                        break;

                    case "p=lsp":
                        if (WebPageUtility.naviGateToUrl(MarketUrl, Env.strBrowserTitle, UrlCode))
                        {
                            Reporter.ReportEvent("Pass", "[Navigation Done to URL] - " + Env.strCurrentURL, " [and has EF Program Guide ]");
                        }
                        if (oWebDriver.PageSource.Contains("p=hsy"))
                        {
                            check = true;
                        }
                        break;

                    case "p=lt":
                        if (WebPageUtility.naviGateToUrl(MarketUrl, Env.strBrowserTitle, UrlCode))
                        {
                            Reporter.ReportEvent("Pass", "[Navigation Done to URL] - " + Env.strCurrentURL, " [and has EF Program Guide ]");
                        }
                        if (oWebDriver.PageSource.Contains("p=hsy"))
                        {
                            check = true;
                        }
                        break;

                    case "p=ly":
                        if (WebPageUtility.naviGateToUrl(MarketUrl, Env.strBrowserTitle, UrlCode))
                        {
                            Reporter.ReportEvent("Pass", "[Navigation Done to URL] - " + Env.strCurrentURL, " [and has EF Program Guide ]");
                        }
                        if (oWebDriver.PageSource.Contains("p=hsy"))
                        {
                            check = true;
                        }
                        break;

                }
                Reporter.ReportEvent("Pass",oWebDriver.Url, "URL Launched");
            }
            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "[Navigation Done to URL] - " + UrlCode, ex.Message);
                Assert.Fail();
                Reporter.EndTest();
            }
            return new BrochurePage(oWebDriver);
        }

        [TestMethod]
        public BrochurePage VerifyBrochureCommonFields()
        {
            try
            {   
               IJavaScriptExecutor js = (IJavaScriptExecutor)oWebDriver;
               js.ExecuteScript("window.scrollBy(0,250)", "");
                 oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");                   
                 Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='FirstName']", oHashTable["FirstName_Line_Test"].ToString()), "FirstName Fails to load");
    

                if (WebPageUtility.IsElementPresent(By.Id("LastName")))
                {
                    Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='LastName']", oHashTable["LastName_Line"].ToString()), "LastName Fails to load");
                }
                    
                    Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='Email']", oHashTable["Email_Line"].ToString()), "Email Fails to load");

                    WebDriverWait wait = new WebDriverWait(oWebDriver, TimeSpan.FromSeconds(500));
             }                                          
   
            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "Brochure Page Failed", ex.Message);
                Assert.Fail();
                Reporter.EndTest();
            }

            return new BrochurePage(oWebDriver);
        }

        [TestMethod]
        public BrochurePage RadioButtonForPostAndEmailOption()
        {
            try
            {
                IWebElement radioButtonCheck = oWebDriver.FindElement(By.CssSelector("#DeliveryPreference_1"));
                radioButtonCheck.GetAttribute("checked");

                if (radioButtonCheck.Selected)
                {
                    Console.WriteLine("Email one opted");
                    
                }
                else
                {
                    radioButtonCheck.Click();

                }
            }  
        
            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "Brochure Page Failed", ex.Message);
                Assert.Fail();
                Reporter.EndTest();
            }
            return new BrochurePage(oWebDriver);
        }

        [TestMethod]
        public BrochurePage RadioButtonForPostAndDeliveryOption()
        {
            try
            {
                IWebElement radioButtonCheck = oWebDriver.FindElement(By.CssSelector("#DeliveryPreference_0"));
                radioButtonCheck.GetAttribute("checked");

                if (radioButtonCheck.Enabled.Equals(true))
                {
                    Console.WriteLine("Email one opted");
                    radioButtonCheck.Click();
                }

            }

            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "Brochure Page Failed", ex.Message);
                Assert.Fail();
                Reporter.EndTest();
            }
            return new BrochurePage(oWebDriver);
        }


        [TestMethod]
        public void OfficePreferred()
        {           

            if (WebPageUtility.IsElementPresent(By.Id("PreferredOffice")))
            {
                IWebElement preferredOffice = oWebDriver.FindElement(By.Id("PreferredOffice"));

                SelectElement selectOffice = new SelectElement(preferredOffice);
                IList<IWebElement> options = selectOffice.Options;

                options = selectOffice.Options;

                IWebElement office = options[3];
                office.Click();
               
            }
          
        }

        [TestMethod]
        public BrochurePage SubmitPage()
        {
            try
            {
                IWebElement submitButton = oWebDriver.FindElement(By.Id("form-submit-button"));
                WebDriverWait wait = new WebDriverWait(oWebDriver, TimeSpan.FromSeconds(10));
              
                IJavaScriptExecutor js = (IJavaScriptExecutor)oWebDriver;
                js.ExecuteScript("arguments[0].scrollIntoView(true);", submitButton);

                WebPageUtility.clickElementByID("form-submit-button");
                wait = new WebDriverWait(oWebDriver, TimeSpan.FromSeconds(500));
          

                if (WebPageUtility.IsElementPresent(By.Id("overlayform")))
                {
                    oWebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);                  
                    WebPageUtility.clickElementByID("btnUpdate");
                   
                    if (WebPageUtility.IsElementPresent(By.Id("State")))
                    {   

                        IWebElement stateLabel = oWebDriver.FindElement(By.Id("State"));

                        if (stateLabel.GetAttribute("class").Contains("form-invalid"))
                        {
                            SelectElement selectedValue = new SelectElement(stateLabel);
                            selectedValue.SelectByIndex(1);
                            WebPageUtility.clickElementByID("btnUpdate");
                        }
                       
                    }


                }

                Reporter.ReportEvent("Pass", "Brochure Page Submitted", "redirected to Thank You Page");
            }
            catch(Exception ex)
            {
                Reporter.ReportEvent("Fail", "Brochure Page Failed", ex.Message);
                Assert.Fail();
                Reporter.EndTest();
            }
            return new BrochurePage(oWebDriver);
        }

        [TestMethod]
        public BrochurePage verifytheTestRedirectedToThankYouPage()
        {
            try
            {
                if (oWebDriver.Url.Contains("thank-you"))
                {
                    Console.WriteLine(oWebDriver.Url);
                    Reporter.ReportEvent("Pass", oWebDriver.Url + "Landed to Thank You Page", "Verified");
                }
            }

            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", oWebDriver.Url + "Not Landed to Thank You Page", ex.Message);
                Assert.Fail();
                Console.WriteLine(ex.Message);

                Reporter.EndTest();
            }

            WebDriverWait wait = new WebDriverWait(oWebDriver, TimeSpan.FromSeconds(1000));
            return new BrochurePage(oWebDriver);
            
        }
    }
}

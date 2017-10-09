using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Collections.Generic;
using Rentals._02_Utility_Tier;
using OpenQA.Selenium.Support.UI;

namespace Rentals._03_Application_Tier.PageObjects
{
    [TestClass]
    public class GermanyPage
    {

        public IWebDriver oWebDriver;
        public Dictionary<string, string> oHashTable;

        public GermanyPage(IWebDriver webDriver)
        {
            oWebDriver = webDriver;
        }

        [TestMethod]
        public void Germany_Emailtest()
        {
            oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");

            var element = oWebDriver.FindElement(By.XPath(".//*[@id='Email']"));
            IJavaScriptExecutor js = (IJavaScriptExecutor)oWebDriver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
            IWebElement houseInfo = oWebDriver.FindElement(By.XPath(".//*[@id='AddressLine1']"));

            if (houseInfo.Displayed)
            {
                Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='AddressLine1']", oHashTable["AddressLine1_Line"].ToString()), "Address Fails to load");
                if (WebPageUtility.IsElementPresent(By.Id("HouseNumber")))
                {
                    IWebElement houseVerify = oWebDriver.FindElement(By.XPath(".//*[@id='HouseNumber']"));
                    if (houseVerify.Displayed)
                    {
                        Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='HouseNumber']", oHashTable["HouseNumber_Line"].ToString()));
                        houseVerify.SendKeys(Keys.Tab);
                    }
                }                    
            }

                if (WebPageUtility.IsElementPresent(By.Id("PostalCode")))
                {
                   IWebElement PostalCode = oWebDriver.FindElement(By.XPath(".//*[@id='PostalCode']"));
                    if (PostalCode.GetAttribute("value").Equals(string.Empty))
                    {

                        if (PostalCode.Displayed && PostalCode.Enabled)
                        {
                            PostalCode.Clear();
                            Assert.IsTrue(WebPageUtility.inputTextByID("PostalCode", oHashTable["PostalCode"].ToString()));
                        }

                    }
                }
               
            WebDriverWait waitForElement = new WebDriverWait(oWebDriver, TimeSpan.FromSeconds(100));
            WebPageUtility.clickElementByID("PhoneRadio_1");
         

            if (WebPageUtility.IsElementPresent(By.CssSelector("#AreaCodeHomePhone")))
                {
                    WebPageUtility.inputTextByID("AreaCodeHomePhone", oHashTable["AreaCodeHomePhone"].ToString());
                    WebPageUtility.inputTextByID("HomePhone", oHashTable["HomePhone"].ToString());

                }
                else
                {
                    WebPageUtility.clickElementByID("PhoneRadio_0");
                    Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='MobilePhone']", oHashTable["MobilePhone_Line"].ToString()));
                }
              
            
               
            WebPageUtility.WaitForAjax(oWebDriver);
            IWebElement days = oWebDriver.FindElement(By.Id("Days"));

            SelectElement selectList = new SelectElement(days);
            IList<IWebElement> options = selectList.Options;

            IWebElement firstOption = options[1];

            Assert.AreEqual(firstOption.GetAttribute("value"), "1");
            Console.WriteLine(firstOption.GetAttribute("value"));

            firstOption.Click();

            IWebElement month = oWebDriver.FindElement(By.Id("Months"));
            selectList = new SelectElement(month);
            options = selectList.Options;

            IWebElement MonthOption = options[4];
            MonthOption.Click();

            IWebElement year = oWebDriver.FindElement(By.Id("Year"));
            selectList = new SelectElement(year);
            options = selectList.Options;

            IWebElement YearOption = options[8];
            YearOption.Click();

            IWebElement answerCode = oWebDriver.FindElement(By.Id("UserSelectedSourceCode"));
            selectList = new SelectElement(answerCode);
            options = selectList.Options;

            IWebElement answer = options[3];
            answer.Click();

            WebPageUtility.clickElementByID("Gender_0");
            WebPageUtility.clickElementByID("YesEmailMarketing");

            oWebDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(100));
            Reporter.ReportEvent("Pass", "All Fileds entered", "Verified");

            WebPageUtility.WaitForAjax(oWebDriver);

        }
    }
}

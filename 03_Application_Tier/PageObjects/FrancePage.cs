using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Collections.Generic;
using Rentals._02_Utility_Tier;
using OpenQA.Selenium.Support.UI;

namespace Rentals._03_Application_Tier.PageObjects
{
    [TestClass]
    public class FrancePage
    {
        public IWebDriver oWebDriver;
        public Dictionary<string, string> oHashTable;

        public FrancePage(IWebDriver webDriver)
        {
            oWebDriver = webDriver;
        }

        [TestMethod]
        public void France_MailTest()
        {
            oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");

            var element = oWebDriver.FindElement(By.XPath(".//*[@id='MobilePhone']"));
            IJavaScriptExecutor js = (IJavaScriptExecutor)oWebDriver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
            IWebElement houseInfo = oWebDriver.FindElement(By.XPath(".//*[@id='HouseNumber']"));
          
            if (houseInfo.Displayed)
            {

                Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='AddressLine1']", oHashTable["AddressLine1_Line_Fr"].ToString()), "Address Fails to load");
                Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='HouseNumber']", oHashTable["HouseNumber_Line"].ToString()), "Housenumber Fails to load");                        
            }
            WebPageUtility.WaitForAjax(oWebDriver);
            var PostalCode = oWebDriver.FindElement(By.XPath(".//*[@id='PostalCode']"));
            if (PostalCode.Displayed)
            {
                Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='PostalCode']", oHashTable["PostalCode_Fr"].ToString()), "PostalCode Fails to load");
            }
            WebPageUtility.clickElementByID("PhoneRadio_0");
            Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='MobilePhone']", oHashTable["MobilePhone_Line_Fr"].ToString()),"Mobile Number Fails to load");
          
           /* WebPageUtility.inputTextByXpath(".//*[@id='AreaCodeHomePhone']", oHashTable["AreaCodeHomePhone"].ToString());
            WebPageUtility.inputTextByXpath(".//*[@id='HomePhone']", oHashTable["HomePhone"].ToString()); */

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

            IWebElement YearOption = options[14];
            YearOption.Click();

            IWebElement answerCode = oWebDriver.FindElement(By.Id("UserSelectedSourceCode"));
            selectList = new SelectElement(answerCode);
            options = selectList.Options;

            IWebElement answer = options[3];
            answer.Click();

            WebPageUtility.clickElementByID("Gender_0");
            WebPageUtility.clickElementByID("YesEmailMarketing");          
            Reporter.ReportEvent("Pass", "All Fileds entered", "Verified");

            WebPageUtility.WaitForAjax(oWebDriver);


        }
    }
}

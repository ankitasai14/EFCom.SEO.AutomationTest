using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Rentals._02_Utility_Tier;
using System.Collections.Generic;
using System.Collections;
using Rentals._03_Application_Tier.ApplicationTests;
using OpenQA.Selenium.Support.UI;

namespace Rentals._03_Application_Tier.PageObjects
{
    [TestClass]
    public class Common_Method : TestDriver
    {
        public Dictionary<string, string> oHashTable;
        public IWebDriver oWebDriver;
        private object waitForElement;

        public Common_Method(IWebDriver webDriver)
        {
            oWebDriver = webDriver;
        }
     
        [TestMethod]
        public void Brochure(string Address, string Housenumber, string postalCode, string mobileNumber, string cityName, string stateName)
        {
            try
            {          
                oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");

               
                var Mobelement = oWebDriver.FindElement(By.XPath(".//*[@id='MobilePhone']"));
                IJavaScriptExecutor js = (IJavaScriptExecutor)oWebDriver;
                js.ExecuteScript("arguments[0].scrollIntoView(true);", Mobelement);
                
                if (WebPageUtility.IsElementPresent(By.CssSelector(".form-group.heading-divider.-address")))
                {
                    IWebElement addressVisibility = oWebDriver.FindElement(By.CssSelector(".form-group.heading-divider.-address"));
                    if (addressVisibility.Displayed)
                    {
                        IWebElement addressText = oWebDriver.FindElement(By.XPath(".//*[@id='AddressLine1']"));                    
                        Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='AddressLine1']", Address));
                        addressText.SendKeys(Keys.Enter);
                        WebDriverWait waitForElement = new WebDriverWait(oWebDriver, TimeSpan.FromSeconds(900));

                        if (WebPageUtility.IsElementPresent(By.Id("HouseNumber")))
                        {
                            IWebElement houseVerify = oWebDriver.FindElement(By.XPath(".//*[@id='HouseNumber']"));
                            if (houseVerify.Displayed)
                            {
                                Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='HouseNumber']", Housenumber));
                                houseVerify.SendKeys(Keys.Tab);
                            }
                           
                        }
                        if (WebPageUtility.IsElementPresent(By.Id("AddressLine2")))
                        {
                            WebPageUtility.inputTextByID("AddressLine2", "abcdef");
                        }

                        string CssValuehiddenApartNumber = ".ApartmentNumber.formapihide.clearfix>label>strong";
                        string CssValueShownApartNumber = ".ApartmentNumber.formapishow.clearfix>label>strong";
                        if (WebPageUtility.IsElementPresent(By.Id("ApartmentNumber")) && (WebPageUtility.IsElementPresent(By.CssSelector(CssValuehiddenApartNumber)) || WebPageUtility.IsElementPresent(By.CssSelector(CssValueShownApartNumber))))
                        {
                            WebPageUtility.inputTextByID("ApartmentNumber", "23");
                        }

                    }
                  waitForElement = new WebDriverWait(oWebDriver, TimeSpan.FromSeconds(900));
                                       

                }

                WebPageUtility.WaitForAjax(oWebDriver);
                if (WebPageUtility.IsElementPresent(By.Id("PostalCode")))
                {
                    IWebElement PostalCode = oWebDriver.FindElement(By.XPath(".//*[@id='PostalCode']"));
                    if (PostalCode.GetAttribute("value").Equals(string.Empty))
                    {
                        
                        if (PostalCode.Displayed && PostalCode.Enabled)
                        {
                            PostalCode.Clear();
                            Assert.IsTrue(WebPageUtility.inputTextByID("PostalCode", postalCode));
                        }

                    }
                }

                waitForElement = new WebDriverWait(oWebDriver, TimeSpan.FromSeconds(900));

                if (WebPageUtility.IsElementPresent(By.Id("State")))
                {

                    IWebElement stateVerify = oWebDriver.FindElement(By.CssSelector("#State"));
                    if (stateVerify.Displayed)
                    {
                        SelectElement state = new SelectElement(stateVerify);
                        state.SelectByText(stateName);
                    }

                }
                WebPageUtility.WaitForAjax(oWebDriver);
                waitForElement = new WebDriverWait(oWebDriver, TimeSpan.FromSeconds(900));

                if (WebPageUtility.IsElementPresent(By.Id("City")))
                {
                    IWebElement cityVerify = oWebDriver.FindElement(By.Name("City"));
                    if (cityVerify.GetAttribute("type") != "dropdown" && cityVerify.Displayed)
                    {
                        Assert.IsTrue(WebPageUtility.inputTextByID("City", cityName));
                    }

                    if (cityVerify.GetAttribute("type") == "dropdown" && cityVerify.Displayed)
                    {
                        SelectElement selectCity = new SelectElement(cityVerify);
                        selectCity.SelectByText(cityName);
                    }

                }

             
            
                waitForElement = new WebDriverWait(oWebDriver, TimeSpan.FromSeconds(1000));

                if (Mobelement.Displayed)
                {
                    waitForElement = new WebDriverWait(oWebDriver, TimeSpan.FromSeconds(600));

                    if (WebPageUtility.IsElementPresent(By.CssSelector("#AreaCodeMobilePhone")))
                    {
                        IWebElement areaCode = webDriver.FindElement(By.Id("AreaCodeMobilePhone"));
                        SelectElement selectAreaCode = new SelectElement(areaCode);
                        selectAreaCode.SelectByIndex(1);

                    }
                else
                    {
                        WebPageUtility.clickElementByID("PhoneRadio_0");
                        Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='MobilePhone']", mobileNumber));
                    }
                   
                  
                }

                if (WebPageUtility.IsElementPresent(By.Id("Gender_0")))
                {
                    IWebElement gender = oWebDriver.FindElement(By.Id("Gender_0"));
                    js.ExecuteScript("arguments[0].scrollIntoView(true);", gender);

                    waitForElement = new WebDriverWait(oWebDriver, TimeSpan.FromSeconds(500));

                    WebPageUtility.clickElementByID("Gender_0");
                }
              
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

                IWebElement YearOption = options[15];
                YearOption.Click();

                if (WebPageUtility.IsElementPresent(By.CssSelector("#ProgramCategory")))
                {
                    IWebElement ProgramCategory = oWebDriver.FindElement(By.CssSelector("#ProgramCategory"));
                    if (ProgramCategory.Displayed)
                    {
                        selectList = new SelectElement(ProgramCategory);
                        selectList.SelectByIndex(1);

                        WebPageUtility.WaitForAjax(oWebDriver);

                        IWebElement courseLength = oWebDriver.FindElement(By.Id("CourseLength"));
                        selectList = new SelectElement(courseLength);
                        selectList.SelectByIndex(1);
                    }

                }

                IWebElement answerCode = oWebDriver.FindElement(By.Id("UserSelectedSourceCode"));
                selectList = new SelectElement(answerCode);
                options = selectList.Options;

                IWebElement answer = options[3];
                answer.Click();
                
                if (WebPageUtility.IsElementPresent(By.Id("IsParents_1")))
                {
                    waitForElement = new WebDriverWait(oWebDriver, TimeSpan.FromSeconds(100));
                    WebPageUtility.clickElementByID("IsParents_1");
                }


                if (WebPageUtility.IsElementPresent(By.Id("Comments")))
                {
                    WebPageUtility.inputTextByID("Comments", "ankita");
                }


                WebPageUtility.clickElementByID("YesEmailMarketing");
                Reporter.ReportEvent("Pass", "All Fileds entered", "Verified");

                WebPageUtility.WaitForAjax(oWebDriver);
               
            }


            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "CS Failed", ex.Message);
            }

        }

        [TestMethod]
        public void hasAcceptedPrivacyPolicyTickBox()
        {
            WebPageUtility.clickElementByID("HasAcceptedPrivacyPolicy");
        }

        [TestMethod]
        public void BrochureToEmail(string Address, string Housenumber, string postalCode, string mobileNumber, string cityName, string stateName)

        {
            try
            {
                oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");

                if (WebPageUtility.IsElementPresent(By.Id("State")))
                {
                    IWebElement stateVerify = oWebDriver.FindElement(By.CssSelector("#State"));
                    if (stateVerify.Displayed)
                    {
                        SelectElement state = new SelectElement(stateVerify);
                        state.SelectByText(stateName);
                    }
                }

                waitForElement = new WebDriverWait(oWebDriver, TimeSpan.FromSeconds(1000));
                if (WebPageUtility.IsElementPresent(By.Id("PostalCode")))
                {
                    IWebElement PostalCode = oWebDriver.FindElement(By.XPath(".//*[@id='PostalCode']"));
                    if (PostalCode.GetAttribute("value").Equals(string.Empty))
                    {

                        if (PostalCode.Displayed && PostalCode.Enabled)
                        {
                            PostalCode.Clear();
                            Assert.IsTrue(WebPageUtility.inputTextByID("PostalCode", postalCode));
                        }

                    }
                }

                waitForElement = new WebDriverWait(oWebDriver, TimeSpan.FromSeconds(1000));

                var Mobelement = oWebDriver.FindElement(By.XPath(".//*[@id='MobilePhone']"));
                if (Mobelement.Displayed)
                {
                    waitForElement = new WebDriverWait(oWebDriver, TimeSpan.FromSeconds(600));

                    if (WebPageUtility.IsElementPresent(By.CssSelector("#AreaCodeMobilePhone")))
                    {
                        IWebElement areaCode = webDriver.FindElement(By.Id("AreaCodeMobilePhone"));
                        SelectElement selectAreaCode = new SelectElement(areaCode);
                        selectAreaCode.SelectByIndex(1);

                    }
                    else if (WebPageUtility.IsElementPresent(By.Id("PhoneRadio_1")))
                    {
                        WebPageUtility.clickElementByID("PhoneRadio_1");
                        WebPageUtility.inputTextByID("PhoneRadio_1", mobileNumber);
                    }
                    else
                    {
                        WebPageUtility.clickElementByID("PhoneRadio_0");
                        Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='MobilePhone']", mobileNumber));
                    }


                }

                WebPageUtility.clickElementByID("Gender_0");

                waitForElement = new WebDriverWait(oWebDriver, TimeSpan.FromSeconds(1000));
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

                IWebElement YearOption = options[15];
                YearOption.Click();

                IWebElement answerCode = oWebDriver.FindElement(By.Id("UserSelectedSourceCode"));
                selectList = new SelectElement(answerCode);
                options = selectList.Options;

                IWebElement answer = options[3];
                answer.Click();

                waitForElement = new WebDriverWait(oWebDriver, TimeSpan.FromSeconds(1000));

                if (WebPageUtility.IsElementPresent(By.CssSelector("#ProgramCategory")))
                {
                    IWebElement ProgramCategory = oWebDriver.FindElement(By.CssSelector("#ProgramCategory"));
                    if (ProgramCategory.Displayed)
                    {
                        selectList = new SelectElement(ProgramCategory);
                        selectList.SelectByIndex(1);

                        WebPageUtility.WaitForAjax(oWebDriver);

                        IWebElement courseLength = oWebDriver.FindElement(By.Id("CourseLength"));
                        selectList = new SelectElement(courseLength);
                        selectList.SelectByIndex(1);
                    }                

                }

                if (WebPageUtility.IsElementPresent(By.Id("CourseLength")))
                {
                    IWebElement courseLength = oWebDriver.FindElement(By.Id("CourseLength"));
                    selectList = new SelectElement(courseLength);

                    selectList.SelectByIndex(2);

                }
                WebPageUtility.clickElementByID("YesEmailMarketing");
                Reporter.ReportEvent("Pass", "All Fileds entered", "Verified");

                WebPageUtility.WaitForAjax(oWebDriver);

            }


            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "CS Failed", ex.Message);
            }

        }


        [TestMethod]
        public void BrochureForOneSection(string Address, string Housenumber, string postalCode, string mobileNumber, string cityName, string stateName, string country, string citizenship)

        {
            try
            {
                oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
               
                var Mobelement = oWebDriver.FindElement(By.XPath(".//*[@id='MobilePhone']"));
                IJavaScriptExecutor js = (IJavaScriptExecutor)oWebDriver;
                js.ExecuteScript("arguments[0].scrollIntoView(true);", Mobelement);

                if (WebPageUtility.IsElementPresent(By.Id("City")))
                {
                    IWebElement cityVerify = oWebDriver.FindElement(By.Id("City"));
                    if (cityVerify.Displayed)
                    {
                        Assert.IsTrue(WebPageUtility.inputTextByID("City", cityName));
                    }
                }

                if (WebPageUtility.IsElementPresent(By.CssSelector("#State")))
                {
                    IWebElement stateVerify = oWebDriver.FindElement(By.CssSelector("#State"));
                    SelectElement state = new SelectElement(stateVerify);
                    state.SelectByText(stateName);
                }
                      
                if (WebPageUtility.IsElementPresent(By.Id("CountryCode")))
                {
                    IWebElement countryVerify = oWebDriver.FindElement(By.CssSelector("#CountryCode"));
                    SelectElement state = new SelectElement(countryVerify);
                    state.SelectByText(country);
                }

                if (WebPageUtility.IsElementPresent(By.Id("CitizenshipCode")))
                {
                    IWebElement citizenshipVerify = oWebDriver.FindElement(By.CssSelector("#CitizenshipCode"));
                    SelectElement citizenShipCode = new SelectElement(citizenshipVerify);
                    citizenShipCode.SelectByText(citizenship);
                }

                WebDriverWait waitForElement = new WebDriverWait(oWebDriver, TimeSpan.FromSeconds(900));

                if (Mobelement.Displayed)
                {
                    WebPageUtility.clickElementByID("PhoneRadio_0");
                    Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='MobilePhone']", mobileNumber));
                }

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

                IWebElement YearOption = options[15];
                YearOption.Click();

                IWebElement answerCode = oWebDriver.FindElement(By.Id("UserSelectedSourceCode"));
                selectList = new SelectElement(answerCode);
                options = selectList.Options;

                IWebElement answer = options[3];
                answer.Click();

                WebPageUtility.clickElementByID("Gender_0");
                WebPageUtility.clickElementByID("YesEmailMarketing");
                Reporter.ReportEvent("Pass", "All Fileds entered", "Verified");
               
            }


            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "CS Failed", ex.Message);
            }

        }

        [TestMethod]
        public void AcceptanceTerm()
        {
            try
            {           
                WebPageUtility.clickElementByID("btnCloseLayer");

                WebPageUtility.clickElementByID("HasAcceptedTerms");
                WebDriverWait waitForElement = new WebDriverWait(oWebDriver, TimeSpan.FromSeconds(500));

                WebPageUtility.clickElementByID("HasAcceptedPrivacyPolicy");
                WebPageUtility.clickElementByID("YesEmailMarketing");

                Reporter.ReportEvent("Pass", "Checked", "Verified");

            }

            catch (Exception e)
            {
                Reporter.ReportEvent("Fail", "Failed", e.Message);
            }
        }

    }
}
   
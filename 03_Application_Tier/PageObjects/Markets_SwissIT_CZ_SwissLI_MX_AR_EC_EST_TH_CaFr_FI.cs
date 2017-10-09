using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using Rentals._02_Utility_Tier;
using Rentals._03_Application_Tier.ApplicationTests;

namespace Rentals._03_Application_Tier.PageObjects
{
    [TestClass]

    public class Markets_SwissIT_CZ_SwissLI_MX_AR_EC_EST_TH_CaFr_FI : TestDriver
    {
    }
    /// <summary>
    /// Switzerland (Italian) = SwissIT
    /// </summary>
    class CH_IT
    {
        public IWebDriver oWebDriver;
        public Dictionary<string, string> oHashTable;
        public CH_IT(IWebDriver webDriver)
        {
            oWebDriver = webDriver;
        }

        [TestMethod]
        public void SwitzerlandItalian_MailTest()
        {
            try
            {
                oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");


                var element = oWebDriver.FindElement(By.XPath(".//*[@id='MobilePhone']"));
                IJavaScriptExecutor js = (IJavaScriptExecutor)oWebDriver;
                js.ExecuteScript("arguments[0].scrollIntoView(true);", element);

                if (WebPageUtility.IsElementPresent(By.XPath(".//*[@id='AddressLine1']")))
                {
                    Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='AddressLine1']", oHashTable["AddressLine1_Line_SwissIT"].ToString()), "Address Fails to load");
                    Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='HouseNumber']", oHashTable["HouseNumber_Line_SwissIT"].ToString()), "Housenumber Fails to load");
                }

                WebPageUtility.WaitForAjax(oWebDriver);
                var PostalCode = oWebDriver.FindElement(By.XPath(".//*[@id='PostalCode']"));
                if (WebPageUtility.IsElementPresent(By.XPath(".//*[@id='PostalCode']")))
                {
                    PostalCode.Clear();
                    Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='PostalCode']", oHashTable["PostalCode_SwissIT"].ToString()), "PostalCode Fails to load");
                }
                WebPageUtility.clickElementByID("PhoneRadio_0");
                Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='MobilePhone']", oHashTable["MobilePhone_Line_SwissIT"].ToString()), "Mobile Number Fails to load");
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

                WebPageUtility.WaitForAjax(oWebDriver);
                Reporter.ReportEvent("Pass", "CS Pass", "Verified");

            }
            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "CS Failed", ex.Message);
            }

        }
    }

    /// <summary>
    /// Czech Republic = CZ
    /// </summary>
    class CZ
    {
        public IWebDriver oWebDriver;
        public Dictionary<string, string> oHashTable;
        public CZ(IWebDriver webDriver)
        {
            oWebDriver = webDriver;
        }

        [TestMethod]
        public void CzechRepublic_MailTest()
        {
            try
            {
                oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");


                var element = oWebDriver.FindElement(By.XPath(".//*[@id='MobilePhone']"));
                IJavaScriptExecutor js = (IJavaScriptExecutor)oWebDriver;
                js.ExecuteScript("arguments[0].scrollIntoView(true);", element);

                if (WebPageUtility.IsElementPresent(By.XPath(".//*[@id='AddressLine1']")))
                {
                    Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='AddressLine1']", oHashTable["AddressLine1_Line_CZ"].ToString()), "Address Fails to load");
                    Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='HouseNumber']", oHashTable["HouseNumber_Line_CZ"].ToString()), "Housenumber Fails to load");
                }

                WebPageUtility.WaitForAjax(oWebDriver);
                var PostalCode = oWebDriver.FindElement(By.XPath(".//*[@id='PostalCode']"));
                if (WebPageUtility.IsElementPresent(By.XPath(".//*[@id='PostalCode']")))
                {
                    PostalCode.Clear();
                    Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='PostalCode']", oHashTable["PostalCode_CZ"].ToString()), "PostalCode Fails to load");
                }
                WebPageUtility.clickElementByID("PhoneRadio_0");
                Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='MobilePhone']", oHashTable["MobilePhone_Line_CZ"].ToString()), "Mobile Number Fails to load");
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

                WebPageUtility.WaitForAjax(oWebDriver);
                Reporter.ReportEvent("Pass", "CS Pass", "Verified");

            }
            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "CS Failed", ex.Message);
            }

        }
    }

            /// <summary>
            /// SwissDE_Litchenstein
            /// </summary>
            class Litchenstein
            {
                public IWebDriver oWebDriver;
                public Dictionary<string, string> oHashTable;
                public Litchenstein(IWebDriver webDriver)
                {
                    oWebDriver = webDriver;
                }

                [TestMethod]
                public void SwitzerlandItalian_MailTest()
                {
                    try
                    {
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");


                        var element = oWebDriver.FindElement(By.XPath(".//*[@id='MobilePhone']"));
                        IJavaScriptExecutor js = (IJavaScriptExecutor)oWebDriver;
                        js.ExecuteScript("arguments[0].scrollIntoView(true);", element);

                        if (WebPageUtility.IsElementPresent(By.XPath(".//*[@id='AddressLine1']")))
                        {
                            Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='AddressLine1']", oHashTable["AddressLine1_Line_SwissDE_Litchenstein"].ToString()), "Address Fails to load");
                            Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='HouseNumber']", oHashTable["HouseNumber_Line_SwissDE_Litchenstein"].ToString()), "Housenumber Fails to load");
                        }

                        WebPageUtility.WaitForAjax(oWebDriver);
                        var PostalCode = oWebDriver.FindElement(By.XPath(".//*[@id='PostalCode']"));
                        if (WebPageUtility.IsElementPresent(By.XPath(".//*[@id='PostalCode']")))
                        {
                            PostalCode.Clear();
                            Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='PostalCode']", oHashTable["PostalCode_SwissDE_Litchenstein"].ToString()), "PostalCode Fails to load");
                        }
                        WebPageUtility.clickElementByID("PhoneRadio_0");
                        Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='MobilePhone']", oHashTable["MobilePhone_Line_SwissDE_Litchenstein"].ToString()), "Mobile Number Fails to load");
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

                        WebPageUtility.WaitForAjax(oWebDriver);
                        Reporter.ReportEvent("Pass", "CS Pass", "Verified");

                    }
                    catch (Exception ex)
                    {
                        Reporter.ReportEvent("Fail", "CS Failed", ex.Message);
                    }

                }
            }

            /// <summary>
            /// Mexico
            /// </summary>
            class MX 
            {
                public IWebDriver oWebDriver;
                public Dictionary<string, string> oHashTable;
                public MX(IWebDriver webDriver)
                {
                    oWebDriver = webDriver;
                }

                [TestMethod]
                public void SwitzerlandItalian_MailTest()
                {
                    try
                    {
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");


                        var element = oWebDriver.FindElement(By.XPath(".//*[@id='MobilePhone']"));
                        IJavaScriptExecutor js = (IJavaScriptExecutor)oWebDriver;
                        js.ExecuteScript("arguments[0].scrollIntoView(true);", element);

                        if (WebPageUtility.IsElementPresent(By.XPath(".//*[@id='AddressLine1']")))
                        {
                            Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='AddressLine1']", oHashTable["AddressLine1_Line_Mexico"].ToString()), "Address Fails to load");
                            Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='HouseNumber']", oHashTable["HouseNumber_Line_Mexico"].ToString()), "Housenumber Fails to load");
                        }

                        WebPageUtility.WaitForAjax(oWebDriver);
                        var PostalCode = oWebDriver.FindElement(By.XPath(".//*[@id='PostalCode']"));
                        if (WebPageUtility.IsElementPresent(By.XPath(".//*[@id='PostalCode']")))
                        {
                            PostalCode.Clear();
                            Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='PostalCode']", oHashTable["PostalCode_Mexico"].ToString()), "PostalCode Fails to load");
                        }
                        WebPageUtility.clickElementByID("PhoneRadio_0");
                        Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='MobilePhone']", oHashTable["MobilePhone_Line_Mexico"].ToString()), "Mobile Number Fails to load");
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

                        WebPageUtility.WaitForAjax(oWebDriver);
                        Reporter.ReportEvent("Pass", "CS Pass", "Verified");

                    }
                    catch (Exception ex)
                    {
                        Reporter.ReportEvent("Fail", "CS Failed", ex.Message);
                    }

                }
            }


            /// <summary>
            /// Algeria(Arabic)
            /// </summary>
            class Algeria_Arabic
            {
                public IWebDriver oWebDriver;
                public Dictionary<string, string> oHashTable;
                public Algeria_Arabic(IWebDriver webDriver)
                {
                    oWebDriver = webDriver;
                }

                [TestMethod]
                public void Algeria_Arabic_MailTest()
                {
                    try
                    {
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");


                        var element = oWebDriver.FindElement(By.XPath(".//*[@id='MobilePhone']"));
                        IJavaScriptExecutor js = (IJavaScriptExecutor)oWebDriver;
                        js.ExecuteScript("arguments[0].scrollIntoView(true);", element);

                        if (WebPageUtility.IsElementPresent(By.XPath(".//*[@id='AddressLine1']")))
                        {
                            Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='AddressLine1']", oHashTable["AddressLine1_Line_AlgeriaArabic"].ToString()), "Address Fails to load");
                            Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='HouseNumber']", oHashTable["HouseNumber_Line_AlgeriaArabic"].ToString()), "Housenumber Fails to load");
                        }

                        WebPageUtility.WaitForAjax(oWebDriver);
                        var PostalCode = oWebDriver.FindElement(By.XPath(".//*[@id='PostalCode']"));
                        if (WebPageUtility.IsElementPresent(By.XPath(".//*[@id='PostalCode']")))
                        {
                            PostalCode.Clear();
                            Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='PostalCode']", oHashTable["PostalCode_AlgeriaArabic"].ToString()), "PostalCode Fails to load");
                        }
                        WebPageUtility.clickElementByID("PhoneRadio_0");
                        Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='MobilePhone']", oHashTable["MobilePhone_Line_AlgeriaArabic"].ToString()), "Mobile Number Fails to load");
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

                        WebPageUtility.WaitForAjax(oWebDriver);
                        Reporter.ReportEvent("Pass", "CS Pass", "Verified");

                    }
                    catch (Exception ex)
                    {
                        Reporter.ReportEvent("Fail", "CS Failed", ex.Message);
                    }

                }


            }

            /// <summary>
            /// Algeria(French)
            /// </summary>
            class Algeria_French
            {
                public IWebDriver oWebDriver;
                public Dictionary<string, string> oHashTable;
                public Algeria_French(IWebDriver webDriver)
                {
                    oWebDriver = webDriver;
                }

                [TestMethod]
                public void Algeria_French_MailTest()
                {
                    try
                    {
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");


                        var element = oWebDriver.FindElement(By.XPath(".//*[@id='MobilePhone']"));
                        IJavaScriptExecutor js = (IJavaScriptExecutor)oWebDriver;
                        js.ExecuteScript("arguments[0].scrollIntoView(true);", element);

                        if (WebPageUtility.IsElementPresent(By.XPath(".//*[@id='AddressLine1']")))
                        {
                            Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='AddressLine1']", oHashTable["AddressLine1_Line_Algeria(French)"].ToString()), "Address Fails to load");
                            Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='HouseNumber']", oHashTable["HouseNumber_Line_Algeria(French)"].ToString()), "Housenumber Fails to load");
                        }

                        WebPageUtility.WaitForAjax(oWebDriver);
                        var PostalCode = oWebDriver.FindElement(By.XPath(".//*[@id='PostalCode']"));
                        if (WebPageUtility.IsElementPresent(By.XPath(".//*[@id='PostalCode']")))
                        {
                            PostalCode.Clear();
                            Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='PostalCode']", oHashTable["PostalCode_Algeria(French)"].ToString()), "PostalCode Fails to load");
                        }
                        WebPageUtility.clickElementByID("PhoneRadio_0");
                        Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='MobilePhone']", oHashTable["MobilePhone_Line_Algeria(French)"].ToString()), "Mobile Number Fails to load");
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

                        WebPageUtility.WaitForAjax(oWebDriver);
                        Reporter.ReportEvent("Pass", "CS Pass", "Verified");

                    }
                    catch (Exception ex)
                    {
                        Reporter.ReportEvent("Fail", "CS Failed", ex.Message);
                    }

                }
            }

            /// <summary>
            /// Ecuador
            /// </summary>
            class Ecuador
            {
                public IWebDriver oWebDriver;
                public Dictionary<string, string> oHashTable;
                public Ecuador(IWebDriver webDriver)
                {
                    oWebDriver = webDriver;
                }

                [TestMethod]
                public void Ecuador_MailTest()
                {
                    try
                    {
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");


                        var element = oWebDriver.FindElement(By.XPath(".//*[@id='MobilePhone']"));
                      

                        if (WebPageUtility.IsElementPresent(By.XPath(".//*[@id='AddressLine1']")))
                        {
                             WebPageUtility.inputTextByXpath(".//*[@id='AddressLine1']", oHashTable["AddressLine1_Line_Ecuador"].ToString());
                             WebPageUtility.inputTextByXpath(".//*[@id='HouseNumber']", oHashTable["HouseNumber_Line_Ecuador"].ToString());
                        }

                        WebPageUtility.WaitForAjax(oWebDriver);

                if (WebPageUtility.IsElementPresent(By.Id("City")))
                {
                    IWebElement cityVerify = oWebDriver.FindElement(By.Id("City"));
                    if (cityVerify.Displayed)
                    {
                        Assert.IsTrue(WebPageUtility.inputTextByID("City", oHashTable["City_Ecuador"].ToString()));
                    }

                }

                WebDriverWait waitForElement = new WebDriverWait(oWebDriver, TimeSpan.FromSeconds(500));

                if (WebPageUtility.IsElementPresent(By.Id("State")))
                {

                    IWebElement stateVerify = oWebDriver.FindElement(By.CssSelector("#State"));
                    if (stateVerify.Displayed)
                    {
                        SelectElement state = new SelectElement(stateVerify);
                        state.SelectByText("Santo Domingo");
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
                                    Assert.IsTrue(WebPageUtility.inputTextByID("PostalCode", oHashTable["PostalCode_Ecuador"].ToString()));
                                }

                            }
                        }
               
                        WebPageUtility.clickElementByID("PhoneRadio_0");
                        Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='MobilePhone']", oHashTable["MobilePhone_Line_Ecuador"].ToString()), "Mobile Number Fails to load");
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

                        WebPageUtility.WaitForAjax(oWebDriver);
                        Reporter.ReportEvent("Pass", "CS Pass", "Verified");

                    }
                    catch (Exception ex)
                    {
                        Reporter.ReportEvent("Fail", "CS Failed", ex.Message);
                    }

                }
            }

            /// <summary>
            /// Estonia
            /// </summary>
            class Estonia
            {
                public IWebDriver oWebDriver;
                public Dictionary<string, string> oHashTable;
                public Estonia(IWebDriver webDriver)
                {
                    oWebDriver = webDriver;
                }

                [TestMethod]
                public void Estonia_MailTest()
                {
                    try
                    {
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");


                        var element = oWebDriver.FindElement(By.XPath(".//*[@id='MobilePhone']"));
                        IJavaScriptExecutor js = (IJavaScriptExecutor)oWebDriver;
                        js.ExecuteScript("arguments[0].scrollIntoView(true);", element);

                        if (WebPageUtility.IsElementPresent(By.XPath(".//*[@id='AddressLine1']")))
                        {
                            Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='AddressLine1']", oHashTable["AddressLine1_Line_Estonia"].ToString()), "Address Fails to load");
                            Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='HouseNumber']", oHashTable["HouseNumber_Line_Estonia"].ToString()), "Housenumber Fails to load");
                        }

                        WebPageUtility.WaitForAjax(oWebDriver);
                        var PostalCode = oWebDriver.FindElement(By.XPath(".//*[@id='PostalCode']"));
                        if (WebPageUtility.IsElementPresent(By.XPath(".//*[@id='PostalCode']")))
                        {
                            PostalCode.Clear();
                            Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='PostalCode']", oHashTable["PostalCode_Estonia"].ToString()), "PostalCode Fails to load");
                        }
                        WebPageUtility.clickElementByID("PhoneRadio_0");
                        Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='MobilePhone']", oHashTable["MobilePhone_Line_Estonia"].ToString()), "Mobile Number Fails to load");
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

                        WebPageUtility.WaitForAjax(oWebDriver);
                        Reporter.ReportEvent("Pass", "CS Pass", "Verified");

                    }
                    catch (Exception ex)
                    {
                        Reporter.ReportEvent("Fail", "CS Failed", ex.Message);
                    }

                }
            }

            /// <summary>
            /// Thailand
            /// </summary>
            class TH
            {
                public IWebDriver oWebDriver;
                public Dictionary<string, string> oHashTable;
                public TH(IWebDriver webDriver)
                {
                    oWebDriver = webDriver;
                }


                [TestMethod]
                public void Thailand_MailTest()
                {
                    try
                    {
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");


                        var element = oWebDriver.FindElement(By.XPath(".//*[@id='MobilePhone']"));
                        IJavaScriptExecutor js = (IJavaScriptExecutor)oWebDriver;
                        js.ExecuteScript("arguments[0].scrollIntoView(true);", element);

                        if (WebPageUtility.IsElementPresent(By.XPath(".//*[@id='AddressLine1']")))
                        {
                            Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='AddressLine1']", oHashTable["AddressLine1_Line_Thailand"].ToString()), "Address Fails to load");
                            Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='HouseNumber']", oHashTable["HouseNumber_Line_Thailand"].ToString()), "Housenumber Fails to load");
                        }

                        WebPageUtility.WaitForAjax(oWebDriver);
                        var PostalCode = oWebDriver.FindElement(By.XPath(".//*[@id='PostalCode']"));
                        if (WebPageUtility.IsElementPresent(By.XPath(".//*[@id='PostalCode']")))
                        {
                            PostalCode.Clear();
                            Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='PostalCode']", oHashTable["PostalCode_Thailand"].ToString()), "PostalCode Fails to load");
                        }
                        WebPageUtility.clickElementByID("PhoneRadio_0");
                        Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='MobilePhone']", oHashTable["MobilePhone_Line_Thailand"].ToString()), "Mobile Number Fails to load");
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

                        WebPageUtility.WaitForAjax(oWebDriver);
                        Reporter.ReportEvent("Pass", "CS Pass", "Verified");

                    }
                    catch (Exception ex)
                    {
                        Reporter.ReportEvent("Fail", "CS Failed", ex.Message);
                    }

                }
            }

    /// <summary>
    /// CanadaFR
    /// </summary>
    class CanadaFR
    {
        public IWebDriver oWebDriver;
        public Dictionary<string, string> oHashTable;
        public CanadaFR(IWebDriver webDriver)
        {
            oWebDriver = webDriver;
        }

        [TestMethod]
        public void CanadaFR_MailTest()
        {
            try
            {
                oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");

                if (WebPageUtility.IsElementPresent(By.XPath(".//*[@id='AddressLine1']")))
                {
                    WebPageUtility.inputTextByXpath(".//*[@id='AddressLine1']", oHashTable["AddressLine1_Line_CanadaFR"].ToString());
                    WebPageUtility.inputTextByXpath(".//*[@id='HouseNumber']", oHashTable["HouseNumber_Line_CanadaFR"].ToString());
                }

                WebPageUtility.WaitForAjax(oWebDriver);
                var PostalCode = oWebDriver.FindElement(By.XPath(".//*[@id='PostalCode']"));
                if (WebPageUtility.IsElementPresent(By.XPath(".//*[@id='PostalCode']")) && PostalCode.Displayed)
                {
                    if (PostalCode.GetAttribute("value").Equals(string.Empty))
                    {
                        PostalCode.Clear();
                        Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='PostalCode']", oHashTable["PostalCode_CanadaFR"].ToString()), "PostalCode Fails to load");
                    }
                }


                IWebElement Mobelement = oWebDriver.FindElement(By.Id("MobilePhone"));
                if (Mobelement.Displayed)
                {
                    WebDriverWait waitForElement = new WebDriverWait(oWebDriver, TimeSpan.FromSeconds(600));

                    if (WebPageUtility.IsElementPresent(By.CssSelector("#AreaCodeMobilePhone")))
                    {
                        IWebElement areaCode = oWebDriver.FindElement(By.Id("AreaCodeMobilePhone"));
                        SelectElement selectAreaCode = new SelectElement(areaCode);
                        selectAreaCode.SelectByIndex(1);

                    }
                    else
                    {
                        WebPageUtility.clickElementByID("PhoneRadio_0");
                        Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='MobilePhone']", oHashTable["MobilePhone_Line_CanadaFR"].ToString()));
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

                    WebPageUtility.WaitForAjax(oWebDriver);
                    Reporter.ReportEvent("Pass", "CS Pass", "Verified");

                }
            }
            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "CS Failed", ex.Message);
            }

        }
    }


        /// <summary>
        /// Finland
        /// </summary>
        class Finland
        {
            public IWebDriver oWebDriver;
            public Dictionary<string, string> oHashTable;
            public Finland(IWebDriver webDriver)
            {
                oWebDriver = webDriver;
            }

            [TestMethod]
            public void Finland_MailTest()
            {
                try
                {
                    oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");


                    var element = oWebDriver.FindElement(By.XPath(".//*[@id='MobilePhone']"));
                    IJavaScriptExecutor js = (IJavaScriptExecutor)oWebDriver;
                    js.ExecuteScript("arguments[0].scrollIntoView(true);", element);

                    if (WebPageUtility.IsElementPresent(By.XPath(".//*[@id='AddressLine1']")))
                    {
                        Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='AddressLine1']", oHashTable["AddressLine1_Line_Fin"].ToString()), "Address Fails to load");
                        Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='HouseNumber']", oHashTable["HouseNumber_Line_Fin"].ToString()), "Housenumber Fails to load");
                    }

                    WebPageUtility.WaitForAjax(oWebDriver);
                    var PostalCode = oWebDriver.FindElement(By.XPath(".//*[@id='PostalCode']"));
                    if (WebPageUtility.IsElementPresent(By.XPath(".//*[@id='PostalCode']")))
                    {
                        PostalCode.Clear();
                        Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='PostalCode']", oHashTable["PostalCode_Fin"].ToString()), "PostalCode Fails to load");
                    }
                    WebPageUtility.clickElementByID("PhoneRadio_0");
                    Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='MobilePhone']", oHashTable["MobilePhone_Line_Fin"].ToString()), "Mobile Number Fails to load");
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

                    WebPageUtility.WaitForAjax(oWebDriver);
                    Reporter.ReportEvent("Pass", "CS Pass", "Verified");

                }
                catch (Exception ex)
                {
                    Reporter.ReportEvent("Fail", "CS Failed", ex.Message);
                }

            }
       }
   }
    




                                        
                   








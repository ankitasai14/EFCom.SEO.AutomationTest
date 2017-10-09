using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Rentals._02_Utility_Tier;
using Rentals._03_Application_Tier.ApplicationTests;
using System;
using System.Collections.Generic;

namespace Rentals._03_Application_Tier.PageObjects
{
    [TestClass]
    // ALL Markets code, which is in this test
    public class Markets_AE_AU_AZ_DK_JP_KR_CA_TW_CH_CS : TestDriver
    {

    }





    /// <summary>
    /// United Arab Emirates (Arabic) =AE
    /// </summary>
    class AE
    {
        [FindsBy(How = How.XPath, Using = ".//*[@id='AddressLine1']")]
        public IWebElement houseInfoForAE { get; set; }

        public IWebDriver oWebDriver;
        public Dictionary<string, string> oHashTable;
        public AE(IWebDriver webDriver)
        {
            oWebDriver = webDriver;
        }

        [TestMethod]
        public void UnitedArabEmirates_MailTest()
        {
            oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");

            IWebElement citizenship = oWebDriver.FindElement(By.Id("CitizenshipCode"));

            SelectElement selectCitizenship = new SelectElement(citizenship);
            IList<IWebElement> options = selectCitizenship.Options;

            IWebElement firstOption = options[10];
            firstOption.Click();

            WebPageUtility.WaitForAjax(oWebDriver);

            var element = oWebDriver.FindElement(By.XPath(".//*[@id='MobilePhone']"));
            IJavaScriptExecutor js = (IJavaScriptExecutor)oWebDriver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);


            WebPageUtility.clickElementByID("PhoneRadio_0");
            Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='MobilePhone']", oHashTable["MobilePhone_Line_AE"].ToString()), "Mobile Number Fails to load");
            IWebElement days = oWebDriver.FindElement(By.Id("Days"));

            SelectElement selectList = new SelectElement(days);
            options = selectList.Options;

            firstOption = options[1];

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
    /// <summary>
    /// Australia = AU
    /// </summary>
    class AU
    {

    }
    /// <summary>
    /// Azerbeigan = AZ
    /// </summary>
    class AZ
    {

    }
    /// <summary>
    /// Denmark = DK
    /// </summary>
    class DK
    {
        public IWebDriver oWebDriver;
        public Dictionary<string, string> oHashTable;
        public DK(IWebDriver webDriver)
        {
            oWebDriver = webDriver;
        }

        [TestMethod]
        public void Denmark_MailTest()
        {
            oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");

            var element = oWebDriver.FindElement(By.XPath(".//*[@id='MobilePhone']"));
            IJavaScriptExecutor js = (IJavaScriptExecutor)oWebDriver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);

            IWebElement houseInfo = oWebDriver.FindElement(By.XPath(".//*[@id='HouseNumber']"));

            if (houseInfo.Displayed)
            {

                Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='AddressLine1']", oHashTable["AddressLine1_Line_DK"].ToString()), "Address Fails to load");
                Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='HouseNumber']", oHashTable["HouseNumber_Line_DK"].ToString()), "Housenumber Fails to load");
            }
            WebPageUtility.WaitForAjax(oWebDriver);
            var PostalCode = oWebDriver.FindElement(By.XPath(".//*[@id='PostalCode']"));
            if (PostalCode.Displayed)
            {
                PostalCode.Clear();

                Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='PostalCode']", oHashTable["PostalCode_DK"].ToString()), "PostalCode Fails to load");
            }
            WebPageUtility.clickElementByID("PhoneRadio_0");
            Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='MobilePhone']", oHashTable["MobilePhone_Line_DK"].ToString()), "Mobile Number Fails to load");



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


    /// <summary>
    /// Japan = JP
    /// </summary>
    class JP
    {

    }
    /// <summary>
    /// Korea = KR
    /// </summary>
    class KR
    {

    }
    /// <summary>
    /// Canada = CA
    /// </summary>
    class CA
    {
        public IWebDriver oWebDriver;
        public Dictionary<string, string> oHashTable;
        public CA(IWebDriver webDriver)
        {
            oWebDriver = webDriver;
        }

        [TestMethod]
        public void Canada_MailTest()
        {
            try
            {
                oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");

                IWebElement houseInfo = oWebDriver.FindElement(By.XPath(".//*[@id='AddressLine1']"));
                var element = oWebDriver.FindElement(By.XPath(".//*[@id='MobilePhone']"));
                IJavaScriptExecutor js = (IJavaScriptExecutor)oWebDriver;
                js.ExecuteScript("arguments[0].scrollIntoView(true);", element);

                if (WebPageUtility.IsElementPresent(By.CssSelector(".form-group.heading-divider.-address")))
                {
                    IWebElement addressVisibility = oWebDriver.FindElement(By.CssSelector(".form-group.heading-divider.-address"));
                    if (addressVisibility.Displayed)
                    {
                        IWebElement addressText = oWebDriver.FindElement(By.XPath(".//*[@id='AddressLine1']"));
                        Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='AddressLine1']", oHashTable["AddressLine1_Line_CA"].ToString()));
                        addressText.SendKeys(Keys.Tab);
                   
                        if (WebPageUtility.IsElementPresent(By.Id("HouseNumber")))
                        {                               
                            IWebElement houseVerify = oWebDriver.FindElement(By.XPath(".//*[@id='HouseNumber']"));
                            if (houseVerify.Displayed)
                            {
                                Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='HouseNumber']", oHashTable["HouseNumber_Line_CA"].ToString()));
                                houseVerify.SendKeys(Keys.Tab);
                            }

                            }
                         }
                     }
                   
                    var PostalCode = oWebDriver.FindElement(By.XPath(".//*[@id='PostalCode']"));
                    if (PostalCode.Displayed)
                    {
                        PostalCode.Clear();

                        Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='PostalCode']", oHashTable["PostalCode_CA"].ToString()), "PostalCode Fails to load");
                    }
                    WebPageUtility.clickElementByID("PhoneRadio_0");
                    Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='MobilePhone']", oHashTable["MobilePhone_Line_CA"].ToString()), "Mobile Number Fails to load");
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

                    if (WebPageUtility.IsElementPresent(By.Id("Gender_0")))
                    {
                        IWebElement gender = oWebDriver.FindElement(By.Id("Gender_0"));
                        js.ExecuteScript("arguments[0].scrollIntoView(true);", gender);

                        WebDriverWait waitForElement = new WebDriverWait(oWebDriver, TimeSpan.FromSeconds(500));

                        WebPageUtility.clickElementByID("Gender_0");
                    }
                    WebPageUtility.clickElementByID("YesEmailMarketing");
                    Reporter.ReportEvent("Pass", "All Fileds entered", "Verified");

                    WebPageUtility.WaitForAjax(oWebDriver);
                    Reporter.ReportEvent("Pass", "CA Pass", "Verified");
                }

            
            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "CA Failed", ex.Message);
            }

        }
    }


    /// <summary>
    /// Taiwan = TW
    /// </summary>
    class TW
    {
        public IWebDriver oWebDriver;
        public Dictionary<string, string> oHashTable;
        public TW(IWebDriver webDriver)
        {
            oWebDriver = webDriver;
        }

        [TestMethod]
        public void Taiwan_MailTest()
        {
            try
            {
                oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                IList<IWebElement> options = null;

                IWebElement houseInfo = oWebDriver.FindElement(By.XPath(".//*[@id='AddressLine1']"));
                var element = oWebDriver.FindElement(By.XPath(".//*[@id='MobilePhone']"));

                IJavaScriptExecutor js = (IJavaScriptExecutor)oWebDriver;
                js.ExecuteScript("arguments[0].scrollIntoView(true);", houseInfo);


                if (houseInfo.Displayed)
                {
                    Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='AddressLine1']", oHashTable["AddressLine1_Line_TW"].ToString()), "Address Fails to load");
                    oWebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1000);

                    houseInfo.SendKeys(Keys.Tab);
                    WebPageUtility.clickElementByXpath(".//*[@id='HouseNumber']");
                    Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='HouseNumber']", oHashTable["HouseNumber_Line_TW"].ToString()), "Housenumber Fails to load");
                }
                oWebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);

                var PostalCode = oWebDriver.FindElement(By.XPath(".//*[@id='PostalCode']"));
                PostalCode.SendKeys(Keys.Tab);
                if (WebPageUtility.IsElementPresent(By.XPath(".//*[@id='PostalCode']")))
                {
                    PostalCode.Clear();
                    Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='PostalCode']", oHashTable["PostalCode_TW"].ToString()), "PostalCode Fails to load");
                }


                if (WebPageUtility.IsElementPresent(By.Name("City")))
                {
                    Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='City']", oHashTable["City_TW"].ToString()), "city Fails to load");

                    oWebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
                    IWebElement state = oWebDriver.FindElement(By.Name("State"));
                    SelectElement selectStateList = new SelectElement(state);
                    selectStateList.SelectByValue("TPE|台北市|0|Taipei City|");

                    //IWebElement StateOption = options[4];
                    //StateOption.Click();
                }


                oWebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
                WebPageUtility.clickElementByID("PhoneRadio_1");
                WebPageUtility.inputTextByXpath(".//*[@id='HomePhone']", oHashTable["HomePhone_TW"].ToString());

                IWebElement days = oWebDriver.FindElement(By.Id("Days"));

                SelectElement selectList = new SelectElement(days);
                options = selectList.Options;
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
                Reporter.ReportEvent("Pass", "TW Pass", "Verified");

            }
            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "TW Failed", ex.Message);
            }

        }
    }
    /// <summary>
    /// Switzerland (French) = SwissCH
    /// </summary>
    class CH
    {
        public IWebDriver oWebDriver;
        public Dictionary<string, string> oHashTable;
        public CH(IWebDriver webDriver)
        {
            oWebDriver = webDriver;
        }

        [TestMethod]
        public void SwitzerlandFrench_MailTest()
        {
            try
            {
                oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");


                var element = oWebDriver.FindElement(By.XPath(".//*[@id='MobilePhone']"));
                IJavaScriptExecutor js = (IJavaScriptExecutor)oWebDriver;
                js.ExecuteScript("arguments[0].scrollIntoView(true);", element);

                if (WebPageUtility.IsElementPresent(By.XPath(".//*[@id='AddressLine1']")))
                {
                    Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='AddressLine1']", oHashTable["AddressLine1_Line_SwissCH"].ToString()), "Address Fails to load");
                    Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='HouseNumber']", oHashTable["HouseNumber_Line_SwissCH"].ToString()), "Housenumber Fails to load");
                }

                WebPageUtility.WaitForAjax(oWebDriver);
                var PostalCode = oWebDriver.FindElement(By.XPath(".//*[@id='PostalCode']"));
                if (WebPageUtility.IsElementPresent(By.XPath(".//*[@id='PostalCode']")))
                {
                    PostalCode.Clear();
                    Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='PostalCode']", oHashTable["PostalCode_SwissCH"].ToString()), "PostalCode Fails to load");
                }
                WebPageUtility.clickElementByID("PhoneRadio_0");
                Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='MobilePhone']", oHashTable["MobilePhone_Line_SwissCH"].ToString()), "Mobile Number Fails to load");
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
                Reporter.ReportEvent("Pass", "CH Pass", "Verified");

            }
            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "CH Failed", ex.Message);
            }

        }
    }


    /// <summary>
    /// Switzerland (German) = SwissDE
    /// </summary>
    class CS
    {
        public IWebDriver oWebDriver;
        public Dictionary<string, string> oHashTable;
        public CS(IWebDriver webDriver)
        {
            oWebDriver = webDriver;
        }

        [TestMethod]
        public void SwitzerlandFrench_MailTest()
        {
            try
            {
                oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");


                var element = oWebDriver.FindElement(By.XPath(".//*[@id='MobilePhone']"));
                IJavaScriptExecutor js = (IJavaScriptExecutor)oWebDriver;
                js.ExecuteScript("arguments[0].scrollIntoView(true);", element);

                if (WebPageUtility.IsElementPresent(By.XPath(".//*[@id='AddressLine1']")))
                {
                    var address = oWebDriver.FindElement(By.XPath(".//*[@id='AddressLine1']"));
                    if (address.Displayed)
                    {
                        Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='AddressLine1']", oHashTable["AddressLine1_Line_SwissDE"].ToString()), "Address Fails to load");
                        Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='HouseNumber']", oHashTable["HouseNumber_Line_SwissDE"].ToString()), "Housenumber Fails to load");
                    }
                 
                }

                WebPageUtility.WaitForAjax(oWebDriver);
                var PostalCode = oWebDriver.FindElement(By.XPath(".//*[@id='PostalCode']"));
                if (WebPageUtility.IsElementPresent(By.XPath(".//*[@id='PostalCode']")))
                {
                    PostalCode.Clear();
                    Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='PostalCode']", oHashTable["PostalCode_SwissDE"].ToString()), "PostalCode Fails to load");
                }
                WebPageUtility.clickElementByID("PhoneRadio_0");
                Assert.IsTrue(WebPageUtility.inputTextByXpath(".//*[@id='MobilePhone']", oHashTable["MobilePhone_Line_SwissDE"].ToString()), "Mobile Number Fails to load");
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

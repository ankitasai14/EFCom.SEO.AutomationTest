using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rentals._02_Utility_Tier;
using Rentals.Resources;
using Rentals._03_Application_Tier.PageObjects;
using Rentals._01_Configuration_Tier.EnvironmentFiles;
using System.Collections.Generic;
using OpenQA.Selenium;

namespace Rentals._03_Application_Tier.ApplicationTests.Functional_Tests
{
    [TestClass]

    /*
    Finland (Swedish)
    United Kingdom
    Greece
    Hong Kong
    Croatia
    Hungary    
    Ireland
    India
    Iran 
    Turkey
    Venezuela
    Kazakhstan
    Luxembourg(German)
    Brazil
    Lithuania 
    Luxembourg(French) */

    public class ListOfMarkets_01 : TestDriver
    {
        public Dictionary<string, string> oHashTable;
        enum ProductCode
        {
            ILS, LY, ETOWN, IA
        };

        string validField = "FirstName";
        
        //one section 
        [TestMethod, TestCategory(" Finland(Swedish) smoke test")]
        public void FinlandSwedish_BrochureTestWithEmail_PG_Allforms()
        {
            try
            {


                Console.WriteLine("Brochure page");
                Reporter.startTest("Brouchure fields Verification", "Creating Brouchure scenario");
                Reporter.AssignCategory("Brochurepage", "ProgramGuide");
                Reporter.strCurrentTestID = "TS001";
                //*******************************************************************************************************
                string dataFileToRefer = null; string dataSheetToRefer = null; string RunFlag = null;
                Helper.getTestDataDetails("'TS001'", out dataFileToRefer, out dataSheetToRefer, out RunFlag);
                foreach (ProductCode code in Enum.GetValues(typeof(ProductCode)))
                {
                    BrochurePage BP = new BrochurePage(TestDriver.webDriver);
                    WebPageUtility.naviGateToUrl(Resource_TestData.FinlandSwedPgUrl+code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {


                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.BrochureForOneSection(oHashTable["AddressLine1_Line_FinlandSw"].ToString(), oHashTable["HouseNumber_Line_FinlandSw"].ToString(), oHashTable["PostalCode_FinlandSw"].ToString(), oHashTable["MobilePhone_Line_FinlandSw"].ToString(), oHashTable["City_FinlandSw"].ToString(), "", "India", "");

                        BP.SubmitPage();
                        BP.verifytheTestRedirectedToThankYouPage();
                        Assert.IsTrue(true, "");
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "Brochure Scenario", ex.Message);
                Assert.Fail("Known Fail");

                Reporter.EndTest();
            }

        }

        [TestMethod, TestCategory("Greece smoke test")]
        public void Greece_BrochureTestWithEmail_PG_Allforms()
        {
            try
            {


                Console.WriteLine("Brochure page");
                Reporter.startTest("Brouchure fields Verification", "Creating Brouchure scenario");
                Reporter.AssignCategory("Brochurepage", "ProgramGuide");
                Reporter.strCurrentTestID = "TS001";
                //*******************************************************************************************************
                string dataFileToRefer = null; string dataSheetToRefer = null; string RunFlag = null;
                Helper.getTestDataDetails("'TS001'", out dataFileToRefer, out dataSheetToRefer, out RunFlag);
                oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                foreach (ProductCode code in Enum.GetValues(typeof(ProductCode)))
                {   
                    BrochurePage BP = new BrochurePage(TestDriver.webDriver);
                    WebPageUtility.naviGateToUrl(Resource_TestData.GreecePgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {

                        BP.RadioButtonForPostAndDeliveryOption();

                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);

                        markets.Brochure(oHashTable["AddressLine1_Line_Common"].ToString(), oHashTable["HouseNumber_Line_Common"].ToString(), oHashTable["PostalCode_Common"].ToString(), oHashTable["MobilePhone_Line_Common"].ToString(), oHashTable["City_Common"].ToString(), "");

                        BP.SubmitPage();
                        BP.verifytheTestRedirectedToThankYouPage();
                        Assert.IsTrue(true, "");
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "Brochure Scenario", ex.Message);
                Assert.Fail("Known Fail");

                Reporter.EndTest();
            }

        }


        [TestMethod, TestCategory("Greece smoke test")]
        public void Greece_BrochureTestWithEmail_PG_Allforms_PostDelivery()
        {
            try
            {


                Console.WriteLine("Brochure page");
                Reporter.startTest("Brouchure fields Verification", "Creating Brouchure scenario");
                Reporter.AssignCategory("Brochurepage", "ProgramGuide");
                Reporter.strCurrentTestID = "TS001";
                //*******************************************************************************************************
                string dataFileToRefer = null; string dataSheetToRefer = null; string RunFlag = null;
                Helper.getTestDataDetails("'TS001'", out dataFileToRefer, out dataSheetToRefer, out RunFlag);
                foreach (ProductCode code in Enum.GetValues(typeof(ProductCode)))
                {
                    BrochurePage BP = new BrochurePage(TestDriver.webDriver);
                    WebPageUtility.naviGateToUrl(Resource_TestData.GreecePgUrl + code.ToString(), Env.strBrowserTitle, "");


                    BP.VerifyBrochureCommonFields();
                    Common_Method markets = new Common_Method(TestDriver.webDriver);
                    oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                    markets.Brochure(oHashTable["AddressLine1_Line_CA"].ToString(), oHashTable["HouseNumber_Line_CA"].ToString(), oHashTable["PostalCode_CA"].ToString(), oHashTable["MobilePhone_Line_CA"].ToString(), oHashTable["City_CA"].ToString(), "");

                    BP.SubmitPage();
                    BP.verifytheTestRedirectedToThankYouPage();
                    Assert.IsTrue(true, "");
                }
            }

            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "Brochure Scenario", ex.Message);
                Assert.Fail("Known Fail");

                Reporter.EndTest();
            }

        }

        [TestMethod, TestCategory("Markets- Chinese & Dutch")]
        public void HongKong_BrochureTestWithEmail_PG_Allforms()
        {
            try
            {
                Console.WriteLine("Brochure page");
                Reporter.startTest("Brouchure fields Verification", "Creating Brouchure scenario");
                Reporter.AssignCategory("Brochurepage", "ProgramGuide");
                Reporter.strCurrentTestID = "TS001";
                //*******************************************************************************************************
                string dataFileToRefer = null; string dataSheetToRefer = null; string RunFlag = null;
                Helper.getTestDataDetails("'TS001'", out dataFileToRefer, out dataSheetToRefer, out RunFlag);
                foreach (ProductCode code in Enum.GetValues(typeof(ProductCode)))
                {
                    BrochurePage BP = new BrochurePage(TestDriver.webDriver);
                    WebPageUtility.naviGateToUrl(Resource_TestData.HongKongPgUrl + code.ToString(), Env.strBrowserTitle, "");

                    if (WebPageUtility.IsElementPresent(By.Id(validField)) || WebPageUtility.IsElementPresent(By.Id("LastName")))
                    {
                        BP.RadioButtonForPostAndEmailOption();

                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_HongKong"].ToString(), oHashTable["HouseNumber_Line_HongKong"].ToString(), oHashTable["PostalCode_HongKong"].ToString(), oHashTable["MobilePhone_Line_HongKong"].ToString(), oHashTable["City_HongKong"].ToString(), "");

                        BP.SubmitPage();
                        BP.verifytheTestRedirectedToThankYouPage();
                        Assert.IsTrue(true, "");
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            

            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "Brochure Scenario", ex.Message);
                Assert.Fail("Known Fail");

                Reporter.EndTest();
            }

        }

        [TestMethod, TestCategory("Markets- Chinese & Dutch")]
        public void HongKong_BrochureTestWithEmail_PG_Allforms_PostDelivery()
        {
            try
            {


                Console.WriteLine("Brochure page");
                Reporter.startTest("Brouchure fields Verification", "Creating Brouchure scenario");
                Reporter.AssignCategory("Brochurepage", "ProgramGuide");
                Reporter.strCurrentTestID = "TS001";
                //*******************************************************************************************************
                string dataFileToRefer = null; string dataSheetToRefer = null; string RunFlag = null;
                Helper.getTestDataDetails("'TS001'", out dataFileToRefer, out dataSheetToRefer, out RunFlag);
                foreach (ProductCode code in Enum.GetValues(typeof(ProductCode)))
                {
                    BrochurePage BP = new BrochurePage(TestDriver.webDriver);
                    WebPageUtility.naviGateToUrl(Resource_TestData.HongKongPgUrl + code.ToString(), Env.strBrowserTitle, "");

                    if (WebPageUtility.IsElementPresent(By.Id(validField)))
                    {
                        BP.RadioButtonForPostAndDeliveryOption();

                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_CA"].ToString(), oHashTable["HouseNumber_Line_CA"].ToString(), oHashTable["PostalCode_CA"].ToString(), oHashTable["MobilePhone_Line_CA"].ToString(), oHashTable["City_CA"].ToString(), "");

                        BP.SubmitPage();
                        BP.verifytheTestRedirectedToThankYouPage();
                        Assert.IsTrue(true, "");
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "Brochure Scenario", ex.Message);
                Assert.Fail("Known Fail");

                Reporter.EndTest();
            }

        }

        [TestMethod, TestCategory("Croatia smoke test")]
        public void CroatiaBrochureTestWithEmail_PG_Allforms()
        {
            try
            {


                Console.WriteLine("Brochure page");
                Reporter.startTest("Brouchure fields Verification", "Creating Brouchure scenario");
                Reporter.AssignCategory("Brochurepage", "ProgramGuide");
                Reporter.strCurrentTestID = "TS001";
                //*******************************************************************************************************
                string dataFileToRefer = null; string dataSheetToRefer = null; string RunFlag = null;
                Helper.getTestDataDetails("'TS001'", out dataFileToRefer, out dataSheetToRefer, out RunFlag);
                foreach (ProductCode code in Enum.GetValues(typeof(ProductCode)))
                {
                    BrochurePage BP = new BrochurePage(TestDriver.webDriver);
                    WebPageUtility.naviGateToUrl(Resource_TestData.CroatiaPgUrl + code.ToString(), Env.strBrowserTitle, "");


                    if (WebPageUtility.IsElementPresent(By.Id(validField)))
                    {
                        BP.RadioButtonForPostAndEmailOption();

                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_CA"].ToString(), oHashTable["HouseNumber_Line_CA"].ToString(), oHashTable["PostalCode_CA"].ToString(), oHashTable["MobilePhone_Line_CA"].ToString(), oHashTable["City_CA"].ToString(), "");

                        BP.SubmitPage();
                        BP.verifytheTestRedirectedToThankYouPage();
                        Assert.IsTrue(true, "");
                    }

                    else
                    {
                        continue;
                    }
                }
            }

            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "Brochure Scenario", ex.Message);
                Assert.Fail("Known Fail");

                Reporter.EndTest();
            }

        }

        [TestMethod, TestCategory("Croatia smoke test")]
        public void Croatia_BrochureTestWithEmail_PG_Allforms_PostDelivery()
        {
            try
            {


                Console.WriteLine("Brochure page");
                Reporter.startTest("Brouchure fields Verification", "Creating Brouchure scenario");
                Reporter.AssignCategory("Brochurepage", "ProgramGuide");
                Reporter.strCurrentTestID = "TS001";
                //*******************************************************************************************************
                string dataFileToRefer = null; string dataSheetToRefer = null; string RunFlag = null;
                Helper.getTestDataDetails("'TS001'", out dataFileToRefer, out dataSheetToRefer, out RunFlag);
                foreach (ProductCode code in Enum.GetValues(typeof(ProductCode)))
                {
                    BrochurePage BP = new BrochurePage(TestDriver.webDriver);
                    WebPageUtility.naviGateToUrl(Resource_TestData.CroatiaPgUrl + code.ToString(), Env.strBrowserTitle, "");

                    if (WebPageUtility.IsElementPresent(By.Id(validField)))
                    {

                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_CA"].ToString(), oHashTable["HouseNumber_Line_CA"].ToString(), oHashTable["PostalCode_CA"].ToString(), oHashTable["MobilePhone_Line_CA"].ToString(), oHashTable["City_CA"].ToString(), "");

                        BP.SubmitPage();
                        BP.verifytheTestRedirectedToThankYouPage();
                        Assert.IsTrue(true, "");
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "Brochure Scenario", ex.Message);
                Assert.Fail("Known Fail");

                Reporter.EndTest();
            }

        }



        [TestMethod,TestCategory("Markets- French")]
        public void Hungary_BrochureTestWithEmail_PG_Allforms()
        {
            try
            {


                Console.WriteLine("Brochure page");
                Reporter.startTest("Brouchure fields Verification", "Creating Brouchure scenario");
                Reporter.AssignCategory("Brochurepage", "ProgramGuide");
                Reporter.strCurrentTestID = "TS001";
                //*******************************************************************************************************
                string dataFileToRefer = null; string dataSheetToRefer = null; string RunFlag = null;
                Helper.getTestDataDetails("'TS001'", out dataFileToRefer, out dataSheetToRefer, out RunFlag);
                foreach (ProductCode code in Enum.GetValues(typeof(ProductCode)))
                {
                    BrochurePage BP = new BrochurePage(TestDriver.webDriver);
                    WebPageUtility.naviGateToUrl(Resource_TestData.HungaryPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    BP.RadioButtonForPostAndEmailOption();

                    if (WebPageUtility.IsElementPresent(By.Id(validField)))
                    {
                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_Hungary"].ToString(), oHashTable["HouseNumber_Line_Hungary"].ToString(), oHashTable["PostalCode_Hungary"].ToString(), oHashTable["MobilePhone_Line_Hungary"].ToString(), oHashTable["City_Hungary"].ToString(), "");

                        BP.SubmitPage();
                        BP.verifytheTestRedirectedToThankYouPage();
                        Assert.IsTrue(true, "");
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "Brochure Scenario", ex.Message);
                Assert.Fail("Known Fail");

                Reporter.EndTest();
            }

        }


        [TestMethod, TestCategory("Markets- French")]
        public void Hungary_BrochureTestWithEmail_PG_Allforms_PostDelivery()
        {
            try
            {


                Console.WriteLine("Brochure page");
                Reporter.startTest("Brouchure fields Verification", "Creating Brouchure scenario");
                Reporter.AssignCategory("Brochurepage", "ProgramGuide");
                Reporter.strCurrentTestID = "TS001";
                //*******************************************************************************************************
                string dataFileToRefer = null; string dataSheetToRefer = null; string RunFlag = null;
                Helper.getTestDataDetails("'TS001'", out dataFileToRefer, out dataSheetToRefer, out RunFlag);
                foreach (ProductCode code in Enum.GetValues(typeof(ProductCode)))
                {
                    BrochurePage BP = new BrochurePage(TestDriver.webDriver);
                    WebPageUtility.naviGateToUrl(Resource_TestData.HungaryPgUrl + code.ToString(), Env.strBrowserTitle, "");

                    if (WebPageUtility.IsElementPresent(By.Id(validField)))
                    {

                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_Hungary"].ToString(), oHashTable["HouseNumber_Line_Hungary"].ToString(), oHashTable["PostalCode_Hungary"].ToString(), oHashTable["MobilePhone_Line_Hungary"].ToString(), oHashTable["City_Hungary"].ToString(), "");

                        BP.SubmitPage();
                        BP.verifytheTestRedirectedToThankYouPage();
                        Assert.IsTrue(true, "");
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "Brochure Scenario", ex.Message);
                Assert.Fail("Known Fail");

                Reporter.EndTest();
            }

        }


        [TestMethod, TestCategory("Markets- English")]
        public void Ireland_BrochureTestWithEmail_PG_Allforms()
        {
            try
            {


                Console.WriteLine("Brochure page");
                Reporter.startTest("Brouchure fields Verification", "Creating Brouchure scenario");
                Reporter.AssignCategory("Brochurepage", "ProgramGuide");
                Reporter.strCurrentTestID = "TS001";
                //*******************************************************************************************************
                string dataFileToRefer = null; string dataSheetToRefer = null; string RunFlag = null;
                Helper.getTestDataDetails("'TS001'", out dataFileToRefer, out dataSheetToRefer, out RunFlag);
                foreach (ProductCode code in Enum.GetValues(typeof(ProductCode)))
                {
                    BrochurePage BP = new BrochurePage(TestDriver.webDriver);
                    WebPageUtility.naviGateToUrl(Resource_TestData.IrelandPgUrl + code.ToString(), Env.strBrowserTitle, "");

                    if (WebPageUtility.IsElementPresent(By.Id(validField)))
                    {
                        BP.RadioButtonForPostAndEmailOption();

                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_Ireland"].ToString(), oHashTable["HouseNumber_Line_Ireland"].ToString(), oHashTable["PostalCode_Ireland"].ToString(), oHashTable["MobilePhone_Line_Ireland"].ToString(), oHashTable["City_Ireland"].ToString(), "");

                        BP.SubmitPage();
                        BP.verifytheTestRedirectedToThankYouPage();
                        Assert.IsTrue(true, "");
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "Brochure Scenario", ex.Message);
                Assert.Fail("Known Fail");

                Reporter.EndTest();
            }

        }


        [TestMethod, TestCategory("Markets- English")]
        public void Ireland_BrochureTestWithEmail_PG_Allforms_PostDelivery()
        {
            try
            {


                Console.WriteLine("Brochure page");
                Reporter.startTest("Brouchure fields Verification", "Creating Brouchure scenario");
                Reporter.AssignCategory("Brochurepage", "ProgramGuide");
                Reporter.strCurrentTestID = "TS001";
                //*******************************************************************************************************
                string dataFileToRefer = null; string dataSheetToRefer = null; string RunFlag = null;
                Helper.getTestDataDetails("'TS001'", out dataFileToRefer, out dataSheetToRefer, out RunFlag);
                foreach (ProductCode code in Enum.GetValues(typeof(ProductCode)))
                {
                    BrochurePage BP = new BrochurePage(TestDriver.webDriver);
                    WebPageUtility.naviGateToUrl(Resource_TestData.IrelandPgUrl + code.ToString(), Env.strBrowserTitle, "");

                    if (WebPageUtility.IsElementPresent(By.Id(validField)))
                    {

                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_Ireland"].ToString(), oHashTable["HouseNumber_Line_Ireland"].ToString(), oHashTable["PostalCode_Ireland"].ToString(), oHashTable["MobilePhone_Line_Ireland"].ToString(), oHashTable["City_Ireland"].ToString(), "");


                        BP.SubmitPage();
                        BP.verifytheTestRedirectedToThankYouPage();
                        Assert.IsTrue(true, "");
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "Brochure Scenario", ex.Message);
                Assert.Fail("Known Fail");

                Reporter.EndTest();
            }

        }


        [TestMethod, TestCategory("Turkey smoke test")]
        public void Turkey_BrochureTestWithEmail_PG_Allforms()
        {
            try
            {


                Console.WriteLine("Brochure page");
                Reporter.startTest("Brouchure fields Verification", "Creating Brouchure scenario");
                Reporter.AssignCategory("Brochurepage", "ProgramGuide");
                Reporter.strCurrentTestID = "TS001";
                //*******************************************************************************************************
                string dataFileToRefer = null; string dataSheetToRefer = null; string RunFlag = null;
                Helper.getTestDataDetails("'TS001'", out dataFileToRefer, out dataSheetToRefer, out RunFlag);
                foreach (ProductCode code in Enum.GetValues(typeof(ProductCode)))
                {
                    BrochurePage BP = new BrochurePage(TestDriver.webDriver);
                    WebPageUtility.naviGateToUrl(Resource_TestData.TurkeyPgUrl + code.ToString(), Env.strBrowserTitle, "");

                    if (WebPageUtility.IsElementPresent(By.Id(validField)))
                    {
                        BP.RadioButtonForPostAndEmailOption();

                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_Turkey"].ToString(), oHashTable["HouseNumber_Line_Turkey"].ToString(), oHashTable["PostalCode_Turkey"].ToString(), oHashTable["MobilePhone_Line_Turkey"].ToString(), oHashTable["City_Turkey"].ToString(), "İstanbul - Avrupa");
                        markets.hasAcceptedPrivacyPolicyTickBox();
                        BP.SubmitPage();
                        BP.verifytheTestRedirectedToThankYouPage();
                        Assert.IsTrue(true, "");
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "Brochure Scenario", ex.Message);
                Assert.Fail("Known Fail");

                Reporter.EndTest();
            }

        }


        [TestMethod, TestCategory("Turkey smoke test")]
        public void Turkey_BrochureTestWithEmail_PG_Allforms_PostDelivery()
        {
            try
            {


                Console.WriteLine("Brochure page");
                Reporter.startTest("Brouchure fields Verification", "Creating Brouchure scenario");
                Reporter.AssignCategory("Brochurepage", "ProgramGuide");
                Reporter.strCurrentTestID = "TS001";
                //*******************************************************************************************************
                string dataFileToRefer = null; string dataSheetToRefer = null; string RunFlag = null;
                Helper.getTestDataDetails("'TS001'", out dataFileToRefer, out dataSheetToRefer, out RunFlag);
                foreach (ProductCode code in Enum.GetValues(typeof(ProductCode)))
                {
                    BrochurePage BP = new BrochurePage(TestDriver.webDriver);
                    WebPageUtility.naviGateToUrl(Resource_TestData.TurkeyPgUrl + code.ToString(), Env.strBrowserTitle, "");

                    if (WebPageUtility.IsElementPresent(By.Id(validField)))
                    {

                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_Turkey"].ToString(), oHashTable["HouseNumber_Line_Turkey"].ToString(), oHashTable["PostalCode_Turkey"].ToString(), oHashTable["MobilePhone_Line_Turkey"].ToString(), oHashTable["City_Turkey"].ToString(), "İstanbul - Avrupa");
                        markets.hasAcceptedPrivacyPolicyTickBox();

                        BP.SubmitPage();
                        BP.verifytheTestRedirectedToThankYouPage();
                        Assert.IsTrue(true, "");
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "Brochure Scenario", ex.Message);
                Assert.Fail("Known Fail");

                Reporter.EndTest();
            }

        }

        [TestMethod, TestCategory("Kazakhstan smoke test")]
        public void Kazakhstan_BrochureTestWithEmail_PG_Allforms()
        {
            try
            {


                Console.WriteLine("Brochure page");
                Reporter.startTest("Brouchure fields Verification", "Creating Brouchure scenario");
                Reporter.AssignCategory("Brochurepage", "ProgramGuide");
                Reporter.strCurrentTestID = "TS001";
                //*******************************************************************************************************
                string dataFileToRefer = null; string dataSheetToRefer = null; string RunFlag = null;
                Helper.getTestDataDetails("'TS001'", out dataFileToRefer, out dataSheetToRefer, out RunFlag);
                foreach (ProductCode code in Enum.GetValues(typeof(ProductCode)))
                {
                    BrochurePage BP = new BrochurePage(TestDriver.webDriver);
                    WebPageUtility.naviGateToUrl(Resource_TestData.KazakhstanPgUrl + code.ToString(), Env.strBrowserTitle, "");

                    if (WebPageUtility.IsElementPresent(By.Id(validField)))
                    {
                        BP.RadioButtonForPostAndEmailOption();

                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_Kazakhstan"].ToString(), oHashTable["HouseNumber_Line_Kazakhstan"].ToString(), oHashTable["PostalCode_Kazakhstan"].ToString(), oHashTable["MobilePhone_Line_Kazakhstan"].ToString(), oHashTable["City_Kazakhstan"].ToString(), "Алматы");

                        BP.SubmitPage();
                        BP.verifytheTestRedirectedToThankYouPage();
                        Assert.IsTrue(true, "");
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "Brochure Scenario", ex.Message);
                Assert.Fail("Known Fail");

                Reporter.EndTest();
            }

        }

        [TestMethod, TestCategory("Kazakhstan smoke test")]
        public void Kazakhstan_BrochureTestWithEmail_PG_Allforms_PostDelivery()
        {
            try
            {


                Console.WriteLine("Brochure page");
                Reporter.startTest("Brouchure fields Verification", "Creating Brouchure scenario");
                Reporter.AssignCategory("Brochurepage", "ProgramGuide");
                Reporter.strCurrentTestID = "TS001";
                //*******************************************************************************************************
                string dataFileToRefer = null; string dataSheetToRefer = null; string RunFlag = null;
                Helper.getTestDataDetails("'TS001'", out dataFileToRefer, out dataSheetToRefer, out RunFlag);
                foreach (ProductCode code in Enum.GetValues(typeof(ProductCode)))
                {
                    BrochurePage BP = new BrochurePage(TestDriver.webDriver);
                    WebPageUtility.naviGateToUrl(Resource_TestData.KazakhstanPgUrl + code.ToString(), Env.strBrowserTitle, "");

                    if (WebPageUtility.IsElementPresent(By.Id(validField)))
                    {

                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_Kazakhstan"].ToString(), oHashTable["HouseNumber_Line_Kazakhstan"].ToString(), oHashTable["PostalCode_Kazakhstan"].ToString(), oHashTable["MobilePhone_Line_Kazakhstan"].ToString(), oHashTable["City_Kazakhstan"].ToString(), "Алматы");
                        BP.SubmitPage();
                        BP.verifytheTestRedirectedToThankYouPage();
                        Assert.IsTrue(true, "");
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "Brochure Scenario", ex.Message);
                Assert.Fail("Known Fail");

                Reporter.EndTest();
            }

        }




        [TestMethod, TestCategory("Brazil smoke test")]
        public void Brazil_BrochureTestWithEmail_PG_Allforms()
        {
            try
            {
                Console.WriteLine("Brochure page");
                Reporter.startTest("Brouchure fields Verification", "Creating Brouchure scenario");
                Reporter.AssignCategory("Brochurepage", "ProgramGuide");
                Reporter.strCurrentTestID = "TS001";
                //*******************************************************************************************************
                string dataFileToRefer = null; string dataSheetToRefer = null; string RunFlag = null;
                Helper.getTestDataDetails("'TS001'", out dataFileToRefer, out dataSheetToRefer, out RunFlag);
                foreach (ProductCode code in Enum.GetValues(typeof(ProductCode)))
                {
                    BrochurePage BP = new BrochurePage(TestDriver.webDriver);
                    WebPageUtility.naviGateToUrl(Resource_TestData.BrazilPgUrl + code.ToString(), Env.strBrowserTitle, "");

                    if (WebPageUtility.IsElementPresent(By.Id(validField)))
                    {
                        BP.RadioButtonForPostAndEmailOption();
                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_Brazil"].ToString(), oHashTable["HouseNumber_Line_Brazil"].ToString(), oHashTable["PostalCode_Brazil"].ToString(), oHashTable["MobilePhone_Line_Brazil"].ToString(), oHashTable["City_Brazil"].ToString(), "Mato Grosso do Sul");
                        BP.SubmitPage();
                        BP.verifytheTestRedirectedToThankYouPage();
                        Assert.IsTrue(true, "");
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "Brochure Scenario", ex.Message);
                Assert.Fail("Known Fail");

                Reporter.EndTest();
            }
        }


        [TestMethod, TestCategory("Brazil smoke test")]
        public void Brazil_BrochureTestWithEmail_PG_Allforms_PostDelivery()
        {
            try
            {


                Console.WriteLine("Brochure page");
                Reporter.startTest("Brouchure fields Verification", "Creating Brouchure scenario");
                Reporter.AssignCategory("Brochurepage", "ProgramGuide");
                Reporter.strCurrentTestID = "TS001";
                //*******************************************************************************************************
                string dataFileToRefer = null; string dataSheetToRefer = null; string RunFlag = null;
                Helper.getTestDataDetails("'TS001'", out dataFileToRefer, out dataSheetToRefer, out RunFlag);
                foreach (ProductCode code in Enum.GetValues(typeof(ProductCode)))
                {
                    BrochurePage BP = new BrochurePage(TestDriver.webDriver);
                    WebPageUtility.naviGateToUrl(Resource_TestData.BrazilPgUrl + code.ToString(), Env.strBrowserTitle, "");

                    if (WebPageUtility.IsElementPresent(By.Id(validField)))
                    {
                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_Brazil"].ToString(), oHashTable["HouseNumber_Line_Brazil"].ToString(), oHashTable["PostalCode_Brazil"].ToString(), oHashTable["MobilePhone_Line_Brazil"].ToString(), oHashTable["City_Brazil"].ToString(), "Mato Grosso do Sul");
                        BP.SubmitPage();
                        BP.verifytheTestRedirectedToThankYouPage();
                        Assert.IsTrue(true, "");
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "Brochure Scenario", ex.Message);
                Assert.Fail("Known Fail");

                Reporter.EndTest();
            }

        }

        [TestMethod,TestCategory("Markets- German")]
        public void Luxembourg_BrochureTestWithEmail_PG_Allforms()
        {
            try
            {

                Console.WriteLine("Brochure page");
                Reporter.startTest("Brouchure fields Verification", "Creating Brouchure scenario");
                Reporter.AssignCategory("Brochurepage", "ProgramGuide");
                Reporter.strCurrentTestID = "TS001";
                //*******************************************************************************************************
                string dataFileToRefer = null; string dataSheetToRefer = null; string RunFlag = null;
                Helper.getTestDataDetails("'TS001'", out dataFileToRefer, out dataSheetToRefer, out RunFlag);
                foreach (ProductCode code in Enum.GetValues(typeof(ProductCode)))
                {
                    BrochurePage BP = new BrochurePage(TestDriver.webDriver);
                    WebPageUtility.naviGateToUrl(Resource_TestData.LuxembourgPgUrl + code.ToString(), Env.strBrowserTitle, "");


                    if (WebPageUtility.IsElementPresent(By.Id(validField)))
                    {
                        BP.RadioButtonForPostAndEmailOption();

                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_Luxembourg"].ToString(), oHashTable["HouseNumber_Line_Luxembourg"].ToString(), oHashTable["PostalCode_Luxembourg"].ToString(), oHashTable["MobilePhone_Line_Luxembourg"].ToString(), oHashTable["City_Luxembourg"].ToString(), "");
                        BP.SubmitPage();
                        BP.verifytheTestRedirectedToThankYouPage();
                        Assert.IsTrue(true, "");
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "Brochure Scenario", ex.Message);
                Assert.Fail("Known Fail");

                Reporter.EndTest();
            }
        }

        [TestMethod, TestCategory("Markets- German")]
        public void Luxembourg_BrochureTestWithEmail_PG_Allforms_PostDelivery()
        {
            try
            {


                Console.WriteLine("Brochure page");
                Reporter.startTest("Brouchure fields Verification", "Creating Brouchure scenario");
                Reporter.AssignCategory("Brochurepage", "ProgramGuide");
                Reporter.strCurrentTestID = "TS001";
                //*******************************************************************************************************
                string dataFileToRefer = null; string dataSheetToRefer = null; string RunFlag = null;
                Helper.getTestDataDetails("'TS001'", out dataFileToRefer, out dataSheetToRefer, out RunFlag);
                foreach (ProductCode code in Enum.GetValues(typeof(ProductCode)))
                {
                    BrochurePage BP = new BrochurePage(TestDriver.webDriver);
                    WebPageUtility.naviGateToUrl(Resource_TestData.LuxembourgPgUrl + code.ToString(), Env.strBrowserTitle, "");

                    if (WebPageUtility.IsElementPresent(By.Id(validField)))
                    {

                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_Luxembourg"].ToString(), oHashTable["HouseNumber_Line_Luxembourg"].ToString(), oHashTable["PostalCode_Luxembourg"].ToString(), oHashTable["MobilePhone_Line_Luxembourg"].ToString(), oHashTable["City_Luxembourg"].ToString(), "");
                        BP.SubmitPage();
                        BP.verifytheTestRedirectedToThankYouPage();
                        Assert.IsTrue(true, "");
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "Brochure Scenario", ex.Message);
                Assert.Fail("Known Fail");

                Reporter.EndTest();
            }

        }
    }
}



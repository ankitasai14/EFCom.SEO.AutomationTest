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
            Saudi Arabia (English)
            Netherlands
            Vietnam
            Argentina
            United States (direct)
            United Arab Emirates (English)
            United Kingdom (direct)    
            Uruguay
            Belgium (French)
            Belgium (Dutch)
            Tunesia
            Austria
*/

    public class ListOfMarkets_04 : TestDriver
    {
        public Dictionary<string, string> oHashTable;
        enum ProductCode
        {
            LT, ILC, ILS, ILSP, HSY, IA, JU, AP, GA

        };

        [TestMethod,TestCategory("Markets- Chinese & Dutch")]
        public void NetherlandsBrochureTestWithEmail_PG_Allforms()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.NetherlandsPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.RadioButtonForPostAndEmailOption();
                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);

                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_Netherland"].ToString(), oHashTable["HouseNumber_Line_Netherland"].ToString(), oHashTable["PostalCode_Netherland"].ToString(), oHashTable["MobilePhone_Line_Netherland"].ToString(), "", "");

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
        public void NetherlandsBrochureTestWithEmail_PG_Allforms_PostDelivery()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.NetherlandsPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_Netherland"].ToString(), oHashTable["HouseNumber_Line_Netherland"].ToString(), oHashTable["PostalCode_Netherland"].ToString(), oHashTable["MobilePhone_Line_Netherland"].ToString(), "", "");

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


        [TestMethod, TestCategory("SaudiArabia_English smoke test")]
        public void SaudiArabia_English_BrochureTestWithEmail_PG_Allforms()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.SaudiArabiaEnglishPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {

                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_SaudiArabia_English"].ToString(), oHashTable["HouseNumber_Line_Netherland"].ToString(), oHashTable["PostalCode_Netherland"].ToString(), oHashTable["MobilePhone_Line_Netherland"].ToString(), "", "");

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



        [TestMethod, TestCategory("SaudiArabia_English smoke test")]
        public void SaudiArabia_English_BrochureTestWithEmail_PG_Allforms_PostDelivery()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.SaudiArabiaEnglishPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_SaudiArabia_English"].ToString(), oHashTable["HouseNumber_Line_SaudiArabia_English"].ToString(), oHashTable["PostalCode_SaudiArabia_English"].ToString(), oHashTable["MobilePhone_Line_SaudiArabia_English"].ToString(), "", "");

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


        [TestMethod, TestCategory("Vietnam smoke test")]
        public void VietnamBrochureTestWithEmail_PG_Allforms()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.VietnamPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.RadioButtonForPostAndEmailOption();
                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_Vietnam"].ToString(), oHashTable["HouseNumber_Line_Vietnam"].ToString(), oHashTable["PostalCode_Vietnam"].ToString(), oHashTable["MobilePhone_Line_Vietnam"].ToString(), "", "");

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



        [TestMethod, TestCategory("Vietnam smoke test")]
        public void VietnamBrochureTestWithEmail_PG_Allforms_PostDelivery()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.VietnamPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {

                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_Vietnam"].ToString(), oHashTable["HouseNumber_Line_Vietnam"].ToString(), oHashTable["PostalCode_Vietnam"].ToString(), oHashTable["MobilePhone_Line_Vietnam"].ToString(), oHashTable["City_Vietnam"].ToString(), "");

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

        [TestMethod, TestCategory("Argentina smoke test"), TestCategory("Markets- Spanish")]
        public void ArgentinaBrochureTestWithEmail_PG_Allforms()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.ArgentinaPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.RadioButtonForPostAndEmailOption();
                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_Argentina"].ToString(), oHashTable["HouseNumber_Line_Argentina"].ToString(), oHashTable["PostalCode_Argentina"].ToString(), oHashTable["MobilePhone_Line_Argentina"].ToString(), oHashTable["City_Argentina"].ToString(), "Buenos Aires");

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

        [TestMethod, TestCategory("Argentina smoke test"), TestCategory("Markets- Spanish")]
        public void ArgentinaBrochureTestWithEmail_PG_Allforms_PostDelivery()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.ArgentinaPgUrl+code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_Argentina"].ToString(), oHashTable["HouseNumber_Line_Argentina"].ToString(), oHashTable["PostalCode_Argentina"].ToString(), oHashTable["MobilePhone_Line_Argentina"].ToString(), oHashTable["City_Argentina"].ToString(), "Buenos Aires");

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
        public void UnitedState_ENBrochureTestWithEmail_PG_Allforms()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.UnitedStatesPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.RadioButtonForPostAndEmailOption();

                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_Common"].ToString(), oHashTable["HouseNumber_Line_Common"].ToString(), oHashTable["PostalCode_Common"].ToString(), oHashTable["MobilePhone_Line_Common"].ToString(), oHashTable["City_Common"].ToString(), "Massachusetts");

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
        public void UnitedState_EN_ENBrochureTestWithEmail_PG_Allforms_PostDelivery()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.UnitedStatesPgUrl + code.ToString(), Env.strBrowserTitle, "");

                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_Common"].ToString(), oHashTable["HouseNumber_Line_Common"].ToString(), oHashTable["PostalCode_Common"].ToString(), oHashTable["MobilePhone_Line_Common"].ToString(), oHashTable["City_Common"].ToString(), "Massachusetts");

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
        // one form
        [TestMethod, TestCategory("United Arab Emirates_EN smoke test")]
        public void UAE_EN_ENBrochureTestWithEmail_PG_Allforms()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.UnitedArabEmiratesPgUrl + code.ToString(), Env.strBrowserTitle, "");

                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.BrochureForOneSection(oHashTable["AddressLine1_Line_SaudiArabia_English"].ToString(), oHashTable["HouseNumber_Line_SaudiArabia_English"].ToString(), oHashTable["PostalCode_SaudiArabia_English"].ToString(), oHashTable["MobilePhone_Line_SaudiArabia_English"].ToString(), oHashTable["City_SaudiArabia_English"].ToString(), "", "India", "India");

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
        public void UK_EN_ENBrochureTestWithEmail_PG_Allforms()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.UnitedKingdomPgUrl + code.ToString(), Env.strBrowserTitle, "");

                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.RadioButtonForPostAndEmailOption();

                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
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


        [TestMethod, TestCategory("Markets- English")]
        public void UK_EN_ENBrochureTestWithEmail_PG_Allforms_PostDelivery()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.UnitedKingdomPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
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


        [TestMethod, TestCategory("Uruguay smoke test") , TestCategory("Markets- Spanish")]
        public void Uruguay_BrochureTestWithEmail_PG_Allforms()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.UruguayPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.RadioButtonForPostAndEmailOption();
                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.BrochureToEmail(oHashTable["AddressLine1_Line_Uruguay"].ToString(), oHashTable["HouseNumber_Line_Uruguay"].ToString(), oHashTable["PostalCode_Uruguay"].ToString(), oHashTable["MobilePhone_Line_Uruguay"].ToString(), oHashTable["City_Uruguay"].ToString(), "Canelones");

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


        [TestMethod, TestCategory("Uruguay smoke test"), TestCategory("Markets- Spanish")]
        public void Uruguay_BrochureTestWithEmail_PG_Allforms_PostDelivery()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.UruguayPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")) || WebPageUtility.IsElementPresent(By.Id("LastName")))
                    {
                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_Uruguay"].ToString(), oHashTable["HouseNumber_Line_Uruguay"].ToString(), oHashTable["PostalCode_Uruguay"].ToString(), oHashTable["MobilePhone_Line_Uruguay"].ToString(), oHashTable["City_Uruguay"].ToString(), "Canelones");

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

        [TestMethod,TestCategory("Markets- Chinese & Dutch")]
        public void BelgiumDutch_BrochureTestWithEmail_PG_Allforms()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.BelgiumDutchPgUrl + code.ToString(), Env.strBrowserTitle, "");

                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.RadioButtonForPostAndEmailOption();

                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_BelgiumDu"].ToString(), oHashTable["HouseNumber_Line_BelgiumDu"].ToString(), oHashTable["PostalCode_BelgiumDu"].ToString(), oHashTable["MobilePhone_Line_BelgiumDu"].ToString(), oHashTable["City_BelgiumDu"].ToString(), "");

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

        [TestMethod,TestCategory("Markets- Chinese & Dutch")]
        public void BelgiumDutch_BrochureTestWithEmail_PG_Allforms_PostDelivery()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.BelgiumDutchPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_BelgiumDu"].ToString(), oHashTable["HouseNumber_Line_BelgiumDu"].ToString(), oHashTable["PostalCode_BelgiumDu"].ToString(), oHashTable["MobilePhone_Line_BelgiumDu"].ToString(), oHashTable["City_BelgiumDu"].ToString(), "");

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

        [TestMethod, TestCategory("BelgiumFrench smoke test")]
        public void BelgiumFrench_BrochureTestWithEmail_PG_Allforms()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.BelgiumFrenchPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_BelgiumFr"].ToString(), oHashTable["HouseNumber_Line_BelgiumFr"].ToString(), oHashTable["PostalCode_BelgiumFr"].ToString(), oHashTable["MobilePhone_Line_BelgiumFr"].ToString(), oHashTable["City_BelgiumFr"].ToString(), "");

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

        [TestMethod, TestCategory("BelgiumFrench smoke test")]
        public void BelgiumFrench_BrochureTestWithEmail_PG_Allforms_PostDelivery()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.BelgiumFrenchPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.RadioButtonForPostAndDeliveryOption();

                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_BelgiumFr"].ToString(), oHashTable["HouseNumber_Line_BelgiumFr"].ToString(), oHashTable["PostalCode_BelgiumFr"].ToString(), oHashTable["MobilePhone_Line_BelgiumFr"].ToString(), oHashTable["City_BelgiumFr"].ToString(), "");

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

        // one section - Email
        [TestMethod, TestCategory("Markets- French")]
        public void Tunesia_BrochureTestWithEmail_PG_Allforms()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.TunesiaPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {

                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.BrochureForOneSection(oHashTable["AddressLine1_Line_Tunesia"].ToString(), oHashTable["HouseNumber_Line_Tunesia"].ToString(), oHashTable["PostalCode_Tunesia"].ToString(), oHashTable["MobilePhone_Line_Tunesia"].ToString(), oHashTable["City_Tunesia"].ToString(), "", "","");

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
        public void AustriaBrochureTestWithEmail_PG_Allforms()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.AustriaPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.RadioButtonForPostAndEmailOption();

                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_Austria"].ToString(), oHashTable["HouseNumber_Line_Austria"].ToString(), oHashTable["PostalCode_Austria"].ToString(), oHashTable["MobilePhone_Line_Austria"].ToString(), oHashTable["City_Austria"].ToString(), "");

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
        public void Austria_BrochureTestWithEmail_PG_Allforms_PostDelivery()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.AustriaPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.RadioButtonForPostAndDeliveryOption();

                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_Austria"].ToString(), oHashTable["HouseNumber_Line_Austria"].ToString(), oHashTable["PostalCode_Austria"].ToString(), oHashTable["MobilePhone_Line_Austria"].ToString(), oHashTable["City_Austria"].ToString(), "");

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







using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rentals._02_Utility_Tier;
using Rentals.Resources;
using Rentals._03_Application_Tier.PageObjects;
using Rentals._01_Configuration_Tier.EnvironmentFiles;
using System.Collections;
using System.Collections.Generic;
using OpenQA.Selenium;

namespace Rentals._03_Application_Tier.ApplicationTests.Functional_Tests
{
    [TestClass]
    /*
        Algeria (Arabic)
        Algeria (French)
        Ecuador
        Estonia
        Thailand
        Canada (French)
        Finland (Finnish)
        Spain
        Venezuela
        Panama
        Peru
        Colombia
        China

*/
    public class ListOfMarkets_03 :TestDriver
    {
        public Dictionary<string, string> oHashTable;
        enum ProductCode
        {
            LSJ, ILC, ILS, LY, BC, HSY, IA, ETOWN, AP
        };

        [TestMethod, TestCategory("AlgeriaAr Smoke Test")]
        public void AlgeriaAr_BrochureTestWithEmail_PG_AllForms()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.AlgeriaArabicPgUrl + code, Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.RadioButtonForPostAndEmailOption();

                        BP.VerifyBrochureCommonFields();
                        Algeria_Arabic markets = new Algeria_Arabic(TestDriver.webDriver);
                        markets.Algeria_Arabic_MailTest();

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


        [TestMethod, TestCategory("AlgeriaAr Smoke Test")]
        public void AlgeriaAr_BrochureTestWithEmail_PG_AllForms_PostDelivery()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.AlgeriaArabicPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.VerifyBrochureCommonFields();
                        MX markets = new MX(TestDriver.webDriver);
                        markets.SwitzerlandItalian_MailTest();
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



        [TestMethod, TestCategory("AlgeriaFr Smoke Test")]
        public void AlgeriaFr_BrochureTestWithEmail_PG_AllForms()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.AlgeriaFrenchPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.RadioButtonForPostAndEmailOption();

                        BP.VerifyBrochureCommonFields();
                        Algeria_French markets = new Algeria_French(TestDriver.webDriver);
                        markets.Algeria_French_MailTest();

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


        [TestMethod, TestCategory("AlgeriaFr Smoke Test")]
        public void AlgeriaFr_BrochureTestWithEmail_PG_AllForms_PostDelivery()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.AlgeriaFrenchPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.VerifyBrochureCommonFields();
                        MX markets = new MX(TestDriver.webDriver);
                        markets.SwitzerlandItalian_MailTest();
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

        [TestMethod, TestCategory("Ecuador Smoke Test"), TestCategory("Markets- Spanish")]
        public void Ecuador_BrochureTestWithEmail_PG_AllForms()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.EcuadorPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.RadioButtonForPostAndEmailOption();

                        BP.VerifyBrochureCommonFields();
                        Ecuador markets = new Ecuador(TestDriver.webDriver);
                        markets.Ecuador_MailTest();

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


        [TestMethod, TestCategory("Ecuador Smoke Test"), TestCategory("Markets- Spanish")]
        public void Ecuador_BrochureTestWithEmail_PG_AllForms_PostDelivery()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.EcuadorPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.VerifyBrochureCommonFields();
                        Ecuador markets = new Ecuador(TestDriver.webDriver);
                        markets.Ecuador_MailTest();
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

        [TestMethod, TestCategory("Estonia Smoke Test"), TestCategory("Markets- Spanish")]
        public void Estonia_BrochureTestWithEmail_PG_AllForms()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.EstoniaPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.BrochureForOneSection(oHashTable["AddressLine1_Line_Estonia"].ToString(), oHashTable["HouseNumber_Line_Estonia"].ToString(), oHashTable["PostalCode_Estonia"].ToString(), oHashTable["MobilePhone_Line_Estonia"].ToString(), oHashTable["City_Estonia"].ToString(), "", "Argentina", "");

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


        [TestMethod, TestCategory("Estonia Smoke Test")]
        public void Estonia_BrochureTestWithEmail_PG_AllForms_PostDelivery()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.EstoniaPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_Estonia"].ToString(), oHashTable["HouseNumber_Line_Estonia"].ToString(), oHashTable["PostalCode_Estonia"].ToString(), oHashTable["MobilePhone_Line_Estonia"].ToString(), oHashTable["City_Estonia"].ToString(), "");
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

        [TestMethod, TestCategory("Mexico Smoke Test")]
        public void Thailand_BrochureTestWithEmail_PG_AllForms()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.ThaiPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.RadioButtonForPostAndEmailOption();

                        BP.VerifyBrochureCommonFields();
                        TH markets = new TH(TestDriver.webDriver);
                        markets.Thailand_MailTest();

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


        [TestMethod, TestCategory("Mexico Smoke Test")]
        public void Thailand_BrochureTestWithEmail_PG_AllForms_PostDelivery()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.ThaiPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.VerifyBrochureCommonFields();
                        TH markets = new TH(TestDriver.webDriver);
                        markets.Thailand_MailTest();
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
        public void CanadaFr_BrochureTestWithEmail_PG_AllForms()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.CanadaFrPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.RadioButtonForPostAndEmailOption();

                        BP.VerifyBrochureCommonFields();
                        CanadaFR markets = new CanadaFR(TestDriver.webDriver);
                        markets.CanadaFR_MailTest();

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
        public void CanadaFr_BrochureTestWithEmail_PG_AllForms_PostDelivery()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.CanadaFrPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.VerifyBrochureCommonFields();
                        CanadaFR markets = new CanadaFR(TestDriver.webDriver);
                        markets.CanadaFR_MailTest();

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

        [TestMethod, TestCategory("Finland Smoke Test")]
        public void Finland_BrochureTestWithEmail_PG_AllForms()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.FinlandPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.RadioButtonForPostAndEmailOption();

                        BP.VerifyBrochureCommonFields();
                        Finland markets = new Finland(TestDriver.webDriver);
                        markets.Finland_MailTest();

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


        [TestMethod, TestCategory("Finland Smoke Test")]
        public void Finland_BrochureTestWithEmail_PG_AllForms_PostDelivery()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.FinlandPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.VerifyBrochureCommonFields();
                        Finland markets = new Finland(TestDriver.webDriver);
                        markets.Finland_MailTest();
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


        [TestMethod, TestCategory("Spain Smoke Test"), TestCategory("Markets- Spanish")]
        public void Spain_BrochureTestWithEmail_PG_AllForms()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.SpainPgUrl + code, Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_Peru"].ToString(), oHashTable["HouseNumber_Line_Peru"].ToString(), oHashTable["PostalCode_Peru"].ToString(), oHashTable["MobilePhone_Line_Peru"].ToString(), oHashTable["City_Peru"].ToString(),"India");

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


        [TestMethod, TestCategory("Spain Smoke Test"), TestCategory("Markets- Spanish")]
        public void Spain_BrochureTestWithEmail_PG_AllForms_PostDelivery()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.SpainPgUrl + code.ToString(), Env.strBrowserTitle, "");
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


        [TestMethod, TestCategory("Venezuela Smoke Test"), TestCategory("Markets- Spanish")]
        public void Venezuela_BrochureTestWithEmail_PG_AllForms()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.VenezuelaPgUrl + code, Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.RadioButtonForPostAndEmailOption();

                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_Venezuela"].ToString(), oHashTable["HouseNumber_Line_Venezuela"].ToString(), oHashTable["PostalCode_Venezuela"].ToString(), oHashTable["MobilePhone_Line_Venezuela"].ToString(), oHashTable["City_Venezuela"].ToString(), "Zulia");

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


        [TestMethod, TestCategory("Venezuela Smoke Test"), TestCategory("Markets- Spanish")]
        public void Venezuela_BrochureTestWithEmail_PG_AllForms_PostDelivery()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.VenezuelaPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                     
                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);


                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_Venezuela"].ToString(), oHashTable["HouseNumber_Line_Venezuela"].ToString(), oHashTable["PostalCode_Venezuela"].ToString(), oHashTable["MobilePhone_Line_Venezuela"].ToString(), oHashTable["City_Venezuela"].ToString(), "Zulia");

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


        [TestMethod, TestCategory("Panama Smoke Test"), TestCategory("Markets- Spanish")]
        public void Panama_BrochureTestWithEmail_PG_AllForms()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.PanamaPgUrl + code, Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_Panama"].ToString(), oHashTable["HouseNumber_Line_Panama"].ToString(), oHashTable["PostalCode_Panama"].ToString(), oHashTable["MobilePhone_Line_Panama"].ToString(), oHashTable["City_Panama"].ToString(), "Panamá");

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


        [TestMethod, TestCategory("Panama Smoke Test"), TestCategory("Markets- Spanish")]
        public void Panama_BrochureTestWithEmail_PG_AllForms_PostDelivery()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.PanamaPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.RadioButtonForPostAndDeliveryOption();

                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);

                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_Panama"].ToString(), oHashTable["HouseNumber_Line_Panama"].ToString(), oHashTable["PostalCode_Panama"].ToString(), oHashTable["MobilePhone_Line_Panama"].ToString(), oHashTable["City_Panama"].ToString(), "Panamá");

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


        [TestMethod, TestCategory("Peru Smoke Test"), TestCategory("Markets- Spanish")]
        public void Peru_BrochureTestWithEmail_PG_AllForms()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.PeruPgUrl + code, Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_Peru"].ToString(), oHashTable["HouseNumber_Line_Peru"].ToString(), oHashTable["PostalCode_Peru"].ToString(), oHashTable["MobilePhone_Line_Peru"].ToString(), oHashTable["City_Peru"].ToString(), "Lima");

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


        [TestMethod, TestCategory("Peru Smoke Test"), TestCategory("Markets- Spanish")]
        public void Peru_BrochureTestWithEmail_PG_AllForms_PostDelivery()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.PeruPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.RadioButtonForPostAndDeliveryOption();

                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);

                        markets.Brochure(oHashTable["AddressLine1_Line_Peru"].ToString(), oHashTable["HouseNumber_Line_Peru"].ToString(), oHashTable["PostalCode_Peru"].ToString(), oHashTable["MobilePhone_Line_Peru"].ToString(), oHashTable["City_Peru"].ToString(), "Lima");

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


        [TestMethod, TestCategory("Colombia Smoke Test"), TestCategory("Markets- Spanish")]
        public void Colombia_BrochureTestWithEmail_PG_AllForms()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.ColombiaPgUrl + code, Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.BrochureToEmail(oHashTable["AddressLine1_Line_Colombia"].ToString(), oHashTable["HouseNumber_Line_Colombia"].ToString(), oHashTable["PostalCode_Colombia"].ToString(), oHashTable["MobilePhone_Line_Colombia"].ToString(), oHashTable["City_Colombia"].ToString(), "Atlantico");

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


        [TestMethod, TestCategory("Colombia Smoke Test"), TestCategory("Markets- Spanish")]
        public void Colombia_BrochureTestWithEmail_PG_AllForms_PostDelivery()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.ColombiaPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.RadioButtonForPostAndDeliveryOption();

                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_Colombia"].ToString(), oHashTable["HouseNumber_Line_Colombia"].ToString(), oHashTable["PostalCode_Colombia"].ToString(), oHashTable["MobilePhone_Line_Colombia"].ToString(), oHashTable["City_Colombia"].ToString(), "Atlantico");

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
        public void China_BrochureTestWithEmail_PG_AllForms_PostDelivery()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.ChinaPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.RadioButtonForPostAndDeliveryOption();

                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_China"].ToString(), oHashTable["HouseNumber_Line_China"].ToString(), oHashTable["PostalCode_China"].ToString(), oHashTable["MobilePhone_Line_China"].ToString(), oHashTable["City_China"].ToString(), "上海");

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

        [TestMethod, TestCategory("China Smoke Test"), TestCategory("Markets- Chinese & Dutch")]
        public void China_BrochureTestWithEmail_PG_AllForms()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.ChinaPgUrl + code, Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_China"].ToString(), oHashTable["HouseNumber_Line_China"].ToString(), oHashTable["PostalCode_China"].ToString(), oHashTable["MobilePhone_Line_China"].ToString(), oHashTable["City_China"].ToString(), "上海");

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





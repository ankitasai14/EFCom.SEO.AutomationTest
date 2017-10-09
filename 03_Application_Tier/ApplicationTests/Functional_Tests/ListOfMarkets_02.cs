using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rentals._02_Utility_Tier;
using Rentals.Resources;
using Rentals._03_Application_Tier.PageObjects;
using Rentals._01_Configuration_Tier.EnvironmentFiles;
using System.Collections.Generic;

namespace Rentals._03_Application_Tier.ApplicationTests.Functional_Tests
{
    [TestClass]

    /*Latvia
    Libya
    Macau
    Chile
    Colombia
    Norway
    New Zealand
    Panama
    Peru
    Poland
    Portugal
    Russia
    Saudi Arabia (Arabic)
    Sweden
    Singapore
    Slovenija
    Slovakia

     */

    public class ListOfMarkets_02 : TestDriver
    {
        public Dictionary<string, string> oHashTable;
        enum ProductCode1
        {
            hsy,
            ilc,
            ils,
           
        };

        enum ProductCode2
        {
           
            lt,
            ly,
           
        };


        [TestMethod, TestCategory("Markets- English")]
        public void NewZealand_ENBrochureTestWithEmail_PG_Allforms_1()
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
                foreach (ProductCode1 code in Enum.GetValues(typeof(ProductCode1)))
                {
                    BrochurePage BP = new BrochurePage(TestDriver.webDriver);
                    WebPageUtility.naviGateToUrl(Resource_TestData.NewZealandPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    BP.RadioButtonForPostAndEmailOption();

                    BP.VerifyBrochureCommonFields();
                    Common_Method markets = new Common_Method(TestDriver.webDriver);
                    oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                    markets.Brochure(oHashTable["AddressLine1_Line_Newzealand"].ToString(), oHashTable["HouseNumber_Line_Newzealand"].ToString(), oHashTable["PostalCode_Newzealand"].ToString(), oHashTable["MobilePhone_Line_Newzealand"].ToString(), oHashTable["City_Newzealand"].ToString(), "");

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

        [TestMethod, TestCategory("Markets- English")]
        public void NewZealand_ENBrochureTestWithEmail_PG_Allforms_2()
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
                foreach (ProductCode2 code in Enum.GetValues(typeof(ProductCode2)))
                {
                    BrochurePage BP = new BrochurePage(TestDriver.webDriver);
                    WebPageUtility.naviGateToUrl(Resource_TestData.NewZealandPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    BP.RadioButtonForPostAndEmailOption();

                    BP.VerifyBrochureCommonFields();
                    Common_Method markets = new Common_Method(TestDriver.webDriver);
                    oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                    markets.Brochure(oHashTable["AddressLine1_Line_Newzealand"].ToString(), oHashTable["HouseNumber_Line_Newzealand"].ToString(), oHashTable["PostalCode_Newzealand"].ToString(), oHashTable["MobilePhone_Line_Newzealand"].ToString(), oHashTable["City_Newzealand"].ToString(), "");

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


        [TestMethod, TestCategory("Markets- English")]
        public void NewZealand_ENBrochureTestWithEmail_PG_Allforms_PostDelivery_1()
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
                foreach (ProductCode2 code in Enum.GetValues(typeof(ProductCode2)))
                {
                    BrochurePage BP = new BrochurePage(TestDriver.webDriver);
                    WebPageUtility.naviGateToUrl(Resource_TestData.NewZealandPgUrl + code.ToString(), Env.strBrowserTitle, "");            

                    BP.VerifyBrochureCommonFields();
                    Common_Method markets = new Common_Method(TestDriver.webDriver);
                    oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                    markets.Brochure(oHashTable["AddressLine1_Line_Newzealand"].ToString(), oHashTable["HouseNumber_Line_Newzealand"].ToString(), oHashTable["PostalCode_Newzealand"].ToString(), oHashTable["MobilePhone_Line_Newzealand"].ToString(), oHashTable["City_Newzealand"].ToString(), "");

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

        [TestMethod, TestCategory("NewZealand_EN smoke test")]
        public void NewZealand_ENBrochureTestWithEmail_PG_Allforms_PostDelivery_2()
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
                foreach (ProductCode1 code in Enum.GetValues(typeof(ProductCode1)))
                {
                    BrochurePage BP = new BrochurePage(TestDriver.webDriver);
                    WebPageUtility.naviGateToUrl(Resource_TestData.NewZealandPgUrl + code.ToString(), Env.strBrowserTitle, "");

                    BP.VerifyBrochureCommonFields();
                    Common_Method markets = new Common_Method(TestDriver.webDriver);
                    oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                    markets.Brochure(oHashTable["AddressLine1_Line_Newzealand"].ToString(), oHashTable["HouseNumber_Line_Newzealand"].ToString(), oHashTable["PostalCode_Newzealand"].ToString(), oHashTable["MobilePhone_Line_Newzealand"].ToString(), oHashTable["City_Newzealand"].ToString(), "");

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

    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rentals._02_Utility_Tier;
using Rentals._03_Application_Tier.PageObjects;
using Rentals.Resources;
using Rentals._01_Configuration_Tier.EnvironmentFiles;
using NUnit.Framework;
using System.Collections.Generic;
using OpenQA.Selenium;

namespace Rentals._03_Application_Tier.ApplicationTests.Functional_Tests
{
    [TestClass]
    public class Market_Switzerland_French__Test : TestDriver
    {
        enum ProductCode
        {
            hsy,
            ilc,
            ils,
            lt,
            ly,
            lsp
        };
        public Dictionary<string, string> oHashTable;

        [TestMethod, TestCategory("Markets- French")]
        public void SwitzerlandFrenchBrochureTestWithEmail_PG_AllForms()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.SwitzerlandFrenchPgUrl + code.ToString(), Env.strBrowserTitle, "");

                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.RadioButtonForPostAndEmailOption();

                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.BrochureToEmail(oHashTable["AddressLine1_Line_SwissCH"].ToString(), oHashTable["HouseNumber_Line_SwissCH"].ToString(), oHashTable["PostalCode_SwissCH"].ToString(), oHashTable["MobilePhone_Line_SwissCH"].ToString(), oHashTable["City_SwissCH"].ToString(), "");

                        BP.OfficePreferred();
                        BP.SubmitPage();
                        BP.verifytheTestRedirectedToThankYouPage();
                        Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(true, "");
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
                NUnit.Framework.Assert.Fail("Known Fail");

                Reporter.EndTest();
            }

        }

        [TestMethod, TestCategory("Markets- French")]
        public void SwitzerlandFrenchBrochureTestWithEmail_PG_AllForms_PostDelivery()
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
                    WebPageUtility.naviGateToUrl(Resource_TestData.SwitzerlandFrenchPgUrl + code.ToString(), Env.strBrowserTitle, "");

                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.RadioButtonForPostAndDeliveryOption();            
                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_SwissCH"].ToString(), oHashTable["HouseNumber_Line_SwissCH"].ToString(), oHashTable["PostalCode_SwissCH"].ToString(), oHashTable["MobilePhone_Line_SwissCH"].ToString(), oHashTable["City_SwissCH"].ToString(), "");


                        BP.SubmitPage();
                        BP.verifytheTestRedirectedToThankYouPage();
                        NUnit.Framework.Assert.IsTrue(true, "");
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
                NUnit.Framework.Assert.Fail("Known Fail");

                Reporter.EndTest();
            }

        }


    }
}


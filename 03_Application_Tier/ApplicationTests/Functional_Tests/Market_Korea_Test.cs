using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rentals._02_Utility_Tier;
using System.Collections.Generic;
using Rentals._03_Application_Tier.PageObjects;
using Rentals.Resources;
using Rentals._01_Configuration_Tier.EnvironmentFiles;
using OpenQA.Selenium;

namespace Rentals._03_Application_Tier.ApplicationTests.Functional_Tests
{
    [TestClass]
    public class Market_Korea_Test :TestDriver
    {

        public Dictionary<string, string> oHashTable;
        enum ProductCode
        {
            ILS, ILC, IT, 
        }


        //one section 
        [TestMethod, TestCategory(" Korea smoke test")]
        public void Korea_BrochureTestWithEmail_PG_Allforms()
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
                    var url = WebPageUtility.naviGateToUrl(Resource_TestData.KoreaPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    Console.WriteLine(url);

                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.RadioButtonForPostAndEmailOption();

                        BP.VerifyBrochureCommonFields();
                        Common_Method markets = new Common_Method(TestDriver.webDriver);
                        oHashTable = ExcelUtil.populatDictionaryFromExcel("Selenium_Values", "BrochureFields");
                        markets.Brochure(oHashTable["AddressLine1_Line_Kr"].ToString(), oHashTable["HouseNumber_Line_Kr"].ToString(), oHashTable["PostalCode_Kr"].ToString(), oHashTable["MobilePhone_Line_Kr"].ToString(), oHashTable["City_Kr"].ToString(), "");
                        markets.AcceptanceTerm();

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

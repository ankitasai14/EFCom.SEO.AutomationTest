using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rentals._02_Utility_Tier;
using Rentals._03_Application_Tier.PageObjects;
using Rentals._01_Configuration_Tier.EnvironmentFiles;
using Rentals.Resources;
using OpenQA.Selenium;

namespace Rentals._03_Application_Tier.ApplicationTests.Functional_Tests
{
    [TestClass]
    public class Market_Canada_Test :TestDriver
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

        [TestMethod, TestCategory("Markets- English")]
        public void CanadaBrochureTestWithEmail_PG_AllForms()
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

                    WebPageUtility.naviGateToUrl(Resource_TestData.CanadaPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.RadioButtonForPostAndEmailOption();
                        BP.VerifyBrochureCommonFields();
                        CA markets = new CA(TestDriver.webDriver);
                        markets.Canada_MailTest();

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
        public void CanadaBrochureTestWithEmail_PG_PostDelivery()
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

                    WebPageUtility.naviGateToUrl(Resource_TestData.CanadaPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    BP.VerifyBrochureCommonFields();
                    CA markets = new CA(TestDriver.webDriver);
                    markets.Canada_MailTest();

                    BP.OfficePreferred();
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

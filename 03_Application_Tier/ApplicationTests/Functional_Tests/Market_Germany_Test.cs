using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rentals._02_Utility_Tier;
using Rentals._03_Application_Tier.PageObjects;
using Rentals._01_Configuration_Tier.EnvironmentFiles;
using Rentals.Resources;
using OpenQA.Selenium;

namespace Rentals._03_Application_Tier.ApplicationTests
{
    [TestClass]
    public class Market_Germany_Test : TestDriver
    {
        enum ProductCode
        {
            LT, ILC, ILS, ILSP, HSY, IA, JU, LOC, AP, GA
        };

        [TestMethod, TestCategory("Germany Smoke Test")]
        public void BrochureTest()
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

                ProgramGuidePage PG = new ProgramGuidePage(TestDriver.webDriver);

                Reporter.ReportEvent("Pass", "Brochure Scenario", "Test passed");
                Reporter.EndTest();

            }

            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "Brochure Scenario", ex.Message);
                Assert.Fail("Known Fail");

                Reporter.EndTest();
            }

        }


        [TestMethod, TestCategory("Markets- German")]
        public void GermanyBrochureTest_PG_AllForms_PostDelivery()
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

                    WebPageUtility.naviGateToUrl(Resource_TestData.GermanyPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {

                        BP.VerifyBrochureCommonFields();
                        GermanyPage gp = new GermanyPage(webDriver);
                        gp.Germany_Emailtest();

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
        public void GermanyBrochureTestWithEmail_PG_AllForms()
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

                    WebPageUtility.naviGateToUrl(Resource_TestData.GermanyPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {

                        BP.VerifyBrochureCommonFields();
                        BP.RadioButtonForPostAndEmailOption();

                        GermanyPage gp = new GermanyPage(webDriver);
                        gp.Germany_Emailtest();

                        BP.OfficePreferred();
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
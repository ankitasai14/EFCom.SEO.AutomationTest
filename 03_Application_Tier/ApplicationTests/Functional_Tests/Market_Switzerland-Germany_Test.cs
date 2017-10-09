using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rentals._02_Utility_Tier;
using System.Configuration;
using Rentals._03_Application_Tier.PageObjects;
using Rentals.Resources;
using Rentals._01_Configuration_Tier.EnvironmentFiles;
using OpenQA.Selenium;

namespace Rentals._03_Application_Tier.ApplicationTests.Functional_Tests
{
    [TestClass]
    public class Market_Switzerland_Germany_Test : TestDriver
    {
        enum ProductCode
        {
           ILC, ILS, LY, HSY, IA, AP
        };
        

        /// <summary>
        /// test will run for each forms
        /// </summary>
        [TestMethod, TestCategory("Markets- German")]
        public void Switzerland_GermanyTestWithEmail_PG_Allforms()
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

                    WebPageUtility.naviGateToUrl(Resource_TestData.SwitzerlandGermanyPgUrl + code.ToString(), Env.strBrowserTitle, "");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.RadioButtonForPostAndEmailOption();
                        BP.VerifyBrochureCommonFields();
                        CS markets = new CS(TestDriver.webDriver);
                        markets.SwitzerlandFrench_MailTest();

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

        /// <summary>
        /// test will run for each forms
        /// </summary>
        [TestMethod, TestCategory("Markets- German")]
        public void Switzerland_GermanyTestWithEmail_PG_AllForms_PostDelivery()
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

                    WebPageUtility.naviGateToUrl(Resource_TestData.SwitzerlandGermanyPgUrl +code.ToString(), Env.strBrowserTitle,"");
                    if (WebPageUtility.IsElementPresent(By.Id("FirstName")))
                    {
                        BP.VerifyBrochureCommonFields();
                        CS markets = new CS(TestDriver.webDriver);
                        markets.SwitzerlandFrench_MailTest();

                        BP.OfficePreferred();
                        BP.SubmitPage();
                        BP.verifytheTestRedirectedToThankYouPage();
                    }
                    else
                    {
                        continue;
                    }

                }

                Assert.IsTrue(true, "");
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



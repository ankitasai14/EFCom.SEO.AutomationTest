﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rentals._02_Utility_Tier;
using Rentals._03_Application_Tier.PageObjects;
using Rentals._01_Configuration_Tier.EnvironmentFiles;
using System.Collections.Generic;
using OpenQA.Selenium;
using System.Configuration;
using Rentals.Resources;

namespace Rentals._03_Application_Tier.ApplicationTests.Functional_Tests
{
    [TestClass]
    public class Market_Denmark_Test :TestDriver
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

        SortedDictionary<string, string> list = new SortedDictionary<string, string>();

        /// <summary>
        /// test will run for each forms
        /// </summary>
        [TestMethod, TestCategory("Denmark Smoke Test")]
        public void DenmarkBrochureTestWithEmail_PG_Allforms()
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

                    WebPageUtility.naviGateToUrl(Resource_TestData.DenmarkPgUrl + code.ToString(), Env.strBrowserTitle, "");

                    BP.RadioButtonForPostAndEmailOption();
                    BP.VerifyBrochureCommonFields();
                    DK markets = new DK(TestDriver.webDriver);
                    markets.Denmark_MailTest();

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
    
        /// <summary>
        /// test will run for each forms
        /// </summary>
        [TestMethod, TestCategory("Denmark Smoke Test")]
        public void DenmarkBrochureTestWithEmail_PG_AllForms_PostDelivery()
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
                    
                   WebPageUtility.naviGateToUrl(Resource_TestData.DenmarkPgUrl +code.ToString(), Env.strBrowserTitle,"");
                   // webDriver.Url = ConfigurationManager.AppSettings["URL"];



                    BP.VerifyBrochureCommonFields();
                    DK markets = new DK(TestDriver.webDriver);
                    markets.Denmark_MailTest();

                    BP.OfficePreferred();
                    BP.SubmitPage();
                    BP.verifytheTestRedirectedToThankYouPage();

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

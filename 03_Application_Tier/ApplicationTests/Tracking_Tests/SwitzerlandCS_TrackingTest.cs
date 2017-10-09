using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rentals._02_Utility_Tier;
using Rentals.Resources;
using System.Collections.Generic;
using Rentals._03_Application_Tier.PageObjects.Tracking_PageObjects;

namespace Rentals._03_Application_Tier.ApplicationTests.Tracking_Tests
{
    [TestClass]
    public class SwitzerlandCS_TrackingTest : TestDriver
    {
        
        /// <summary>
        /// 
        /// </summary>
        private FiddlerTrackSettings fiddlerSettings = new FiddlerTrackSettings
        {
            IsFiddlerTrackingRequired = true,
            URLsToTrack = new List<string> { ResourcePGTrackingSwitzerlandCS_TestData.FiddlerMinerva, ResourcePGTrackingSwitzerlandCS_TestData.FiddlerDTMVerification }
        };

        /// <summary>
        /// Swiss_CS Tracking Test
        /// </summary>
        [TestMethod, TestCategory("Tracking Test")]
        public void PG_SwissCSTracking_Test()
        {
            try
            {
                Console.WriteLine("Automation Tests on PG Tracking");

                Reporter.startTest("PG Tracking Verification", "Json testing");
                Reporter.AssignCategory("PG", "ProgramGuide");
                Reporter.strCurrentTestID = "TS001";
                //*******************************************************************************************************
                string dataFileToRefer = null; string dataSheetToRefer = null; string RunFlag = null;
                Helper.getTestDataDetails("'TS001'", out dataFileToRefer, out dataSheetToRefer, out RunFlag);

                FiddlerTest fid = new FiddlerTest();
                fid.SettingProxy_Fiddler(null, fiddlerSettings, ref FiddlerTest.driver);
                SwitzerlandCS_TrackingPage TP = new SwitzerlandCS_TrackingPage(FiddlerTest.driver);
                Assert.AreEqual(TP.VerifySwitzerlandCSApplication(), true);
            }
            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "Tracking Failed", ex.Message);
                Assert.Fail("Known Fail");

                Reporter.EndTest();
            }

        }

    }
}


 
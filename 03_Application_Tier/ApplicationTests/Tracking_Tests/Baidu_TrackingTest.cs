using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rentals._02_Utility_Tier;
using Rentals._03_Application_Tier.PageObjects.Tracking;
using System.Collections.Generic;
using Rentals.Resources;
using Rentals._03_Application_Tier.PageObjects.Tracking_PageObjects;

namespace Rentals._03_Application_Tier.ApplicationTests.Tracking_Tests
{
    [TestClass]
    public class Baidu_TrackingTest : TestDriver
    {
        private FiddlerTrackSettings fiddlerSettings = new FiddlerTrackSettings
        {
            IsFiddlerTrackingRequired = true,
            URLsToTrack = new List<string> { ResourcePGTrackingBaidu_TestData.FiddlerMinerva, ResourcePGTrackingBaidu_TestData.FiddlerDTM, ResourcePGTrackingBaidu_TestData.FiddlerDTMVerification }
        };

        /// <summary>
        /// Baidu Tracking Test
        /// </summary>
        [TestMethod, TestCategory("Tracking Test")]
        public void PG_BaiduTracking_Test()
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

                Baidu_TrackingPage TP = new Baidu_TrackingPage(FiddlerTest.driver);
                Assert.AreEqual(TP.VerifyBaiduApplication(), true);
                Reporter.ReportEvent("Pass", "returned JSON value from Minerva is verified","successful");
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

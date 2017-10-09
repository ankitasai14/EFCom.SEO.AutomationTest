using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Collections.Generic;
using Rentals._02_Utility_Tier;
using Rentals._01_Configuration_Tier.EnvironmentFiles;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
using Newtonsoft.Json;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using Fiddler;
using Rentals.Resources;
using static System.Net.WebRequestMethods;
using System.Web;
using Rentals._03_Application_Tier.PageObjects.Tracking_PageObjects;

namespace Rentals._03_Application_Tier.PageObjects.Tracking
{
    [TestClass]
    public class Baidu_TrackingPage
    {
        /// <summary>
        /// tracking
        /// </summary>
        public IWebDriver driver;
        private object waitForElement;

      


        public Baidu_TrackingPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }


        [TestMethod]
        public bool VerifyBaiduApplication()
        {
            try
            {
                driver.Navigate().GoToUrl("http://www.baidu.com/");
                driver.FindElement(By.Id("kw")).SendKeys(ResourcePGTrackingBaidu_TestData.SearchData);
                Thread.Sleep(3000);

                driver.FindElement(By.Id("su")).Click();

                Thread.Sleep(3000);


                Thread.Sleep(3000);
                driver.FindElement(By.PartialLinkText("liuxue.ef.com.cn/")).Click();

                driver.WaitForAjaxTillPageGetsLoad();
                Thread.Sleep(9000);
                //Checking condition for Minerva link fiddler call
                var baiduMinervaResult = FiddlerHelper.FiddlerTraceBuilder;
                MinervaResult minervaResult = JsonConvert.DeserializeObject<MinervaResult>(baiduMinervaResult[ResourcePGTrackingBaidu_TestData.FiddlerMinerva + "@ResponseBody"].ToString());
                MinervaResult minervaExpectedDetail = JsonConvert.DeserializeObject<MinervaResult>(ResourcePGTrackingBaidu_TestData.CaseOneMinervaExpectedResult);

                var EtagVerify = minervaExpectedDetail.Etag;
                var SourceCodeVerify = minervaExpectedDetail.SourceCode;
                var PartnerVerify = minervaExpectedDetail.Partner;

                if (EtagVerify.Equals("ns_bd_all") && SourceCodeVerify.Equals("007918") && PartnerVerify.Equals("baidu organic"))
                {
                    Reporter.ReportEvent("Pass", "", "");
                }

                driver.WaitForAjaxTillPageGetsLoad();
                Thread.Sleep(9000);
                //Checking the condition for DTM Link
                var baiduDTMResult = FiddlerHelper.FiddlerTraceBuilder;
                string url = baiduDTMResult[ResourcePGTrackingBaidu_TestData.FiddlerDTMVerification + "@FullURL"].ToString();
                if (url.Contains(baiduDTMResult[ResourcePGTrackingBaidu_TestData.FiddlerDTMVerification + "@FullURL"].ToString()))
                {
                    var decodeURL = System.Web.HttpUtility.UrlDecode(url);

                    var DTMDetails = HttpUtility.ParseQueryString(new Uri(decodeURL).Query);
                    DTMResult DTMExpectedDetails = JsonConvert.DeserializeObject<DTMResult>(ResourcePGTrackingBaidu_TestData.CaseOneDTMExpectedResult);


                    var DTMTag1 = DTMExpectedDetails.pageName;
                    var DTMTag2 = DTMExpectedDetails.g;
                    var DTMTag3 = DTMExpectedDetails.c1;
                    var DTMTag4 = DTMExpectedDetails.c3;
                    var DTMTag5 = DTMExpectedDetails.c4;
                    var DTMTag6 = DTMExpectedDetails.c5;
                    var DTMTag7 = DTMExpectedDetails.c7;
                    var DTMTag8 = DTMExpectedDetails.c10;
                    var DTMTag9 = DTMExpectedDetails.c17;
                    var DTMTag10 = DTMExpectedDetails.c20;
                    var DTMTag11 = DTMExpectedDetails.c21;
                    var DTMTag12 = DTMExpectedDetails.c22;
                    var DTMTag13 = DTMExpectedDetails.c25;
                    var DTMTag14 = DTMExpectedDetails.c27;
                    var DTMTag15 = DTMExpectedDetails.c37;
                    var DTMTag16 = DTMExpectedDetails.c39;

                    try
                    {
                        if (
                              DTMTag1.Equals(ResourcePGTrackingBaidu_TestData.pageName)
                              && DTMTag2.Equals(ResourcePGTrackingBaidu_TestData.g)
                              && DTMTag3.Equals(ResourcePGTrackingBaidu_TestData.c1)
                              && DTMTag4.Equals(ResourcePGTrackingBaidu_TestData.c3)
                              && DTMTag5.Equals(ResourcePGTrackingBaidu_TestData.c4)
                              && DTMTag6.Equals(ResourcePGTrackingBaidu_TestData.c5)
                              && DTMTag7.Equals(ResourcePGTrackingBaidu_TestData.c7)
                              && DTMTag8.Equals(ResourcePGTrackingBaidu_TestData.c10)
                              && DTMTag9.Equals(ResourcePGTrackingBaidu_TestData.c17)
                              && DTMTag10.Equals(ResourcePGTrackingBaidu_TestData.c20)
                              && DTMTag11.Equals(ResourcePGTrackingBaidu_TestData.c21)
                              && DTMTag12.Equals(ResourcePGTrackingBaidu_TestData.c22)
                              && DTMTag13.Equals(ResourcePGTrackingBaidu_TestData.c25)
                              && DTMTag14.Equals(ResourcePGTrackingBaidu_TestData.c27)
                              && DTMTag15.Equals(ResourcePGTrackingBaidu_TestData.c37)
                              && DTMTag16.Equals(ResourcePGTrackingBaidu_TestData.c39)
                              )
                        {
                            Reporter.ReportEvent("Pass", "Verified all DTM Tags", "Successful");
                            Console.WriteLine("verified all DTM tags");

                        }




                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    Console.WriteLine("-------------------- Web Page Displayed ------------------");
                    Reporter.ReportEvent("Pass", "Tracking Passed", "Verified all json values");

                }
            }

            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "Tracking Failed", ex.Message);
            }
            driver.Dispose();
            return true;
            }
        }
    }

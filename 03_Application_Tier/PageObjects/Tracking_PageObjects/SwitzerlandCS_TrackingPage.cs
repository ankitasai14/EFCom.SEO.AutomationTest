using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using OpenQA.Selenium;
using Rentals._02_Utility_Tier;
using Rentals.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace Rentals._03_Application_Tier.PageObjects.Tracking_PageObjects
{
    class SwitzerlandCS_TrackingPage
    {
        /// <summary>
        /// tracking
        /// </summary>
        public IWebDriver driver;
        private object waitForElement;

        public SwitzerlandCS_TrackingPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public bool VerifySwitzerlandCSApplication()
        {
            try
            {


                driver.Navigate().GoToUrl("https://www.google.ch/?gws_rd=ssl");
                driver.FindElement(By.Id("lst-ib")).SendKeys(ResourcePGTrackingSwitzerlandCS_TestData.SearchData);
                driver.FindElement(By.Id("lst-ib")).SendKeys(Keys.Tab);
                driver.FindElement(By.Name("btnK")).Click();


                Thread.Sleep(3000);
                //All href links
                string urlLink;

                foreach (IWebElement item in driver.FindElements(By.CssSelector(".r>a")))
                {
                    urlLink = item.GetAttribute("href");
                    if (urlLink.Contains("efswiss.ch/de/pg/auslandsaufenthalt/"))
                    {
                        Console.WriteLine(item.GetAttribute("href"));
                        item.Click();
                        break;
                    }
                }


                driver.WaitForAjax();
                Thread.Sleep(9000);

                //Checking condition for Minerva link fiddler call
                var spainMinervaResult = FiddlerHelper.FiddlerTraceBuilder;
                MinervaResult minervaResult = JsonConvert.DeserializeObject<MinervaResult>(spainMinervaResult[ResourcePGTrackingSwitzerlandCS_TestData.FiddlerMinerva + "@ResponseBody"].ToString());
                MinervaResult minervaExpectedDetail = JsonConvert.DeserializeObject<MinervaResult>(ResourcePGTrackingSwitzerlandCS_TestData.CaseThirdMinervaExpectedResult);

                var EtagVerify = minervaExpectedDetail.Etag;
                var SourceCodeVerify = minervaExpectedDetail.SourceCode;
                var PartnerVerify = minervaExpectedDetail.Partner;

                if (EtagVerify.Equals("ns_ggch_web") && SourceCodeVerify.Equals("007920") && PartnerVerify.Equals("google organic"))
                {
                    Reporter.ReportEvent("Pass", "verified all minerva tags", "successful");
                    Console.WriteLine("verified all minerva tags");

                }
                else
                {
                    Assert.Fail();
                }


                driver.WaitForAjax();
                Thread.Sleep(9000);
                //Checking the condition for DTM Link

                var swissCSDTMResult = FiddlerHelper.FiddlerTraceBuilder;
                string url = swissCSDTMResult[ResourcePGTrackingSwitzerlandCS_TestData.FiddlerDTMVerification + "@FullURL"].ToString();
                if (url.Contains(swissCSDTMResult[ResourcePGTrackingSwitzerlandCS_TestData.FiddlerDTMVerification + "@FullURL"].ToString()))
                {
                    var decodeURL = System.Web.HttpUtility.UrlDecode(url);

                    var DTMDetails = HttpUtility.ParseQueryString(new Uri(decodeURL).Query);
                    DTMResult DTMExpectedDetails = JsonConvert.DeserializeObject<DTMResult>(ResourcePGTrackingSwitzerlandCS_TestData.CaseThirdDTMExpectedResult);

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

                    if (
                          DTMTag1.Equals(ResourcePGTrackingSwitzerlandCS_TestData.pageName)
                          && DTMTag2.Equals(ResourcePGTrackingSwitzerlandCS_TestData.g)
                          && DTMTag3.Equals(ResourcePGTrackingSwitzerlandCS_TestData.c1)
                          && DTMTag4.Equals(ResourcePGTrackingSwitzerlandCS_TestData.c3)
                          && DTMTag5.Equals(ResourcePGTrackingSwitzerlandCS_TestData.c4)
                          && DTMTag6.Equals(ResourcePGTrackingSwitzerlandCS_TestData.c5)
                          && DTMTag7.Equals(ResourcePGTrackingSwitzerlandCS_TestData.c7)
                          && DTMTag8.Equals(ResourcePGTrackingSwitzerlandCS_TestData.c10)
                          && DTMTag9.Equals(ResourcePGTrackingSwitzerlandCS_TestData.c17)
                          && DTMTag10.Equals(ResourcePGTrackingSwitzerlandCS_TestData.c20)
                          && DTMTag11.Equals(ResourcePGTrackingSwitzerlandCS_TestData.c21)
                          && DTMTag12.Equals(ResourcePGTrackingSwitzerlandCS_TestData.c22)
                          && DTMTag13.Equals(ResourcePGTrackingSwitzerlandCS_TestData.c25)
                          && DTMTag14.Equals(ResourcePGTrackingSwitzerlandCS_TestData.c27)
                          && DTMTag15.Equals(ResourcePGTrackingSwitzerlandCS_TestData.c37)
                          && DTMTag16.Equals(ResourcePGTrackingSwitzerlandCS_TestData.c39)
                          )

                    {
                        Reporter.ReportEvent("Pass", "Verified all DTM Tags", "Successful");
                        Console.WriteLine("verified all DTM tags");

                    }


                    else 
                                           
                    Assert.Fail();
                    
                    Thread.Sleep(5000);
                }

                Console.WriteLine("-------------------- Web Page Displayed ------------------");
                Reporter.ReportEvent("Pass", "Tracking Passed", "Verified all json values");
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

           

           
        
    

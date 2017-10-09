using System;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rentals._01_Configuration_Tier.EnvironmentFiles;
using Rentals._02_Utility_Tier;

namespace Rentals._03_Application_Tier.ApplicationTests
{

    [TestClass] 
    public class TestDriver
    {
        public static FiddlerTrackSettings FiddlerSettings { get; set; }

        public static IWebDriver webDriver;      
      
        [TestInitialize]
        public void SetAppLaunch()
        {
            try
            {
                Console.WriteLine("##############Test Started");
                string userNameValue = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                string[] stringSeparators = new string[] { "\\" };
                string[] stringResult = userNameValue.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
                Env.UserName = stringResult[1];
                Env.boolDebugFlag= false;
                Helper.setRelativePath();
                


                if (true)
                {
                   
                   Reporter.GetEnvConfigDetails();
                   

                    Helper.InitalizeWebDriver(ref  webDriver,"");
                    WebPageUtility.webDriver = webDriver;
                    if (Env.strReportFlag == "Y")
                    Reporter.setTestResultFoders();
                    ExtentReports Report = Reporter.createReporterInstance();
                    Reporter.startTest("Application Launch", "Initial Application Launch");

                    Reporter.ReportEvent("Pass", "[Navigation Done to URL] - " + Env.strCurrentURL, " [and has EF Program Guide ]");
                }
            }

            catch (Exception Ex)
            {
                Console.WriteLine("Exception in launch :" + Ex.Message);
            }
        }


        [TestCleanup]
        public void TestClosure()
        {
            try
            {
                if (!Env.boolDebugFlag)
                {
                    Reporter.EndTest();
                    Reporter.Flush();
                   // webDriver.Quit();
                    
                    //Process.Start("firefox.exe", Reporter.strTestResHTMLFilePath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

       

    }
}

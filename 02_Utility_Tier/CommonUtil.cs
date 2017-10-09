using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Rentals._01_Configuration_Tier.EnvironmentFiles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Rentals._02_Utility_Tier;
using System.Reflection;
using System.Diagnostics;

namespace Rentals
{
    // class name: ApprovalQueuePage (included to hold common global entities)


    public class CommonUtil
    {
        //************Global Entity variable*********************** 

        public static IWebDriver WebDriver { get; set; }
        public static IWebElement webElement { get; set; }
        public static Hashtable HashTable { get; set; }
        public static WebDriverWait wait { get; set; }
        public static IList<IWebElement> webElements { get; set; }

        //************Global Helper Methods*************************


        // method name: getTestDataDetails (included to get the test data from excel )

        // Revisions:

        public static void getTestDataDetails(string TestScriptID, out string xlsName, out string xlsSheetName, out string RunFlag)
        {
            try
            {

                System.Data.DataTable oTableEnv = ExcelUtil.ExcelToTable(Env.strRelativePath + Env.Configuration_Tier + Env.sysFileSeperator + Env.EnvironmentFiles + Env.sysFileSeperator + Env.Configuration_xlsx, Env.Scenarios);
                System.Data.DataRow[] oDataRowsEnv = oTableEnv.Select(Env.TestScriptId + TestScriptID);
                xlsName = null;
                RunFlag = null;
                xlsSheetName = null;

                if (oDataRowsEnv.Length != 0)
                {
                    ExcelUtil.oCurrentDataRow = oDataRowsEnv[0];
                    xlsName = ExcelUtil.GetData(Env.TestData);
                    xlsSheetName = ExcelUtil.GetData(Env.TestSheet);
                    RunFlag = ExcelUtil.GetData(Env.Run);
                }
                oTableEnv = null;
                oDataRowsEnv = null;
            }
            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "getTestDataDetails", ex.Message.ToString());
                throw ex;
            }
        }

        // method name: setRelativePath (included to set the all file Relative Path )

        // Revisions

        public static void setRelativePath()
        {
            try
            {
                string strProjectName = Assembly.GetExecutingAssembly().GetName().Name;
                string startupPath = Environment.CurrentDirectory;
                string[] strRootPath = Regex.Split(startupPath, Env.bin);
                Env.strRelativePath = strRootPath[0];
                Console.WriteLine(Env.strRelativePath);
            }
            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "setRelativePath", ex.Message.ToString());
                throw ex;
            }
        }


        // method name: setRelativePath (included to get the time stamp of file creation )

        // Revisions

        public static string getTimeStamp()
        {
            string strDateTime;
            try
            {
                strDateTime = DateTime.Now.ToString();
                strDateTime = strDateTime.Replace("-", "_");
                strDateTime = strDateTime.Replace(":", "_");
                strDateTime = strDateTime.Replace(" ", "_");
                strDateTime = strDateTime.Replace("/", "_");
            }
            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "getTimeStamp", ex.Message.ToString());
                throw ex;
            }
            return strDateTime;
        }

        // method name: GenerateRandomNumber (included to generate random number with number of digits passed as a parameter )

        // Revisions
        public static string GenerateRandomNumber(int numberOfDigits)
        {
            string numberAsString = "";
            try
            {
                const string numbers = "0123456789";
                Random random = new Random();
                StringBuilder builder = new StringBuilder(6);
                for (var i = 1; i < numberOfDigits + 1; i++)
                {
                    builder.Append(numbers[random.Next(0, numbers.Length)]);
                }
                numberAsString = builder.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return numberAsString;
        }

        public static void ChangeExplicitImplicitWaitTime(int seconds)
        {
            try
            {
                CommonUtil.wait = new WebDriverWait(CommonUtil.WebDriver, TimeSpan.FromSeconds(seconds));
                CommonUtil.WebDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(seconds));
                CommonUtil.WebDriver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(seconds));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void KILL_ALL(string strProcess)
        {
            try
            {
                foreach (Process proc in Process.GetProcessesByName(strProcess))
                {
                    proc.Kill();
                    Console.WriteLine("Killed " + strProcess);
                }
            }
            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "Kill Process function", ex.Message);
                throw ex;
            }
        }

    }
}
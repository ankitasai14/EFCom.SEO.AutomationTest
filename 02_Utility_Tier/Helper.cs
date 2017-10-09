using System;
using Rentals._01_Configuration_Tier.EnvironmentFiles;
using System.Reflection;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.IO;

namespace Rentals._02_Utility_Tier
{
    public class Helper
    {
       /// <summary>
       /// Test Data 
       /// </summary>
       /// <param name="TestScriptID"></param>
       /// <param name="xlsName"></param>
       /// <param name="xlsSheetName"></param>
       /// <param name="RunFlag"></param>
        public static void getTestDataDetails(string TestScriptID, out string xlsName, out string xlsSheetName, out string RunFlag)
        {
                System.Data.DataTable oTableEnv = ExcelUtil.ExcelToTable(Env.strRelativePath + Env.strConfigurationXl, "Scenarios");
                System.Data.DataRow[] oDataRowsEnv = oTableEnv.Select("TestScriptId =" + TestScriptID);
                xlsName = null;
                RunFlag = null;
                xlsSheetName = null;
                if (oDataRowsEnv.Length != 0)
                {
                    ExcelUtil.oCurrentDataRow = oDataRowsEnv[0];
                    xlsName = ExcelUtil.GetData("TestData");
                    xlsSheetName = ExcelUtil.GetData("TestSheet");
                    RunFlag = ExcelUtil.GetData("Run");
                }
                oTableEnv = null;
                oDataRowsEnv = null;
        }

       
        public static void setRelativePath()
        {
            string strProjectName = Assembly.GetExecutingAssembly().GetName().Name;
            string startupPath = Environment.CurrentDirectory;
            string[] strRootPath = Regex.Split(startupPath, "bin");

           // DirectoryInfo oDirInfo = Directory.GetParent(Directory.GetCurrentDirectory());
            //GlbVar.strRelativePath = oDirInfo.Parent.Parent.FullName + GlbVar.sysFileSeperator + strProjectName + GlbVar.sysFileSeperator;
            Env.strRelativePath = strRootPath[0];
            Console.WriteLine(Env.strRelativePath);
        }

        public static string getTimeStamp()
        {
            string strDateTime;

            strDateTime = DateTime.Now.ToString();
            strDateTime = strDateTime.Replace("-", "_");
            strDateTime = strDateTime.Replace(":", "_");
            strDateTime = strDateTime.Replace(" ", "_");
            strDateTime = strDateTime.Replace("/", "_");
            return strDateTime;
        }

        public static void InitalizeWebDriver(ref  IWebDriver webDriver, string userAgent)
        {
            try
            {
                string browser = Env.strCurrentBrowser; //Get browser name from the config
                switch (browser)
                {
                    case "Chrome":
                     
                        KILL_ALL("Chrome");
                        var fileName = "";

                        string path = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\Selenium.Chrome.WebDriver.2.30\driver", fileName);

                        webDriver = new ChromeDriver(path);
                        webDriver.Manage().Cookies.DeleteAllCookies();                  

                        break;
                     case "Firefox":
                        //KILL_ALL("firefox");
                        FirefoxDriverService service = FirefoxDriverService.CreateDefaultService();
                        var startDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

                        service.FirefoxBinaryPath = @"C:\Users\ankita.srivastava\Downloads\Firefox Setup Stub 54.0.1.exe";

                         webDriver = new FirefoxDriver(service);
                        break;
                     case "Internet Explorer":
                        Console.WriteLine("Before");
                        
                        break;
                }

            }
            catch (Exception Ex)
            {
                Console.WriteLine("Helper " + Ex.Message);
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
               
            }
        }
    }
}

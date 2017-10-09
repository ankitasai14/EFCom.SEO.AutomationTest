﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel;
using System.Xml;
using LinqToExcel;
using Rentals._01_Configuration_Tier.EnvironmentFiles;
using System.Collections;
using System.Data;
using System.IO;
using Microsoft.Office.Interop.Excel;

namespace Rentals._02_Utility_Tier
{
    public class ExcelUtil
    {
        public static DataRow oCurrentDataRow;


        public static System.Data.DataTable ExcelToTable(string strDataFile, string strDataSheet)
        {
            try
            {
                FileStream oFileStream = File.Open(strDataFile, FileMode.Open, FileAccess.Read);

                IExcelDataReader oExlReader = ExcelReaderFactory.CreateOpenXmlReader(oFileStream);

                oExlReader.IsFirstRowAsColumnNames = true;

                DataSet oDataSet = oExlReader.AsDataSet();

                DataTableCollection oDataCollTable = oDataSet.Tables;

                System.Data.DataTable oResultTable = oDataCollTable[strDataSheet];

                oExlReader.Close();

                return oResultTable;
            }
            catch (Exception Ex)
            {
                Reporter.ReportEvent("Fail", "Data Load Failed from Excel to table", Ex.Message);
                throw Ex;
            }   
        }


        public static string GetData(string strColumnName)
        {
            try
            {
                return ExcelUtil.oCurrentDataRow[strColumnName].ToString();
            }
            catch (DataException e)
            {
                Console.WriteLine(e.StackTrace);
                Reporter.ReportEvent("Fail", "Unable to get the data from the Excel", e.Message);
                return "";
            }
        }


        public static Hashtable poupulateHashFromExcel(string xlsFileName, string xlsSheetName)
        {
            try
            {
                string xlsPathGenration = Env.strRelativePath + Env.strRepositoryFd + xlsFileName + ".xlsx";
                var excelFile = new ExcelQueryFactory(xlsPathGenration);
                var artistAlbums = from a in excelFile.Worksheet(xlsSheetName) select a;
                Hashtable hashtable = new Hashtable();

                foreach (var a in artistAlbums)
                {   
                    hashtable.Add(a["RealName"].ToString().TrimStart().TrimEnd(), a["objectName"].ToString());
                }
                return hashtable;
            }
            catch (Exception Ex)
            {
                Reporter.ReportEvent("Fail", "Data Load Failed for Excel " + xlsFileName + " Sheet " + xlsSheetName, Ex.Message);
                return null;
            }
        }


        public static Dictionary<string,string> populatDictionaryFromExcel(string xlsFileName, string xlsSheetName)
        {

            try
            {
                string xlsPathGenration = Env.strRelativePath + Env.strRepositoryFd + xlsFileName + ".xlsx";
                var excelFile = new ExcelQueryFactory(xlsPathGenration);
                var propertyValues = from a in excelFile.Worksheet(xlsSheetName) select a;
                Dictionary<string, string> oDictionary = new Dictionary<string, string>();

                foreach (var a in propertyValues)
                {
                    if (!((oDictionary.ContainsKey(a["RealName"].ToString())))) //a["objectName"].ToString()
                    {
                        oDictionary.Add(a["RealName"].ToString(), a["objectName"].ToString());
                    }

                }
                return oDictionary;
                
            }
            catch (Exception Ex)
            {
               Reporter.ReportEvent("Fail", "Test Data Load Failed for Excel " + xlsFileName + " Sheet " + xlsSheetName, Ex.Message);
               return null;
            }
        }


        public static ObjectRepoUtil.objectRepositiryDictionary populateMultiDictionaryFromExcel(string xlsFileName, string xlsSheetName)
        {
            try
            {
                string xlsPathGenration = Env.strRelativePath + Env.strRepositoryFd + xlsFileName + ".xlsx";
                var excelFile = new ExcelQueryFactory(xlsPathGenration);
                var propertyValues = from a in excelFile.Worksheet(xlsSheetName) select a;
                var dict = new ObjectRepoUtil.objectRepositiryDictionary();
                foreach (var a in propertyValues)
                {
                    if (!(dict.ContainsKey(a["REFName"].ToString())))
                    {
                        dict.Add(a["REFName"].ToString(), a["Identifier"].ToString(), a["Property"].ToString());
                    }
                    
                }
                return dict;
            }
            catch (Exception Ex)
            {
                Reporter.ReportEvent("Fail", "Data Load Failed for Excel " + xlsFileName + " Sheet " + xlsSheetName, Ex.Message);
                return null;
            }
        }

    }

}

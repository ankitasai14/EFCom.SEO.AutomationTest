using System;
using System.Collections;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace Rentals._02_Utility_Tier
{

    /// <summary>
    /// WebPageUtility
    /// </summary>
    public static class WebPageUtility
    {
        public static IWebDriver webDriver;
     
        public static bool checkElementsByName(ArrayList arrElements)
        {
            bool returnValue = true;
            foreach (string strName in arrElements)
            {
                if (!checkElementByName(strName)) returnValue = false;

            }
            return returnValue;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="strName"></param>
        /// <returns></returns>
        public static bool checkElementByName(string strName)
        {
            bool returnValue = false;
            try
            {
                if (webDriver.FindElement(By.Name(strName)).Displayed)
                {
                    Reporter.ReportEvent("Pass", "Check By Name", "[Element Exist] : " + strName);
                    returnValue = true;
                }
                else
                {
                    Reporter.ReportEvent("Fail", "Check By Name", "[Element Does Not Exist] : " + strName);
                    returnValue = false;
                }
            }
            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "[Element Does Not Exist] : " + strName, ex.Message);
                returnValue = false;
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strName"></param>
        /// <returns></returns>
        public static bool clickElementByXpath(string strName)
        {
            bool returnValue = false;
            try
            {
                if (webDriver.FindElement(By.XPath(strName)).Displayed)
                {
                    webDriver.FindElement(By.XPath(strName)).Click();
                    Reporter.ReportEvent("Pass", "Control Click", "Control Xpath exist and Clicked");

                    returnValue = true;
                }
                else
                {
                    Reporter.ReportEvent("Fail", "Control Click", "Control Xpath  does not exist");

                    returnValue = false;
                }
            }

            catch (Exception excep)
            {
                Reporter.ReportEvent("Fail", "Control Xpath  does not exist", excep.Message);
            }
            return returnValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ObjectRepo"></param>
        /// <returns></returns>
        public static bool clickElementByXpath(ObjectRepoUtil.objPropertyValue ObjectRepo)
        {
            bool returnValue = false;
            try
            {
                if (webDriver.FindElement(By.XPath(ObjectRepo.Property)).Displayed)
                {
                    webDriver.FindElement(By.XPath(ObjectRepo.Property)).Click();
                    Reporter.ReportEvent("Pass", ObjectRepo.REFName + " Click", "Control Xpath exist and Clicked");
                    returnValue = true;
                }
                else
                {
                    Reporter.ReportEvent("Fail", ObjectRepo.REFName + " Clicked", "Control Xpath  does not exist");

                    returnValue = false;
                }
            }

            catch (Exception excep)
            {
                Reporter.ReportEvent("Fail", ObjectRepo.REFName + " Clicked, Control Xpath  does not exist", excep.Message);
                returnValue = false;
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strName"></param>
        /// <returns></returns>
        public static bool clickElementByName(string strName)
        {
            bool returnValue = false;
            try
            {

                if (webDriver.FindElement(By.Name(strName)).Displayed)
                {
                    webDriver.FindElement(By.Name(strName)).Click();
                    Reporter.ReportEvent("Pass", "click by Name", "[Element Exist And Clicked] :" + strName);
                    returnValue = true;
                }
                else
                {

                    returnValue = false;
                }
            }

            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "Click by Name", "[Element Does Not Exist Cannot Be Clicked] : " + strName + ex.Message);
                returnValue = false;
            }
            return returnValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strName"></param>
        /// <returns></returns>
        public static bool clickElementByLinkText(string strName)
        {
            bool returnValue = false;
            try
            {

                if (webDriver.FindElement(By.LinkText(strName)).Displayed)
                {
                    webDriver.FindElement(By.LinkText(strName)).Click();
                    Reporter.ReportEvent("Pass", "Text", "[Link Exist And Clicked] : " + strName);
                    returnValue = true;
                }
                else
                {
                    Reporter.ReportEvent
                        ("Fail", "Text", "[Link Does Not Exist Cannot Be Clicked] : " + strName);
                    returnValue = false;
                }
            }
            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "[Link Does Not Exist Cannot Be Clicked] : " + strName, ex.Message);
                returnValue = false;
            }

            return returnValue;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="strName"></param>
        /// <returns></returns>
        public static bool clickElementByPartialLinkText(string strName)
        {
            bool returnValue = false;
            try
            {

                if (webDriver.FindElement(By.PartialLinkText(strName)).Displayed)
                {
                    webDriver.FindElement(By.PartialLinkText(strName)).Click();
                    Reporter.ReportEvent("Pass", "Text", "[Link Exist And Clicked] : " + strName);
                    returnValue = true;
                }
                else
                {
                    Reporter.ReportEvent
                        ("Fail", "Text", "[Link Does Not Exist Cannot Be Clicked] : " + strName);
                    returnValue = false;
                }
            }
            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "[Link Does Not Exist Cannot Be Clicked] : " + strName, ex.Message);
                returnValue = false;
            }

            return returnValue;
        }
        /// <summary>
        /// clickElementByID
        /// </summary>
        /// <param name="strName"></param>
        /// <returns></returns>
        public static bool clickElementByID(string strName)
        {
            bool returnValue = false;
            try
            {

                if (webDriver.FindElement(By.Id(strName)).Displayed)
                {
                    webDriver.FindElement(By.Id(strName)).Click();
                    Reporter.ReportEvent("Pass", "Click By Id", "[Element By ID Exist And Clicked] : " + strName);
                    returnValue = true;
                }
                else
                {
                    Reporter.ReportEvent("Fail", "Click By Id", "[Element by ID Does Not Exist Cannot Be Clicked] : " + strName);
                    returnValue = false;
                }
            }
            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "[Element by ID Does Not Exist Cannot Be Clicked] : " + strName, ex.Message);
                returnValue = false;
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Locator"></param>
        /// <param name="InputString"></param>
        /// <returns></returns>
        public static bool inputTextByXpath(string Locator, string InputString)
        {
            bool returnValue = false;
            try
            {
                if (true)
                {
                    webDriver.FindElement(By.XPath(Locator)).SendKeys(InputString);
                    Reporter.ReportEvent("Pass", "Text Input", Locator + "By Xpath exist and entered" + InputString);
                    returnValue = true;
                }
                else
                {
                    Reporter.ReportEvent("Fail", "Text Input", Locator + "By Xpath Does Not Exist And Cannot Typed] : " + InputString);
                    returnValue = false;
                }
            }
            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "Failed to locate", Locator + ex.Message);
                Console.WriteLine("Exception:" + ex.Message);
            }
            return returnValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objectRef"></param>
        /// <param name="InputString"></param>
        /// <returns></returns>
        public static bool inputTextByXpath(ObjectRepoUtil.objPropertyValue objectRef, string InputString)
        {

            bool returnValue = false;
            try
            {
                if (webDriver.FindElement(By.XPath(objectRef.Property)).Displayed)
                {
                    webDriver.FindElement(By.XPath(objectRef.Property)).Clear();
                    webDriver.FindElement(By.XPath(objectRef.Property)).SendKeys(InputString);
                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");

                    Console.WriteLine("Text Input", objectRef.REFName + "By Xpath exist and entered" + InputString);

                    Reporter.ReportEvent("Pass", "Text Input", objectRef.REFName + "By Xpath exist and entered" + InputString);
                    returnValue = true;
                }
                else
                {
                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                    Reporter.ReportEvent("Fail", "Failed to loacte", objectRef + "By Xpath Does Not Exist And Cannot Typed] : " + InputString);
                    returnValue = false;
                }
            }
            catch (Exception excep)
            {
                Console.WriteLine(excep.Message);
                Reporter.ReportEvent("Fail", "Failed to loacte", objectRef + excep.Message);
            }
            return returnValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idElementName"></param>
        /// <param name="InputString"></param>
        /// <returns></returns>
        public static bool inputTextByID(string idElementName, string InputString)
        {
            bool returnValue = false;
            try
            {
                webDriver.FindElement(By.Id(idElementName)).SendKeys(InputString);
                Reporter.ReportEvent("Pass", idElementName + " By ID Exist And Typed] : " + InputString, "");
                returnValue = true;

            }
            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "Failed to click", idElementName + " " + ex.Message);
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="pageTitle"></param>
        /// <param name="MarketCode"></param>
        /// <returns></returns>
        public static bool naviGateToUrl(string url, string pageTitle, string MarketCode)
        {
            bool returnValue = false;
            try
            {
                WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(1000));
                webDriver.Navigate().GoToUrl(url + MarketCode);

                WebPageUtility.WaitForAjax(webDriver);
                if (webDriver.Title.Contains(""))
                {
                    Reporter.ReportEvent("Pass", "[Navigation Done to URL] - " + url, " [and has Title ]" + pageTitle);
                    webDriver.Manage().Window.Maximize();
                   
                    returnValue = true;
                }
                else
                {
                    Reporter.ReportEvent("Fail", "Application Launch", "[Navigation To URL failed] - " + url);
                    returnValue = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Reporter.ReportEvent("Fail", "Application Launch", "[Navigation To URL failed] - " + url + ex.Message);

            }
            return returnValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="linkName"></param>
        /// <returns></returns>
        public static bool PartialLinkText(String linkName)
        {
            bool returnValue = false;
            try
            {

                if (webDriver.FindElement(By.PartialLinkText(linkName)).Displayed)
                {
                    Reporter.ReportEvent("Pass", "Text", "[Link Exist] : " + linkName);
                    returnValue = true;
                }
            }
            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "Text", "[Link Does not Exist] : " + linkName);
                returnValue = false;
            }
            return returnValue;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="arrElements"></param>
        /// <returns></returns>
        public static bool PartialLinksText(ArrayList arrElements)
        {

            bool returnValue = true;
            foreach (string strName in arrElements)
            {
                if (!PartialLinkText(strName)) returnValue = false;

            }
            return returnValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tagName"></param>
        /// <param name="searchElement"></param>
        /// <returns></returns>
        public static bool FindElementByTag(String tagName, string searchElement)
        {
            bool returnValue = false;
            try
            {

                if (webDriver.FindElement(By.XPath("//" + tagName + "[contains(text(),'" + searchElement + "')]")).Displayed)
                {
                    Reporter.ReportEvent("Pass", "Locate By Tag", "[Element by tag(" + tagName + ") Exist] : " + searchElement);
                    returnValue = true;

                }
            }
            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "[Element by tag(" + tagName + ") Does not Exist] : " + searchElement, ex.Message);
                returnValue = false;
            }
            return returnValue;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="arrElements"></param>
        /// <param name="strTagname"></param>
        /// <returns></returns>
        public static bool FindElementsByTag(ArrayList arrElements, string strTagname)
        {

            bool returnValue = true;
            foreach (string strName in arrElements)
            {
                if (!FindElementByTag(strTagname, strName)) returnValue = false;

            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strName"></param>
        /// <returns></returns>
        public static bool checkElementByID(string strName)
        {
            bool returnValue = false;
            try
            {
                IWebElement WE = webDriver.FindElement(By.Id(strName));

                if (WE.Displayed)
                {
                    Reporter.ReportEvent("Pass", "Check By Id", "[Element By ID =" + strName + " Exist] with text : " + WE.Text);
                    returnValue = true;
                }
                WE = null;
            }
            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "[Element by ID Does Not Exist] : " + strName, ex.Message);
                returnValue = false;
            }
            return returnValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arrElements"></param>
        /// <returns></returns>
        public static bool checkElementsByID(ArrayList arrElements)
        {

            bool returnValue = true;
            foreach (string strName in arrElements)
            {
                if (!checkElementByID(strName)) returnValue = false;

            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strName"></param>
        /// <returns></returns>
        public static bool checkElementByClass(string strName)
        {
            bool returnValue = false;
            try
            {
                IWebElement WE = webDriver.FindElement(By.ClassName(strName));

                if (WE.Displayed)
                {
                    Reporter.ReportEvent("Pass", "Check By Class", "[Element By Class =" + strName + " Exist] with text : " + WE.Text);
                    returnValue = true;
                }
                WE = null;
            }
            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "[Element by Class Does Not Exist] : " + strName, ex.Message);
                returnValue = false;
            }
            return returnValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arrElements"></param>
        /// <returns></returns>
        public static bool checkElementsByClass(ArrayList arrElements)
        {

            bool returnValue = true;
            foreach (string strName in arrElements)
            {
                if (!checkElementByClass(strName)) returnValue = false;

            }
            return returnValue;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="elementByID"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool checkTextExistInElementByID(string elementByID, string text)
        {
            bool returnValue = false;

            try
            {
                IWebElement WE = webDriver.FindElement(By.Id(elementByID));


                if (WE.Displayed)
                {
                    if (WE.Text.Contains(text))
                    {
                        Reporter.ReportEvent("Pass", "Check Element Exist", "[Element By ID =" + elementByID + " Exist] with text : " + text);
                        returnValue = true;
                    }
                    else
                    {
                        Reporter.ReportEvent("Fail", "Check Element Exist", "[Element By ID =" + elementByID + " Exist] without text : " + text);
                        returnValue = true;
                    }
                }
                WE = null;
            }
            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "[Element By ID =" + elementByID + " Exist] without text : " + text, ex.Message);
                returnValue = false;
            }
            return returnValue;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="arrElements"></param>
        /// <returns></returns>
        public static bool checkTextExistInElementsByID(ArrayList arrElements)
        {

            bool returnValue = true;
            string elementName = "";
            if (arrElements.Count > 1)
            {
                elementName = arrElements[0].ToString();
                arrElements.RemoveAt(0);
                foreach (string strName in arrElements)
                {
                    if (!checkTextExistInElementByID(elementName, strName)) returnValue = false;

                }
            }
            else
            {
                returnValue = false;
            }

            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="elementByClass"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool checkTextExistInElementByClass(string elementByClass, string text)
        {
            bool returnValue = false;

            try
            {
                IWebElement WE = webDriver.FindElement(By.ClassName(elementByClass));


                if (WE.Displayed)
                {
                    if (WE.Text.Contains(text))
                    {
                        Reporter.ReportEvent("Pass", "[Element By Class =", elementByClass + " Exist] with text : " + text);
                        returnValue = true;
                    }
                    else
                    {
                        Reporter.ReportEvent("Fail", "[Element By Class =", elementByClass + " Exist] without text : " + text);
                        returnValue = true;
                    }
                }
                WE = null;
            }
            catch (Exception ex)
            {
                Reporter.ReportEvent("Fail", "[Element by Class Does Not Exist] : " + elementByClass, ex.Message);
                returnValue = false;
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arrElements"></param>
        /// <returns></returns>
        public static bool checkTextExistInElementsByClass(ArrayList arrElements)
        {

            bool returnValue = true;
            string elementName = "";
            if (arrElements.Count > 1)
            {
                elementName = arrElements[0].ToString();
                arrElements.RemoveAt(0);
                foreach (string strName in arrElements)
                {
                    if (!checkTextExistInElementByClass(elementName, strName)) returnValue = false;

                }
            }
            else
            {
                returnValue = false;
            }

            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="objectRef"></param>
        /// <returns></returns>
        public static string getTextFromTableByXpath(ObjectRepoUtil.objPropertyValue objectRef)
        {

            //bool returnValue = false;
            string returnValue = null;
            try
            {
                if (webDriver.FindElement(By.XPath(objectRef.Property)).Displayed)
                {
                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");

                    Console.WriteLine("Text Object", objectRef.REFName + "By Xpath object exist and entered");

                    Reporter.ReportEvent("Pass", "Text Input", objectRef.REFName + "By Xpath object exist");
                    returnValue = webDriver.FindElement(By.XPath(objectRef.Property)).Text.ToString();
                }
                else
                {
                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                    Reporter.ReportEvent("Fail", "Text Input", objectRef.REFName + "By Xpath object exist");
                }
            }
            catch (Exception excep)
            {
                Console.WriteLine(excep.Message);
                Reporter.ReportEvent("Fail", "Text Input" + objectRef.REFName + "By Xpath object exist", excep.Message);
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="objectRef"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool checkTextExistInElementByXPath(ObjectRepoUtil.objPropertyValue objectRef, string text)
        {
            bool returnValue = false;

            try
            {
                IWebElement WE = webDriver.FindElement(By.XPath(objectRef.Property));


                if (WE.Displayed)
                {
                    if (WE.Text.Contains(text))
                    {
                        Reporter.ReportEvent("Pass", "Text Verify", "[Element By XPath =" + objectRef.REFName + " Exist] with text : " + text);
                        returnValue = true;
                    }
                    else
                    {
                        Reporter.ReportEvent("Fail", "Text Verify", "[Element By XPath =" + objectRef.REFName + " Exist] with text : " + text);
                        returnValue = true;
                    }
                }
                WE = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:" + ex.Message);
                Reporter.ReportEvent("Fail", "Text Verify", "[Element By XPath =" + objectRef.REFName + " Exist] with text : " + text);
                returnValue = false;
            }
            return returnValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="timeoutSecs"></param>
        /// <param name="throwException"></param>
        public static void WaitForAjax(this IWebDriver driver, int timeoutSecs = 10, bool throwException = false)
        {
            for (var i = 0; i < timeoutSecs; i++)
            {
                var ajaxIsComplete = (bool)(driver as IJavaScriptExecutor).ExecuteScript("return jQuery.active == 0");   //"return((window.jQuery != null) && (jQuery.active === 0))");

                if (ajaxIsComplete) return;
                Thread.Sleep(1000);
            }
            if (throwException)
            {
                throw new Exception("WebDriver timed out waiting for AJAX call to complete");
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="timeoutSecs"></param>
        /// <param name="throwException"></param>
        public static void WaitForAjaxTillPageGetsLoad(this IWebDriver driver, int timeoutSecs = 10, bool throwException = false)
        {
            while (true) // Handle timeout somewhere
            {
                var ajaxIsComplete = (bool)(driver as IJavaScriptExecutor).ExecuteScript("return jQuery.active == 0");
                if (ajaxIsComplete)
                    break;
                Thread.Sleep(100);
            }
        }

        /// <summary>
        /// Verify element
        /// </summary>
        /// <param name="by"></param>
        /// <returns></returns>
        public static bool IsElementPresent(By by)
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
            try
            {
                webDriver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            finally
            {
                webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
            }
        }
    }
}




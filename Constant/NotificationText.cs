using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentals.Constant
{
    public static class NotificationText
    {
       // #region Test Device Constants
        public enum BrowserType
        {
            Chrome,
            PhantomJs,
            InternetExplorer,
            Safari,
            FireFox
        }

        public enum DeviceType
        {
            Desktop,
            IPhone5,
            IPhone6,
            SamSungPhone,
            HuaWeiPhone,
            IPad,
            WindowsPhone
        }

        //Notification for Browser Launchng
        public static string browserLaunch = "BROWSER LAUNCHED :  ";

        //Notifications for Browser Closing
        public static string browserClose = "BROWSER CLOSED ";
        public static string browserNotClosed = "BROWSER NOT CLOSED ";

        //Notifications for Canonical Tag Test

        public static string countryMessage = "The country  :  ";
        public static string canonicalPassMessage = "Current page URL and URL on the PageSource MATCHING\n";
        public static string canonicalFailMessage = "Current page URL and URL on the PageSource NOT MATCHING\n";


        //Notifications for Tracking Data Test
        public static string cookieMessage = "Number of Cookies Present:   ";
        public static string cookieNameMessage = "The Cookie Name Content :  ";
        public static string cookieValueMessage = "The Cookie Value is :  ";
        public static string cookiePresentMessage = "google organic data is present in cookie value";
        public static string cookieNotPresentMessage = "google organic data is not present in cookie value";
        public static string PageName = "The First Page Name is :   ";
        public static string firstPageNamePassMessage = "Required page name exist";
        public static string firstPageNameFailMessage = "Required page name does not exist";
        public static string popUpPageName = "The Pop-up option Page Name is :   ";
        public static string firstOptionPageNamePassMessage = "Required page name exist";
        public static string firstOptionPageNameFailMessage = "Required page name does not exist";

        //Notification for URL comparison 
        public static string SuccessMessage = "The {0} test is succeed!";

        //E-mail Constants
        public static string reportEMailBody = "Please go through the attachment for the report";

        public static string LoggingCanoincalURL = "The Curernt URL is: {0}; The Canonical URL is: {1}";
        public static string LoggingChangeCountryFooterURL = "The {0} change country footer link is: {1}; The expected footer link is {2}";

        //Notification for URL comparison 
        public static string countryURLMessage = "The country HREF's are Matching";

        //Notification for TopPages
        public static string ChooseProgramDropDown = "Choose Program : ";
        public static string TopPagefirstName = "First Name : ";
        public static string TopPageLastName = "Last Name : ";
        public static string TopPageAddress = "Address : ";
        public static string TopPagePostalCode = "Postal code : ";

        public static string TopPageMobileNumber = "Mobile Number : ";
        public static string TopPageMobileEmail = "Email : ";

        public static string TopPagePhoneNumber = "Phone Number : ";
        public static string TopPagePhoneAreaCode = "Phone AreaCode : ";
        public static string TopPagePhoneEmail = "Email : ";

        //Notification for PG Tracking Baidu data
        public static string Browser = "Search Engine : ";
        public static string SearchKey = "SearchKey : ";
        public static string PgPage = "PG Page URL : ";
        public static string SourceCode = "SourceCode : ";
        public static string Partner = "Partner : ";
        public static string Etag = "Etag : ";
        public static string MinervaMessage = "Detail report of Minerva call are as follows:";
        public static string DTMMessage = "Detail report of DTM call are as follows :";

    }
}


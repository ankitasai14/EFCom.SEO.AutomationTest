using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.IO;
using Rentals;
using System.Collections;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Rentals._02_Utility_Tier
{
    [TestClass]
    class RestAPICall
    { 
        string JsonUrl = "http://liuxue.ef.com.cn/ef-services/svc-lb/tracking/minerva?mc=CN&url=http%3A%2F%2Fliuxue.ef.com.cn%2Fpg%2F&ref=&LeadInfo=True";
        public void getRequestFromMinerva()
        {
            WebRequest myWebRequest = WebRequest.Create(JsonUrl);

            WebResponse myWebResponse = myWebRequest.GetResponse();

           
            Stream ReceiveStream = myWebResponse.GetResponseStream();
            Encoding encode = System.Text.Encoding.GetEncoding("utf-8");
            
            
            StreamReader readStream = new StreamReader(ReceiveStream, encode);
            string strResponse = readStream.ReadToEnd();

            dynamic json = JValue.Parse(strResponse);

            // values require casting
            string partnerValue = json.Partner;
            string sourceCodeValue = json.SourceCode;
            string eTagValue = json.Etag;

            Assert.AreEqual(partnerValue, "baidu organic");
            Assert.AreEqual(sourceCodeValue, "007918");
            Assert.AreEqual(eTagValue, "ns_bd_all");

            
                myWebResponse.Close();
            }


        }
    }

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fiddler;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Rentals._02_Utility_Tier
{
    [TestClass]
    public class FiddlerHelper
    {
        private static int _hitCounter = 1;
        public static Dictionary<string, StringBuilder> FiddlerTraceBuilder = new Dictionary<string, StringBuilder>();
        static List<string> urlToTrack = new List<string>();

        internal static int StartFiddlerProxy(int desiredPort, List<string> urlToTrack)
        {
            FiddlerHelper.urlToTrack = urlToTrack;
            // We explicitly do *NOT* want to register this running Fiddler
            // instance as the system proxy. This lets us keep isolation.
            Trace.TraceInformation("Starting Fiddler proxy");
            FiddlerCoreStartupFlags flags = FiddlerCoreStartupFlags.Default &
                                            ~FiddlerCoreStartupFlags.RegisterAsSystemProxy;

            FiddlerApplication.Startup(desiredPort, flags);
            int proxyPort = FiddlerApplication.oProxy.ListenPort;
            Trace.TraceInformation("Fiddler proxy listening on port {0}", proxyPort);

            // Hook up the event for monitoring proxied traffic.
            FiddlerApplication.AfterSessionComplete += FiddlerApplication_AfterSessionComplete;
            return proxyPort;
        }

        private static void FiddlerApplication_AfterSessionComplete1(Session session)
        {
            // data comes through, just not the LightStreamer Data
            var respBody = session.GetResponseBodyAsString();
            Console.WriteLine(respBody);

            // do something with the response body.
        }
        internal static Dictionary<string, StringBuilder> StopFiddlerProxy(bool isShutdown)
        {

            Trace.TraceInformation("Shutting down Fiddler proxy");
            if (isShutdown)
                FiddlerApplication.Shutdown();
            var result = FiddlerTraceBuilder;
            return result;
        }
        private static void FiddlerApplication_AfterSessionComplete(Fiddler.Session sess)
        {

            _hitCounter++;

            var match = urlToTrack.FindIndex(urlval => sess.fullUrl.Contains(urlval));


            if (match > -1)
            {
                var type = urlToTrack.Find(urlval => sess.fullUrl.Contains(urlval));
                if (!string.IsNullOrEmpty(CaptureConfiguration.CaptureDomain))
                {
                    if (sess.hostname.ToLower() != CaptureConfiguration.CaptureDomain.Trim().ToLower())
                        return;
                }
                if (CaptureConfiguration.IgnoreResources)
                {
                    var url = sess.fullUrl.ToLower();
                    List<String> extensions = CaptureConfiguration.ExtensionFilterExclusions;
                    foreach (var ext in extensions)
                    {
                        if (url.Contains(ext))
                        {
                            //ignore the specified extension
                            return;
                        }
                    }
                    List<string> filters = CaptureConfiguration.UrlFilterExclusions;
                    foreach (string urlFilter in filters)
                    {
                        if (url.Contains(urlFilter))
                            return;
                    }
                }
                if (null == sess || null == sess.oRequest || null == sess.oRequest.headers)
                    return;

                var respHeaders = sess.oResponse.headers.ToString();
                var respBody = sess.GetResponseBodyAsString().Trim().Trim('\r', '\n');
                

                FiddlerTraceBuilder.Add(type + "@FullURL", new StringBuilder(sess.fullUrl));
                FiddlerTraceBuilder.Add(type + "@ResponseHeader", new StringBuilder(respHeaders));
                FiddlerTraceBuilder.Add(type + "@ResponseBody", new StringBuilder(respBody));

               
               
            }
        }
        
    


    public static class CaptureConfiguration
    {
        //TODO: [TED] make this configuration read from Setting file
        internal static Boolean IgnoreResources = true;
        internal static String CaptureDomain = String.Empty;
        internal static List<String> ExtensionFilterExclusions;
        internal static List<Int32> ResponseCodeFilterExclusions;
        internal static List<String> UrlFilterExclusions;

        static CaptureConfiguration()
        {
            ExtensionFilterExclusions = new List<String>() { ".css", ".png", ".ico", ".jpg", ".gif" };

            ResponseCodeFilterExclusions = new List<Int32> { 200, 201, 302, 304 };

            UrlFilterExclusions = new List<String>();
        }
    }
}
}




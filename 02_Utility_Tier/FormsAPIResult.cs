using Rentals.Constant;
using System.Collections.Generic;

namespace Rentals._02_Utility_Tier
{
    class FormsAPIResult
    {

        public int FormId { get; set; }
        public string TrueProgramCode { get; set; }
    }
    class MinervaResult
    {
        public string SourceCode { get; set; }
        public string Partner { get; set; }
        public string Etag { get; set; }
    }
    class DTMResult
    {
        public string pageName { get; set; }
        public string g { get; set; }
        public string c1 { get; set; }
        public string c3 { get; set; }
        public string c4 { get; set; }
        public string c5 { get; set; }
        public string c7 { get; set; }
        public string c10 { get; set; }
        public string c17 { get; set; }
        public string c20 { get; set; }
        public string c21 { get; set; }
        public string c22 { get; set; }
        public string c25 { get; set; }
        public string c27 { get; set; }
        public string c37 { get; set; }
        public string c39 { get; set; }
    }


    public class FiddlerTrackSettings
    {
        public bool IsFiddlerTrackingRequired { get; set; }
        public List<string> URLsToTrack { get; set; }
    }


}

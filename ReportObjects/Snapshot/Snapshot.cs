﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AppDynamics.Dexter.DataObjects
{
    public class Snapshot
    {
        public string Controller { get; set; }
        public string ControllerLink { get; set; }

        public long ApplicationID { get; set; }
        public string ApplicationLink { get; set; }
        public string ApplicationName { get; set; }

        public long TierID { get; set; }
        public string TierLink { get; set; }
        public string TierName { get; set; }

        public long NodeID { get; set; }
        public string NodeLink { get; set; }
        public string NodeName { get; set; }

        public long BTID { get; set; }
        public string BTLink { get; set; }
        public string BTName { get; set; }

        public DateTime Occured { get; set; }
        public DateTime OccuredUtc { get; set; }

        public string RequestID { get; set; }
        public string UserExperience { get; set; }
        public long Duration { get; set; }
        public string DiagSessionID { get; set; }
        public string URL { get; set; }

        public string TakenSummary { get; set; }
        public string TakenReason { get; set; }

        public string CallGraphType { get; set; }
        public bool IsArchived { get; set; }

        public int NumSegments { get; set; }
        public int NumCallGraphs { get; set; }

        public int NumCalledBackends { get; set; }
        public int NumCalledTiers { get; set; }
        public int NumCalledApplications { get; set; }

        public int NumCallsToBackends { get; set; }
        public int NumCallsToTiers { get; set; }
        public int NumCallsToApplications { get; set; }

        public bool HasErrors { get; set; }
        public int NumErrors { get; set; }

        public int NumSEPs { get; set; }

        public int NumHTTPDCs { get; set; }
        public int NumMIDCs { get; set; }

        public string CallChains { get; set; }
        public string ExitTypes { get; set; }

        public string DetailLink { get; set; }
        public string SnapshotLink { get; set; }

        public override String ToString()
        {
            return String.Format(
                "Snapshot: {0}: {1}/{2}/{3}/{4}/{5:o}",
                this.RequestID,
                this.ApplicationName,
                this.BTName,
                this.TierName,
                this.NodeName,
                this.Occured);
        }
    }
}
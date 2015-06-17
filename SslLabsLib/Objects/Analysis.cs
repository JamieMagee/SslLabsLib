﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using SslLabsLib.Code;

namespace SslLabsLib.Objects
{
    public class Analysis
    {
        /// <summary>
        /// Assessment host, which can be a hostname or an IP address
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// Assessment port (e.g., 443)
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// Protocol (e.g., HTTP)
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// True if this assessment publicly available (listed on the SSL Labs assessment boards)
        /// </summary>
        public bool IsPublic { get; set; }

        /// <summary>
        /// Assessment status; possible values: DNS, ERROR, IN_PROGRESS, and READY.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Status message in English. When status is ERROR, this field will contain an error message.
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Assessment starting time, in milliseconds since 1970
        /// </summary>
        [JsonConverter(typeof(MillisecondEpochConverter))]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Assessment completion time, in milliseconds since 1970
        /// </summary>
        [JsonConverter(typeof(MillisecondEpochConverter))]
        public DateTime TestTime { get; set; }

        /// <summary>
        /// Assessment engine version (e.g., "1.0.120")
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Grading criteria version (e.g., "2009")
        /// </summary>
        public string CriteriaVersion { get; set; }

        /// <summary>
        /// When will the assessment results expire from the cache (typically set only for assessment with errors; otherwise the results stay in the cache for as long as there's sufficient room)
        /// </summary>
        public long CacheExpiryTime { get; set; }

        /// <summary>
        /// List of Endpoint objects
        /// </summary>
        public List<Endpoint> Endpoints { get; set; }

        /// <summary>
        /// The list of certificate hostnames collected from the certificates seen during assessment. The hostnames may not be valid.
        /// </summary>
        public List<string> CertHostnames { get; set; }
    }
}
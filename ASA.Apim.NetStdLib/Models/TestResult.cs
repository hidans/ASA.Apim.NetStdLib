using System;
using System.Collections.Generic;
using System.Text;

namespace ASA.Apim.NetStdLib.Models
{
    public class TestResult
    {
        public string Account { get; set; }
        public DateTime Created { get; set; }
        public string ServiceName { get; set; }
        public long ResponseTime { get; set; }
        public int FetchSize { get; set; }
        public int ResponseCount { get; set; }
        public decimal AvgResponseTime { get; set; }
        public int NumberOfRequest { get; set; }
    }
}

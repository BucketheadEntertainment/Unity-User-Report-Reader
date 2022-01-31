﻿using Unity_User_Reporting_Reader.Models.Report.MetricInfo;

namespace Unity_User_Reporting_Reader.Models.Report
{
    public class Measure
    {
        public int endFrameNumber;
        public object[] metadata;
        public Metric[] metrics;
        public int startFameNumber;
    }
}

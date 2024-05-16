using System;

namespace POC_Brightbox_EPG_Reader
{
    internal class clsScheduleEvents
    {
        public string channelName { get; set; }
        public DateTime endTime { get; set; }
        public string eventName { get; set; }
        public string eventText { get; set; }
        public int runningStatus { get; set; }
        public DateTime startTime { get; set; }
        public string Carrier { get; set; }
        public string Region { get; set; }
        public int dur { get { return (int)(endTime - startTime).TotalSeconds/60; } }

        public string GetEvent()
        {
            return channelName + "\t" + Carrier + "\t"+ Region + "\t"+ startTime.ToString("yyyy-MM-dd") + "\t" + eventName + "\t" + startTime.ToString("HH:mm") + "\t" + endTime.ToString("HH:mm") + "\t" + dur + "\t" + eventText;
        }   
    }
}
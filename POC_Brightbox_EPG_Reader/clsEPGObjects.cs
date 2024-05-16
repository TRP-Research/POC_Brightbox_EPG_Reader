using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_Brightbox_EPG_Reader
{
   
        public class Schedule
        {
            public string address { get; set; }
            public Eventsavailable[] eventsAvailable { get; set; }
            public int port { get; set; }
            public string serviceName { get; set; }
        }

        public class Eventsavailable
        {
            public int endTime { get; set; }
            public string eventName { get; set; }
            public string eventText { get; set; }
            public int runningStatus { get; set; }
            public int startTime { get; set; }
        }

    
}

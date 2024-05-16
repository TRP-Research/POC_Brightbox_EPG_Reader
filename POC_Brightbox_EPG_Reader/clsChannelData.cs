using System.Collections.Generic;
using System;

namespace POC_Brightbox_EPG_Reader
{
    public class clsChannelData
    {
        public int Idx { get; set; }
        public int Carrier { get; set; }
        public int Region { get; set; }

        public int Platform { get; set; } = 0;

        public string RTSPPath { get; set; }

        public string WorkName { get; set; }

        public string UIName { get; set; }

        public int StartTime { get; set; }
        public int Endtime { get; set; }

        public bool Active { get; set; }


        public List<ActiveDate> ActiveDates { get; set; } = new List<ActiveDate>();



        public string LookupName
        {
            get
            {

                return String.Format("{0}_{1}_{2}_{3}", Carrier, Region, Platform, UIName);
            }
        }

        public string FFmpegPath
        {
            get; set;
        } = "";

        private bool _Recording = false;

        private int intStartTime
        {
            get { return intTimeToIntegerMins(StartTime); }
        }

        private int intEndTime
        {
            get { return intTimeToIntegerMins(Endtime); }
        }
        private int intTimeToIntegerMins(int startTime)
        {
            string timestr = startTime.ToString().PadLeft(4, '0');
            string mins = timestr.Substring(2);
            string hrs = timestr.Substring(0, 2);

            return int.Parse(hrs) * 60 + int.Parse(mins);
        }

        public bool RecordingNow(DateTime CurrentIimeUTC)
        {
            int CurrentTimeInMins = CurrentIimeUTC.Minute + 60 * CurrentIimeUTC.Hour;
            if (StartTime < Endtime)
            {
                if (Active == true && intStartTime - 1 <= CurrentTimeInMins && intEndTime - 1 >= CurrentTimeInMins)//daytime
                {
                    _Recording = true;
                    return true;
                }
                else
                {
                    _Recording = false;
                    return false;
                }
            }
            else
            {
                if (Active == true && intStartTime - 2 <= CurrentTimeInMins || intEndTime - 1 >= CurrentTimeInMins)//nighttime
                {
                    _Recording = true;
                    return true;
                }
                else
                {
                    _Recording = false;
                    return false;
                }
            }
        }
    }

    public class ActiveDate
    {
        public ActiveDate() { }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; } = new DateTime(9999, 12, 31);
    }
}
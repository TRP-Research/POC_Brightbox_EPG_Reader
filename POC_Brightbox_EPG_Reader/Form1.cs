using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraPrinting.Native.WebClientUIControl;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POC_Brightbox_EPG_Reader
{
    public partial class Form1 : Form
    {

        private Dictionary<string, List<clsScheduleEvents>> AllChannels = new Dictionary<string, List<clsScheduleEvents>>();

        private List<clsCarrier> Carriers = new List<clsCarrier>();

        private BindingList<clsChannelData> MasterChannelLst = new BindingList<clsChannelData>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnReadJson_Click(object sender, EventArgs e)
        {
            //var json = System.IO.File.ReadAllText(@"W:\Interfaces\Data Enrichment - Sky Files\Working Files\Sky EPG\2024-03-05T11_26_40Z_guide.json");
            //var json = System.IO.File.ReadAllText(@"W:\Interfaces\Data Enrichment - Sky Files\Working Files\Sky EPG\2024-03-06T19_29_28Z_guide.json");
            var json = System.IO.File.ReadAllText(@"D:\TestAudio\2024-05-16T06_52_30Z_guide.json");

            var EPG = JsonConvert.DeserializeObject<List<Schedule>>(json);

            int mike = 0;

            List<string> AllChannelIP = new List<string>();

            AllChannels.Clear();
           
            //parse for dict of channel/ecent
            foreach (Schedule item in EPG)
            {
                AllChannelIP.Add(item.address + ":" + " |" + item.serviceName);

                var Selected = (from channel in MasterChannelLst where IPAddress.Parse(channel.RTSPPath).Equals(IPAddress.Parse(item.address)) select channel);

                
                clsCarrier MyCarrier = new clsCarrier();
                MyCarrier.CarrierName = item.serviceName;   
                MyCarrier.CarrierIP = item.address;
                if (Selected.Count() > 0)
                {
                   MyCarrier.Carrier = Selected.First().Carrier.ToString();
                    MyCarrier.Region = Selected.First().Region.ToString();
                }
                Carriers.Add(MyCarrier);

                foreach (Eventsavailable SchEvent in item.eventsAvailable)
                {
                    clsScheduleEvents MyEvent = new clsScheduleEvents();
                    MyEvent.channelName = item.serviceName;
                    MyEvent.eventName = SchEvent.eventName;
                    MyEvent.eventText = SchEvent.eventText;
                    MyEvent.startTime = FromUnixTime((long)(SchEvent.startTime));
                    MyEvent.endTime = FromUnixTime((long)(SchEvent.endTime));
                    MyEvent.Carrier = MyCarrier.Carrier;
                    MyEvent.Region = MyCarrier.Region;

                    int dur = SchEvent.endTime - SchEvent.startTime;

                    TimeSpan test = new TimeSpan(SchEvent.startTime);

                    if (AllChannels.ContainsKey(item.address))
                    { AllChannels[item.address].Add(MyEvent); }
                    else
                    {
                        List<clsScheduleEvents> MySch = new List<clsScheduleEvents>();
                        MySch.Add(MyEvent);
                        AllChannels.Add(item.address, MySch);
                    }

                }
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("IP Adrr" + "\t" + "channelName" + "\t" + "Carrier" + "\t" + "Region" + "\t" + "Date" + "\t" + "eventName" + "\t" + "startTime" + "\t" +" endTime" + "\t" + "dur" + "\t" + "eventText");
            foreach (KeyValuePair<string, List<clsScheduleEvents>> kvp in AllChannels)
            {
                foreach (clsScheduleEvents item in kvp.Value.OrderBy(o => o.startTime))
                {
                    sb.AppendLine(kvp.Key + "\t" + item.GetEvent());
                }
            }

            string ans = sb.ToString(); 
            string channels = String.Join(Environment.NewLine, AllChannelIP);

            lueCarriers.Properties.DataSource = Carriers;

          
        }

        public static DateTime FromUnixTime(long unixTime)
        {
            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return epoch.AddSeconds(unixTime).ToLocalTime();
        }

        private void lueCarriers_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if(lueCarriers.EditValue != null)
            {
                gridControl1.DataSource = null;
                tbIP.Text = "";
                string CarrierIP = lueCarriers.EditValue.ToString();

                if(AllChannels.ContainsKey(CarrierIP) == true)
                {
                    List<clsScheduleEvents> MySch = AllChannels[CarrierIP];

                    gridControl1.DataSource = MySch;

                    tbIP.Text = CarrierIP;
                }
               
            }   
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://74f8mzxeya.execute-api.eu-west-2.amazonaws.com/get-file");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            // var jsonstring = File.ReadAllText(@"D:\TestAudio\FullMockChannelLst.json");

            MasterChannelLst = JsonConvert.DeserializeObject<BindingList<clsChannelData>>(responseBody);
        }
    }
}

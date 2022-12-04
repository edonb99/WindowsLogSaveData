using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
// using WcfServiceLibrary;
using System.ServiceModel;

namespace SaveData
{
    public partial class Service1 : ServiceBase
    {
        TransportData.Service1Client client;
        ServiceHost host;
        public Service1()
        {
            InitializeComponent();
        }
        /*
        protected override void OnStart(string[] args)
        {
            host = new ServiceHost(typeof(TransportData.Service1Client));
            host.Open();
            


        }*/
      protected void OnStart(string username1, string passwrod1)
        {
            host = new ServiceHost(typeof(TransportData.Service1Client));
            host.Open();
            
            string source = "Writing user info";
            EventLog systemEventLog = new EventLog("System");
            if (!EventLog.SourceExists(source))
            {
                EventLog.CreateEventSource(source, "System");
            }
            systemEventLog.Source = source;
            systemEventLog.WriteEntry("Username:" + username1 + "password:" + passwrod1, EventLogEntryType.Warning, 150);


        }
        protected void WriteIntoWinLog(string input1,string input2)
        {
            string source = "Writing user info";
            EventLog systemEventLog = new EventLog("System");
            if (!EventLog.SourceExists(source))
            {
                EventLog.CreateEventSource(source, "System");
            }
            systemEventLog.Source = source;
            systemEventLog.WriteEntry("Username:"+ input1 + "password:" + input2, EventLogEntryType.Warning, 150);
        }

        protected override void OnStop()
        {
            host.Close();
        }
        internal void TestStartupAndStop(string[] args)
        {
            this.OnStart(args);
            Console.ReadLine();
            this.OnStop();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Monitor_de_servidores
{
    internal class Server
    {
        public string IPAddress { get; internal set; }
        public int ID { get; internal set; }
        public string Name { get; internal set; }
        public ServerStatus Status { get; internal set; }
        public int CpuUsage { get; internal set; }
        public int MemoryUsage { get; internal set; }
        public DateTime LastCheck { get; internal set; }

        public enum ServerStatus
        {
            Online,
            Offline,
            Maintenance
        }

        public class Servers
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public ServerStatus Status { get; set; }
            public string IPAddress { get; set; }
            public double CpuUsage { get; set; }
            public double MemoryUsage { get; set; }
            public DateTime LastChecked { get; set; }


        }
        public event Action<Server>? OnAalert;


    }
}

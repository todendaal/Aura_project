using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aura_project.Models
{
    public class EmergencyModel
    {
        public int ID { get; set; }
        public DateTime EmergencyDate { get; set; }
        public int ClientID { get; set; }
        public float EmergencyLon { get; set; }
        public float EmergencyLat { get; set; }
        public int EmergencyStatusID { get; set; }
        public DateTime EmergencyClosedDate { get; set; }
        public string EmergencyAddress { get; set; }
    }
}
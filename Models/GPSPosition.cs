using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.SqlServer.Types;

namespace Aura_project.Models
{
    public class GPSPosition
    {
        public int ID { get; set; }
        public int PositionTypeID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Lat { get; set; }
        public float Lon { get; set; }
        //public SqlGeography Position;
        public string ContactNr { get; set; }
        public string ContactNrOther { get; set; }
        public string Email { get; set; }
        DateTime DateCreated { get; set; }
        public float Distance { get; set; }
    }
}
using Aura_project.Models;
using System;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Aura_project.DAL
{
    public class DAL_Emergency
    {
        string configName = System.Configuration.ConfigurationManager.ConnectionStrings["localDB"].ConnectionString;

        public int CreateEmergency(EmergencyModel newEmergency)
        {
            using (System.Data.IDbConnection connection = new System.Data.SqlClient.SqlConnection(configName))
            {
                var qry = "INSERT INTO ClientEmergency (EmergencyDate,ClientID,EmergencyLon,EmergencyLat,EmergencyAddress,EmergencyStatusID)";
                qry += " VALUES (GETDATE()," + newEmergency.ClientID + "," + newEmergency.EmergencyLon.ToString().Replace(",",".") + "," + newEmergency.EmergencyLat.ToString().Replace(",", ".") + ",'" + newEmergency.EmergencyAddress + "',1)";
                qry += " Select @@IDENTITY as NewID";
                var output = connection.Query<int>(qry);
                return output.First();
            }
        }
    }
}

//public int ID { get; set; }
//public DateTime EmergencyDate { get; set; }
//public int ClientID { get; set; }
//public float EmergencyLon { get; set; }
//public float EmergencyLat { get; set; }
//public int EmergencyStatusID { get; set; }
//public DateTime EmergencyClosedDate { get; set; }
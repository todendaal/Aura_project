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
    public class DAL_GPSPosition
    {
        string configName = System.Configuration.ConfigurationManager.ConnectionStrings["localDB"].ConnectionString;
        public List<GPSPosition> GetPolice(int TypeID, float lat, float lon)
        {
            using (System.Data.IDbConnection connection = new System.Data.SqlClient.SqlConnection(configName))
            {
                //string qry = $"Select * from Address Where ClientID={ClientID}";
                //if (AddressID != 0)
                //{
                //    qry = $"Select * from Address Where ClientID={ClientID} and ID={AddressID}";
                //}
                //var output = connection.Query<Address>(qry).ToList();
                // string qry = $"Select top 10 * from Geo_Position";
                string qry = $"sp_getPositionsClose @spLat=" + lat.ToString().Replace(",",".") + ", @spLon=" + lon.ToString().Replace(",", ".") + ",@type=" + TypeID.ToString();
                var output = connection.Query<GPSPosition>(qry).ToList();
                return output;
            }
        }

        public GPSPosition MovemoveChaser(int SecurityID, int EmergencyID)
        {
            using (System.Data.IDbConnection connection = new System.Data.SqlClient.SqlConnection(configName))
            {
                string qry = $"sp_MoveChaser @SecurityID=" + SecurityID.ToString() + ",@EmergencyID=" + EmergencyID.ToString();
                var output = connection.Query<GPSPosition>(qry);
                return output.First();
            }
        }

        public GPSPosition RandomPosition()
        {
            using (System.Data.IDbConnection connection = new System.Data.SqlClient.SqlConnection(configName))
            {
                string qry = $"sp_getRandomPosition";
                var output = connection.Query<GPSPosition>(qry);
                return output.First();
            }
        }
    }
}

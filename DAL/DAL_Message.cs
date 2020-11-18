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
    public class DAL_Message
    {
        string configName = System.Configuration.ConfigurationManager.ConnectionStrings["localDB"].ConnectionString;
        public bool AddMessage(int EmergencyID, int MessageTypeID, string Message)
        {
            using (System.Data.IDbConnection connection = new System.Data.SqlClient.SqlConnection(configName))
            {
                string qry = "Insert into ClientMessage (EmergencyID,MessageTypeID,MessageDate,Message) VALUES";
                qry += "(" + EmergencyID + "," + MessageTypeID + ",GETDATE(),'" + Message.Replace("'", "") + "')";
                var output = connection.Query<string>(qry);
                return true;
            }
        }

        public List<MessageModel> getMessages(int EmergencyID)
        {
            using (System.Data.IDbConnection connection = new System.Data.SqlClient.SqlConnection(configName))
            {
                string qry = $"Select * from ClientMessage where EmergencyID = " + EmergencyID;
                //string qry = $"sp_getPositionsClose @spLat=" + lat.ToString().Replace(",", ".") + ", @spLon=" + lon.ToString().Replace(",", ".") + ",@type=" + TypeID.ToString();
                var output = connection.Query<MessageModel>(qry).ToList();
                return output;
            }
        }
    }
}




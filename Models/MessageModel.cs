using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aura_project.Models
{
    public class MessageModel
    {
        public int ID {get; set;}
        public int EmergencyID {get; set;}
        public int MessageTypeID {get; set;}
        public DateTime MessageDate{ get; set; }
        public string Message { get; set; }
    }
}
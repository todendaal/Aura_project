using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aura_project.DAL;
using Aura_project.Models;

namespace Aura_project.Controllers
{
    public class MessageController : Controller
    {
        [HttpGet]
        // GET: Message/AddMessage
        public bool AddMessage(int EmergencyID, int MessageTypeID, string Message)
        {
            DAL.DAL_Message dl = new DAL.DAL_Message();
            dl.AddMessage(EmergencyID, MessageTypeID, Message);
            return true;
        }

        [HttpGet]
        // GET: Message/getMessages
        public JsonResult getMessages(int EmergencyID)
        {
            DAL_Message db = new DAL_Message();
            List<Models.MessageModel> MsgList = db.getMessages(EmergencyID);
            return Json(MsgList, JsonRequestBehavior.AllowGet);
        }
    }
}
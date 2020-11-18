using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aura_project.DAL;
using Aura_project.Models;

namespace Aura_project.Controllers
{
    public class PositionController : Controller
    {
        [HttpGet]
        // GET: Position/getPositions
        public JsonResult getPositions(int TypeID,float lat, float lon)
        {
            DAL_GPSPosition db = new DAL_GPSPosition();
            List<Models.GPSPosition> GPSList = db.GetPolice(TypeID,lat,lon);               
            return Json(GPSList, JsonRequestBehavior.AllowGet);
        }
   
        [HttpGet]
        // GET: Position/MoveChaser
        public JsonResult MoveChaser(int SecurityID, int EmergencyID)
        {
            DAL_GPSPosition db = new DAL_GPSPosition();
            Models.GPSPosition GPSList = db.MovemoveChaser(SecurityID, EmergencyID);
            return Json(GPSList, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        // GET: Position/RandomPosition
        public JsonResult RandomPosition()
        {
            DAL_GPSPosition db = new DAL_GPSPosition();
            Models.GPSPosition GPSList = db.RandomPosition();
            return Json(GPSList, JsonRequestBehavior.AllowGet);
        }
    }
}
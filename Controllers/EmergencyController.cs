﻿using Aura_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aura_project.Controllers
{
    public class EmergencyController : Controller
    {
        // GET: Emergency
        public ActionResult Index()
        {
            return View();
        }

        // GET: Emergency/Details/5
        public int SaveNewEmergency(int ClientID, float Lat, float Lng, string Address)
        {
            DAL.DAL_Emergency dl = new DAL.DAL_Emergency();
            EmergencyModel xModel = new EmergencyModel();
            xModel.ClientID = ClientID;
            xModel.EmergencyLat = Lat;
            xModel.EmergencyLon = Lng;
            xModel.EmergencyAddress = Address;
            int EmID = dl.CreateEmergency(xModel);
            return EmID;
        }

        // GET: Emergency/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Emergency/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Emergency/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Emergency/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Emergency/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Emergency/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

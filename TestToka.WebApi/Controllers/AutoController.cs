using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TestToka.Data;
using TestToka.Data.Core;
using TestToka.Data.Entities;

namespace TestToka.WebApi.Controllers
{
    public class AutoController : Controller
    {
        private TestTokaDbContext _ctx = new TestTokaDbContext();
        private AutosCore coreAuto;
        public AutoController()
        {
            if (coreAuto == null)
                coreAuto = new AutosCore(_ctx);
        }
        // GET: Autos
        public ActionResult Index()
        {
            return View(coreAuto.GetAll());
        }
        
        // POST: Auto/Create
        [HttpPost]
        public ActionResult Create(Auto auto)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", auto);
            }
            else
            {
                coreAuto.Create(auto);
                return RedirectToAction("Index");
            }

        }

        public ActionResult Edit(int id)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            return View(coreAuto.GetById(id));
        }

        [HttpPost]
        public ActionResult Edit(Auto auto)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit", auto);
            }
            else
            {
                coreAuto.Update(auto);
                return RedirectToAction("Index");
            }
        }
    }
}
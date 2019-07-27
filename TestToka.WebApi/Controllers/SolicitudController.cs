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
   
    public class SolicitudController : Controller
    {
        private CoreEntities core;
        private TestTokaDbContext _ctx = new TestTokaDbContext();
        private DetalleSolicitudCore coreDetail;
        private AutosCore coreAuto;
        public SolicitudController()
        {
            if(core == null)
                core = new CoreEntities(_ctx);
            if (coreDetail == null)
                coreDetail = new DetalleSolicitudCore(_ctx);
            if (coreAuto == null)
                coreAuto = new AutosCore(_ctx);

        }
        // GET: Solicitud
        public ActionResult Index()
        {           
            return View(core.GetAllRequests());
        }
        // GET: Solicutd/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: Solicitud/Create
        [HttpPost]
        public ActionResult Create(Solicitud solicitud)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", solicitud);
            }
            else
            {
                core.Create(solicitud);
                return RedirectToAction("Index");
            }
            
        }

        public ActionResult Details(int id)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            return View(coreDetail.GetListById(id));
        }

        public ActionResult AddDetail()
        {
            return View(coreAuto.GetAll());
        }


        [HttpPost]
        public ActionResult AddDetail(string ids)
        {
            var a = ids;
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            return View(core.GetById(id));
        }

        [HttpPost]
        public ActionResult Edit(Solicitud solicitud)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit", solicitud);
            }
            else
            {
                core.Update(solicitud);
                return RedirectToAction("Index");
            }
        }
        

        
    }
}
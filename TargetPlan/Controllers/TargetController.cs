using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TargetPlan.Models;
using System.Data.Entity;

namespace TargetPlan.Controllers
{
    public class TargetController : Controller
    {
        TargetContext db = new TargetContext();

        // GET: Target
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult add(Target target)
        {
            db.Targets.Add(target);
            db.SaveChanges();
            return View("Target");
        }

        public ActionResult update(Target target)
        {
            db.Entry(target).State = EntityState.Modified;
            db.SaveChanges();
            return View("Target");
        }

        public JsonResult GetData()
        {
            return Json(db.Targets, JsonRequestBehavior.AllowGet);
        }

        public ActionResult delete(Target target)
        {
            db.Targets.Attach(target);
            db.Targets.Remove(target);
            db.SaveChanges();

            return View("Target");
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RandomWordRecord.Models;

namespace RandomWordRecord.Controllers
{
    public class HomeController : Controller
    {
        RecordContext db = new RecordContext();

        public ActionResult Index()
        {
            IList<Record> records = db.Records.OrderBy(x => x.Id).Skip(Math.Max(0, db.Records.Count() - 3)).ToList();;

            ViewBag.Records = records;

            return View();
        }

        [HttpPost]
        public ActionResult Index([Bind(Include = "Id, Description")]Record record)
        {
            if (ModelState.IsValid)
            {
                db.Records.Add(record);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        
            return View(record);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using BLL;
using Datamodels1;

namespace MVC.Controllers
{
    public class classController : Controller
    {
        //
        // GET: /class/
        Class_studentEntities context = new Class_studentEntities();
        class2 rept=new class2();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult addclass(classviewmodel dept)
        {   bool X = rept.Add(dept);
        return Json("success", JsonRequestBehavior.AllowGet);
        }
        public ActionResult Dropdownlist()
        {
            IEnumerable<levelviewmodel> depts = rept.Dropdownlist();
            return Json(depts.ToList(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult getlevel()
        {
            IEnumerable<classviewmodel> depts = rept.GetAll();

            return Json(depts.ToList(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult Delet(int id)
        {
           var delet=rept.delet(id);
           return Json("success", JsonRequestBehavior.AllowGet);
        }
        public ActionResult Edit(int id)
        {
            
            classviewmodel dep = rept.getall(id);
            return Json(dep, JsonRequestBehavior.AllowGet);
        }
        public JsonResult updata(classviewmodel lev)
        {
            var depts = rept.updata(lev);
            return Json(depts, JsonRequestBehavior.AllowGet);
        }
	}
}
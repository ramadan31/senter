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
    public class AdminController : Controller
    {

        public ActionResult home()
        {
            return View();
        }

        public ActionResult adminlogin()
        {
         return View()  ;
        }
        public ActionResult adminlogin1(Adminviewmodel adim)
        {
            AdminRepositor rept = new AdminRepositor();
           bool check= rept.login(adim);
            if(check)
            return Json("success", JsonRequestBehavior.AllowGet);
            else
                return Json("error", JsonRequestBehavior.AllowGet);
        }
        public ActionResult level()
        {

            return View();
        }

        public ActionResult addlevel(levelviewmodel dept)
        {
            levels rept = new levels();
            rept.Add(dept);
            return Json("success", JsonRequestBehavior.AllowGet);
        }
        public ActionResult deletlevel(int id)
        {
            Class_studentEntities context = new Class_studentEntities();
            levels rept = new levels();
            var obj = context.Levels.FirstOrDefault(x =>x.level_id==id);
                       
                            context.Levels.Remove(obj);
                            context.SaveChanges();
                         
            return Json("success", JsonRequestBehavior.AllowGet);
        }
        public ActionResult Edit(int id)
        {
            levels rept = new levels();
            levelviewmodel dep = rept.GetByID(id);
          return Json(dep, JsonRequestBehavior.AllowGet);
        }
        public ActionResult getlevel(levelviewmodel dept)
        {
            levels rept = new levels();
            IEnumerable<levelviewmodel> depts = rept.GetAll();
            return Json(depts.ToList(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult updata(levelviewmodel lev)
        {levels rept = new levels();
        var depts = rept.updata(lev);
             return Json(depts, JsonRequestBehavior.AllowGet);
        }
	}
}
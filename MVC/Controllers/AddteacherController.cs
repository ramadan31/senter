using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using Datamodels1;
using BLL;

namespace MVC.Controllers
{
    public class AddteacherController : Controller
    {
        public ActionResult teachers()
        {
            return View();
        }
        teacher rept = new teacher();
        public JsonResult  Dropdownlist()
        {
            IEnumerable<levelviewmodel> depts = rept.Dropdownlist();
            return Json(depts.ToList(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult Addclass(teacherviewmodel dept)
        {
            bool x = rept.Add(dept);
            if (x)
            {

                return Json("success", JsonRequestBehavior.AllowGet);
            }else
            {
                return Json("error", JsonRequestBehavior.AllowGet);
            }
          
        }
        public JsonResult getclass()
        {
            IEnumerable<teacherviewmodel> depts = rept.GetAll();

            return Json(depts.ToList(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult getclasss()
        {
            return View();
        }
        public ActionResult deletteacher(int id)
        {
           bool x= rept.Delete(id);
           if (x)
           {
             return Json("success", JsonRequestBehavior.AllowGet);  
           }
           else
           {
               return Json("Error", JsonRequestBehavior.AllowGet);
           }
            
        }
        public JsonResult login(teacherviewmodel login)
        {
            bool log= rept.login(login);
            if (log)
            {
                Class_studentEntities context=new Class_studentEntities();
                var id = context.Teachers.Where(x => x.user_name == login.user_name && x.password == login.password).Select(x => x.id).FirstOrDefault();
                 return Json(id, JsonRequestBehavior.AllowGet);
            }else
            {
                return Json("error", JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult Detailsteacher(int id)
        {
            ViewBag.id = id;
            return View();
        }
        public ActionResult Edit(int id)
        {

            teacherviewmodel dep = rept.getall(id);
            return Json(dep, JsonRequestBehavior.AllowGet);
        }
        public ActionResult updata(teacherviewmodel th)
        {
            
            var depts = rept.updata(th);
            return Json(depts, JsonRequestBehavior.AllowGet);
        }
        public ActionResult changepassword(int id)
        {
            ViewBag.id = id;
            return View();
        }
        public JsonResult changepassword2(teacherviewmodel th)
        {
            bool log = rept.updatapassword(th);
            if (log)
            {
                return Json(log, JsonRequestBehavior.AllowGet);
                
            }
            else
            {
                return Json("error", JsonRequestBehavior.AllowGet);
            }
        }
	}
}
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
   
    public class StudentsController : Controller
    {
       
        public ActionResult changepassword(int id)
        {
            ViewBag.id = id;
            return View();
        }
        //
        // GET: /Students/
        studentRepository st = new studentRepository();
        public JsonResult changepassword2(studentviewmodel th)
        {
            bool log = st.updatapassword(th);
            if (log)
            {
                return Json(log, JsonRequestBehavior.AllowGet);

            }
            else
            {
                return Json("error", JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult Addstudent(studentviewmodel student)
        {
            bool check = st.Add(student);
            if (check)
                return Json("success", JsonRequestBehavior.AllowGet);
            else
                return Json("error", JsonRequestBehavior.AllowGet);
        }
        public ActionResult addStudentcomponent()
        {
            return View();
        }
        public ActionResult getlevel()
        {
            IEnumerable<levelviewmodel> depts = st.Dropdownlistlevel();
            return Json(depts.ToList(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult getclass()
        {
            IEnumerable<classviewmodel> depts = st.Dropdownlistclass();
            return Json(depts.ToList(), JsonRequestBehavior.AllowGet);
        }
        //public ActionResult getseat(int id)
        //{
        //    studentviewmodel stu = st.GetByID(id);
        //    return Json(stu, JsonRequestBehavior.AllowGet);
        //}
        public ActionResult getadmited(int id, int level_id)
        {
            studentviewmodel stu = st.Get(id, level_id);
            return Json(stu, JsonRequestBehavior.AllowGet);
        }
        public ActionResult AttendanceStudent()
        {
            return View();
        }
        public ActionResult attendance(int id, int level_id)
        {
         
            return Json(st.Attendanceselect(id,level_id), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Addattendance(Attendanceviewmodel att)
        {
            bool check = st.Addattendance(att);
            if (check)
                return Json("success", JsonRequestBehavior.AllowGet);
            else
                return Json("error", JsonRequestBehavior.AllowGet);
        }
        public ActionResult studentsReports_component()
        {
            return View();
        }
        public JsonResult getcount_of_student(int id, int level_id)
        {
            studentviewmodel stu = st.select_student(id, level_id);
            return Json(stu, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Getallstudent(int id, int level_id)
        {

            return Json(st.Getallstudent(id, level_id), JsonRequestBehavior.AllowGet);
        }
        public ActionResult DetailsStudent(int id)
        {
            ViewBag.id = id;

            return View();
        }
        public JsonResult login_student(studentviewmodel login)
        {
            bool log = st.loginstudent(login);
            if (log)
            {
                Class_studentEntities context = new Class_studentEntities();
                var id = context.Students.Where(x => x.username == login.username && x.password == login.password).Select(x => x.studentid).FirstOrDefault();
                return Json(id, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("error", JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult Edit_student(int id)
        {

            studentviewmodel dep = st.getstudent(id);
            return Json(dep, JsonRequestBehavior.AllowGet);
        }
        public JsonResult updata_student(studentviewmodel th)
        {

            var depts = st.updatastudent(th);
            return Json(depts, JsonRequestBehavior.AllowGet);
        }
        public JsonResult attendanceReport(int id, int level_id, string data_Attendance)
        {

            return Json(st.Getstudent(id, level_id,data_Attendance), JsonRequestBehavior.AllowGet);
        }
        public JsonResult getresult(int id, int level_id, string data_Attendance)
        {

            return Json(st.getresult(id, level_id, data_Attendance), JsonRequestBehavior.AllowGet);
        }
        public ActionResult attendanceReportstudent()
        {
            return View();
        }
        public ActionResult advanceAttReports_component()
        {
            return View();
        }
        public ActionResult getstudent(int level_id, int id)
        {
            IEnumerable<studentviewmodel> depts = st.Dropdownliststudent(level_id, id);
            return Json(depts.ToList(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult Getallstudents(int id, int level_id, int studentid)
        {
             IEnumerable<studentviewmodel> depts = st.Getallsstudent( id,level_id, studentid);
            return Json(depts.ToList(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult get_of_Result(int id, int level_id, int studentid)
        {

            return Json(st.Getsofresluts(id,level_id,studentid), JsonRequestBehavior.AllowGet);
        }
	}
}
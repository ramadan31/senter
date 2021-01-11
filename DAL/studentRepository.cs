using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Datamodels1;
using DAL;

namespace DAL
{

    interface Student1
    {
        bool updatapassword(studentviewmodel th);
        bool Add(studentviewmodel st);
        bool loginstudent(studentviewmodel st);
        bool Addattendance(Attendanceviewmodel st);
        IEnumerable<levelviewmodel> Dropdownlistlevel();
        IEnumerable<Attendanceviewmodel> Attendanceselect(int id, int level_id);
        IEnumerable<studentviewmodel> Getallstudent(int id, int level_id);
        IEnumerable<classviewmodel> Dropdownlistclass();
        IEnumerable<studentviewmodel> Dropdownliststudent(int levelid, int idclass);
        //studentviewmodel GetByID(int id);
        studentviewmodel Get(int id, int level_id);
        studentviewmodel getresult(int id, int level_id,string data_Attendance);
        studentviewmodel select_student(int id, int level_id);
        studentviewmodel getstudent(int id);
        bool updatastudent(studentviewmodel th);
        IEnumerable<studentviewmodel> Getstudent(int id, int level_id,string data_Attendance);
        IEnumerable<studentviewmodel> Getallsstudent(int id, int level_id, int studentid);
        studentviewmodel Getsofresluts(int id, int level_id, int studentid);


    }
   public class studentRepository:Student1
    {
       Class_studentEntities context = new Class_studentEntities();
       public bool updatapassword(studentviewmodel th)
       {
           try
           {
               var obj = context.Students.FirstOrDefault(x => x.studentid == th.studentid);
               if (obj != null)
               {

                   obj.password = th.newpassword;
                   if (th.newpassword == th.comfirm_password)
                   {
                       obj.comfirm_password = th.comfirm_password;
                       context.SaveChanges();
                       return true;

                   }
                   else
                   {
                       return false;
                   }

               }
               else
                   return false;
           }
           catch (Exception)
           {
               return false;
           }
       }
        public IEnumerable<levelviewmodel> Dropdownlistlevel()
        {
          List <levelviewmodel> obj=new List <levelviewmodel>();
            foreach (var item in context.Levels)
	         {
                 levelviewmodel leve = new levelviewmodel();
                 leve.level_id = item.level_id;
                 leve.leval_name = item.leval_name;
                 obj.Add(leve);
	         }
            return obj;
        }

        public IEnumerable<classviewmodel> Dropdownlistclass()
        {
            List<classviewmodel> obj = new List<classviewmodel>();
            foreach (var item in context.classes)
            {
                classviewmodel clas = new classviewmodel();
                clas.id = item.id;
                clas.class_name = item.class_name;
                obj.Add(clas);
            }
            return obj;
        }
        //public studentviewmodel GetByID(int id)
        //{
        //    var set = context.classes.FirstOrDefault(x => x.id == id);
        //    studentviewmodel obj = new studentviewmodel();
        //    obj.seat = set.seat;
        //    return obj;
        //}

        public studentviewmodel Get(int id, int level_id)
        {
            try
            {
                var set = context.Students.Where(x => x.id == id && x.level_id == level_id).Count();
                var sea = context.classes.FirstOrDefault(x => x.id == id && x.level_id == level_id);
                studentviewmodel obj = new studentviewmodel();
                obj.admitted = set;
                obj.seat = sea.seat;
                obj.Remaining = sea.seat - set;
                if (obj.Remaining > 0)
                {
                    return obj;
                }
                else
                {
                    obj.Remaining = -(sea.seat - set);
                    return obj;
                }
            
          
            }
            catch (Exception)
            {

                studentviewmodel obj = new studentviewmodel();
                obj.admitted =0 ;
                obj.seat = 0;
                obj.Remaining = 0;
                return obj;
            }
          
        }

        public bool Add(studentviewmodel st)
        {
            try
            {
                if (st!=null)
                {
                    Student obj = new Student();
                    obj.student_name = st.student_name;
                    obj.mobile = st.mobile;
                    obj.address = st.address;
                    var emil = context.Students.FirstOrDefault(x=>x.Email==st.Email);
                    var teach = context.Teachers.FirstOrDefault(x => x.leval_id == st.level_id);
                    var em = context.Students.FirstOrDefault(x =>x.Email==x.Email);
                    if (emil == null)

                    {
                        obj.attendanceid = em.attendanceid;
                        obj.idi = teach.id; ;
                        obj.Email = st.Email;
                        obj.city = st.city;
                        obj.username = st.username;
                        obj.password = st.password;
                        obj.id = st.id;
                        obj.level_id = st.level_id;
                        obj.student_data = st.student_data;
                        obj.comfirm_password = st.comfirm_password;
                        if (st.password==st.comfirm_password)
                        {
                            context.Students.Add(obj);
                            context.SaveChanges();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                   
                }
                else
                {
                    return false;
                }
              
            }
            catch (Exception)
            {

                return false;
            }
        }


        public IEnumerable<Attendanceviewmodel> Attendanceselect(int id, int level_id)
        {
            List<Attendanceviewmodel> s = new List<Attendanceviewmodel>();
            foreach (var item in context.Students.Where(x => x.id == id && x.level_id == level_id))
            {
                //var obj = context.Students.FirstOrDefault(x => x.id == id && x.level_id == level_id);

                Attendanceviewmodel att = new Attendanceviewmodel();
                att.student_name = item.student_name;
                att.studentid = item.studentid;
                s.Add(att);
                
            }
            return s;
           
                
            
         
        }
        public bool Addattendance(Attendanceviewmodel st)
        {
            try
            {
                if (st!=null)
                {
                    Attendance obj = new Attendance();
                    obj.student_name = st.student_name;
                    obj.data_Attendance = st.data_Attendance;
                    obj.Attendance1 = st.Attendance1;
                    obj.studentid = st.studentid;
                    context.Attendances.Add(obj);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
           
        }
       // select of the students 
        public studentviewmodel select_student(int id, int level_id)
        {
            var student = context.Students.Where(x => x.id == id && x.level_id == level_id).Count();
            studentviewmodel obj = new studentviewmodel();
            obj.count = student;
            return obj;


        }


        public IEnumerable<studentviewmodel> Getallstudent(int id, int level_id)
        {

            List<studentviewmodel> s = new List<studentviewmodel>();
            foreach (var item in context.Students.Where(x => x.id == id && x.level_id == level_id))
            {

                studentviewmodel student = new studentviewmodel();
              student.student_name = item.student_name;
              student.student_data = item.student_data;
               student.mobile = item.mobile;
               student.Email = item.Email;
                s.Add(student);

            }
            return s;
        }


        public bool loginstudent(studentviewmodel st)
        {
            try
            {
                var student = context.Students.Where(x => x.username == st.username && x.password == st.password).Select(x=>x.studentid).FirstOrDefault();
                if (student==0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
                

            }
            catch (Exception)
            {

                return false;
            }
           
        }


        public studentviewmodel getstudent(int id)
        {
            var dept = context.Students.FirstOrDefault(x => x.studentid == id);
            studentviewmodel obj = new studentviewmodel();
            obj.Email = dept.Email;
            obj.address = dept.address;
            obj.city = dept.city;
            obj.mobile = dept.mobile;
            obj.photo = dept.photo;

            return obj;

        }

        public bool updatastudent(studentviewmodel th)
        {
            try
            {
                var obj = context.Students.FirstOrDefault(x => x.studentid == th.studentid);
                if (obj != null)
                {
                    obj.Email = th.Email;
                    obj.address = th.address;
                    obj.city = th.city;
                    obj.mobile = th.mobile;
                    obj.photo = th.photo;
                    context.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<studentviewmodel> Getstudent(int id, int level_id,string data_Attendance )
        {
           
            List<studentviewmodel> s = new List<studentviewmodel>();
            foreach (var item in context.Students.Where(x => x.id == id && x.level_id == level_id && x.student_data == data_Attendance))
            {
                var ss = 1;
                studentviewmodel student = new studentviewmodel();
               
                var studen = context.Attendances.FirstOrDefault(x=>x.data_Attendance==data_Attendance);
                student.attendance1= studen.Attendance1;
                student.student_name = item.student_name;
                student.student_data = item.student_data;
                student.teacher_name = item.Teacher.teacher_name;
                if (student.attendance1 == ss.ToString())
                {
                    student.attendance1 = "Absent";
                }
                else
                {
                    student.attendance1 = "Leave";
                }
                s.Add(student);

            }
            return s;
        }


        public studentviewmodel getresult(int id, int level_id, string data_Attendance)
        {  studentviewmodel obj = new studentviewmodel();
            try
            {
                 var result = context.Students.Where(x => x.id == id && x.level_id == level_id && x.student_data == data_Attendance).Count();
          
            obj.result = result;
                return obj;

            }
            catch (Exception)
            {
                 obj.result=0;
                 return obj;
            }
           
        }


        public IEnumerable<studentviewmodel> Dropdownliststudent(int level_id, int id)
        {
            if (level_id == -1 && id == -1)
            {
                List<studentviewmodel> obj = new List<studentviewmodel>();
                foreach (var item in context.Students)
                {
                    studentviewmodel stu = new studentviewmodel();
                    stu.studentid = item.studentid;
                    stu.student_name = item.student_name;
                    obj.Add(stu);
                }
                return obj;
            }
            else if (id==-1)
            {
                List<studentviewmodel> obj = new List<studentviewmodel>();
                foreach (var item in context.Students.Where(x => x.level_id == level_id))
                {
                    studentviewmodel stu = new studentviewmodel();
                    stu.studentid = item.studentid;
                    stu.student_name = item.student_name;
                    obj.Add(stu);
                }
                return obj;
            }
            else if (level_id == -1)
            {
                List<studentviewmodel> obj = new List<studentviewmodel>();
                foreach (var item in context.Students.Where(x => x.id == id))
                {
                    studentviewmodel stu = new studentviewmodel();
                    stu.studentid = item.studentid;
                    stu.student_name = item.student_name;
                    obj.Add(stu);
                }
                return obj;
            }
            else
            {
                List<studentviewmodel> obj = new List<studentviewmodel>();
                foreach (var item in context.Students.Where(x => x.id == id && x.level_id == level_id))
                {
                    studentviewmodel stu = new studentviewmodel();
                    stu.studentid = item.studentid;
                    stu.student_name = item.student_name;
                    obj.Add(stu);
                }
                return obj;
            }
           
        }


        public IEnumerable<studentviewmodel> Getallsstudent(int id, int level_id, int studentid)
        {
            var std = context.Students.Where(x => x.studentid == studentid).Select(x => x.student_name).FirstOrDefault();
            if (level_id == -1 && id == -1 && studentid==-1)
            {
                List<studentviewmodel> obj = new List<studentviewmodel>();
                foreach (var item in context.Students)
                {
                    var ss = 1;
                    studentviewmodel student = new studentviewmodel();
               
                    student.attendance1 = item.Attendance.Attendance1; 
                    student.student_name = item.student_name;
                    student.student_data = item.student_data;
                    student.teacher_name = item.Teacher.teacher_name;
                    if (student.attendance1 == ss.ToString())
                    {
                        student.attendance1 = "Absent";
                    }
                    else
                    {
                        student.attendance1 = "Leave";
                    }
                    obj.Add(student);
                }
                return obj;
            }
            else if (id == -1 && level_id==-1)
            {
               
                List<studentviewmodel> obj = new List<studentviewmodel>();
                foreach (var item in context.Students.Where(x => x.student_name == std))
                {
                    var ss = 1;
                    studentviewmodel student = new studentviewmodel();

              
                    student.attendance1 = item.Attendance.Attendance1; 
                    student.student_name = item.student_name;
                    student.student_data = item.student_data;
                    student.teacher_name = item.Teacher.teacher_name;
                    if (student.attendance1 == ss.ToString())
                    {
                        student.attendance1 = "Absent";
                    }
                    else
                    {
                        student.attendance1 = "Leave";
                    }
                    obj.Add(student);
                }
                return obj;
            }
            else if (id == -1 && studentid == -1)
            {
                List<studentviewmodel> obj = new List<studentviewmodel>();
                foreach (var item in context.Students.Where(x => x.level_id == level_id))
                {
                    var ss = 1;
                    studentviewmodel student = new studentviewmodel();

                    
                    student.attendance1 = item.Attendance.Attendance1;
                    student.student_name = item.student_name;
                    student.student_data = item.student_data;
                    student.teacher_name = item.Teacher.teacher_name;
                    if (student.attendance1 == ss.ToString())
                    {
                        student.attendance1 = "Absent";
                    }
                    else
                    {
                        student.attendance1 = "Leave";
                    }
                    obj.Add(student);
                }
                return obj;
            }
            else if (level_id == -1)
            {
                List<studentviewmodel> obj = new List<studentviewmodel>();
                foreach (var item in context.Students.Where(x => x.id == id && x.student_name == std))
                {
                    var ss = 1;
                    studentviewmodel student = new studentviewmodel();

             
                    student.attendance1 = item.Attendance.Attendance1;
                    student.student_name = item.student_name;
                    student.student_data = item.student_data;
                    student.teacher_name = item.Teacher.teacher_name;
                    if (student.attendance1 == ss.ToString())
                    {
                        student.attendance1 = "Absent";
                    }
                    else
                    {
                        student.attendance1 = "Leave";
                    }
                    obj.Add(student);
                }
                return obj;
            }
            else if (id == -1)
            {
                List<studentviewmodel> obj = new List<studentviewmodel>();
                foreach (var item in context.Students.Where(x => x.level_id == level_id && x.student_name == std))
                {
                    var ss = 1;
                    studentviewmodel student = new studentviewmodel();

       
                    student.attendance1 = item.Attendance.Attendance1;
                    student.student_name = item.student_name;
                    student.student_data = item.student_data;
                    student.teacher_name = item.Teacher.teacher_name;
                    if (student.attendance1 == ss.ToString())
                    {
                        student.attendance1 = "Absent";
                    }
                    else
                    {
                        student.attendance1 = "Leave";
                    }
                    obj.Add(student);
                }
                return obj;
            }
            else
            {
                List<studentviewmodel> obj = new List<studentviewmodel>();
                foreach (var item in context.Students.Where(x => x.id == id && x.level_id == level_id && x.student_name == std))
                {
                    var ss = 1;
                    studentviewmodel student = new studentviewmodel();           
                    student.attendance1 = item.Attendance.Attendance1;
                    student.student_name = item.student_name;
                    student.student_data = item.student_data;
                    student.teacher_name = item.Teacher.teacher_name;
                    if (student.attendance1 == ss.ToString())
                    {
                        student.attendance1 = "Absent";
                    }
                    else
                    {
                        student.attendance1 = "Leave";
                    }
                    obj.Add(student);
                }
                return obj;
            }
        }

        public studentviewmodel Getsofresluts(int id, int level_id, int studentid)
        {
            studentviewmodel obj = new studentviewmodel();
            try
            {
                var std = context.Students.Where(x => x.studentid == studentid).Select(x => x.student_name).FirstOrDefault();
                if (id == -1 && level_id == -1 && studentid==-1)
                {
                    var result = context.Students.Count();
                    obj.result1 = result;
                    return obj;
                }
                else if (id == -1 && level_id == -1)
                {

                    var result = context.Students.Where(x => x.student_name == std).Count();

                    obj.result1 = result;
                    return obj;
                }
                else if (id == -1 && studentid == -1)
                {

                    var result = context.Students.Where(x => x.level_id == level_id).Count();

                    obj.result1 = result;
                    return obj;
                }
                else if (level_id == -1)
                {
		           var result = context.Students.Where(x => x.id == id &&  x.student_name == std).Count();
                obj.result1 = result;
                return obj;
	           }
                else if (id == -1)
                {
                    var result = context.Students.Where(x => x.level_id == level_id && x.student_name == std).Count();
                    obj.result1 = result;
                    return obj;
                }
                else
	          {
                  var result = context.Students.Where(x => x.id == id && x.level_id == level_id && x.student_name == std).Count();

                obj.result1 = result;
                return obj;
	          }
               

            }
            catch (Exception)
            {
                obj.result1 = 0;
                return obj;
            }
           
        }
    } 
    
}

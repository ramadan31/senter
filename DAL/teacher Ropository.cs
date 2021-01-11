using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Datamodels1;

namespace DAL
{
    interface teacher1
    {
     
        bool Add(teacherviewmodel dept);
        bool login(teacherviewmodel dept);
        IEnumerable<levelviewmodel> Dropdownlist();
        IEnumerable<teacherviewmodel> GetAll();
        teacherviewmodel getall(int id);
        bool Delete(int id);
        bool updatapassword(teacherviewmodel th);
        bool updata(teacherviewmodel th);
    }
    public class teacher : teacher1
    {
        Class_studentEntities context = new Class_studentEntities();
        public bool Add(teacherviewmodel dept)
        {
            try
            {
                Teacher dd = new Teacher();
                dd.teacher_name = dept.teacher_name;
                dd.id = dept.id;
                dd.addres = dept.addres;
                dd.cender = dept.cender;
                dd.city = dept.city;
                dd.user_name = dept.user_name;
                dd.Email = dept.Email;
                dd.leval_id = dept.leval_id;
                dd.mobile = dept.mobile;
                dd.password = dept.password;
                dd.comfer_password = dept.comfer_password;
                var old = context.Teachers.FirstOrDefault(x => x.password == dept.comfer_password);
                if (old != null)
                {
                    context.Teachers.Add(dd);
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
        public bool login(teacherviewmodel adim)
        {
            Class_studentEntities dd = new Class_studentEntities();
            if (adim != null)
            {
                var old = dd.Teachers.Where(x => x.user_name == adim.user_name && x.password == adim.password).Select(x=>x.id).FirstOrDefault();
                if (old != null)
                {
                   
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
        public IEnumerable<levelviewmodel> Dropdownlist()
        {
            List<levelviewmodel> obj = new List<levelviewmodel>();
            foreach (var item in context.Levels)
            {
                levelviewmodel dept = new levelviewmodel();
                dept.level_id = item.level_id;
                dept.leval_name = item.leval_name;
                obj.Add(dept);

            }
            return obj;
        }
        public IEnumerable<teacherviewmodel> GetAll()
        {
            List<teacherviewmodel> obj = new List<teacherviewmodel>();
            foreach (var item in context.Teachers)
            {
                teacherviewmodel dd = new teacherviewmodel();
                dd.teacher_name = item.teacher_name;
                dd.addres = item.addres;
                dd.cender = item.cender;
                dd.id = item.id;
                dd.city = item.city;
                dd.user_name = item.user_name;
                dd.Email = item.Email;
                dd.leval_id = item.leval_id;
                dd.mobile = item.mobile;
                dd.password = item.password;
                dd.comfer_password = item.comfer_password;
                obj.Add(dd);

            }
            return obj;
        }
        public teacherviewmodel getall(int id)
        {
            var dept = context.Teachers.FirstOrDefault(x => x.id == id);
            teacherviewmodel obj = new teacherviewmodel();
            obj.id = dept.id;
            obj.Email = dept.Email;
            obj.addres = dept.addres ;
            obj.city = dept.city;
            obj.mobile = dept.mobile;
            obj.photo = dept.photo;

            return obj;


        }
        public bool Delete(int id)
        {
            try
            {
                var obj = context.Teachers.FirstOrDefault(X => X.id == id);
                if (obj != null)
                {
                    context.Teachers.Remove(obj);
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
        public bool updata(teacherviewmodel dept)
        {
            try
            {
                var obj = context.Teachers.FirstOrDefault(x => x.id== dept.id);
                if (obj != null)
                {
                    obj.Email = dept.Email;
                    obj.addres = dept.addres;
                    obj.city = dept.city;
                    obj.mobile = dept.mobile;
                    obj.photo = dept.photo;
                    obj.id = dept.id;
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

        
        public bool updatapassword(teacherviewmodel th)
        {
           try
            {
                var obj = context.Teachers.FirstOrDefault(x=>x.id==th.id);
                if (obj != null)
                {
                   
                    obj.password = th.newpassword;
                    if (th.newpassword == th.comfer_password)
                    {
                        obj.comfer_password = th.comfer_password;
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
        }
    }

   


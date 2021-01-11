using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

using Datamodels1;

namespace DAL
{
    interface class1
    {
        bool Add(classviewmodel dept);
        bool delet(int id);
        bool updata(classviewmodel dept);
       classviewmodel getall(int id);
       IEnumerable<classviewmodel> GetAll();
       IEnumerable<levelviewmodel> Dropdownlist();

    }
    public class class2 : class1
    {
        Class_studentEntities context = new Class_studentEntities();
        public bool Add(classviewmodel dept)
        {
        
            @class obj = new @class();
            if (dept!=null)
            {
                obj.class_name = dept.class_name;
                obj.seat = dept.seat;
                obj.level_id = dept.level_id;
                context.classes.Add(obj);
                context.SaveChanges();
                return true;
                
            }
            else
            {
                return false;
            }
           
           
        }

        public bool delet(int id)
        {  try
            {
                if(id > 0)
                {
                    var obj = context.classes.FirstOrDefault(x => x.id == id);
                    if (obj != null)
                    {
                        context.classes.Remove(obj);
                        context.SaveChanges();
                        return true;
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
            }
            

        public bool updata(classviewmodel dept)
        {
            try
            {
                var obj = context.classes.FirstOrDefault(x => x.id== dept.id);
                if (obj != null)
                {
                    obj.id = dept.id;
                    obj.class_name = dept.class_name;
                    obj.seat = dept.seat;
                    obj.level_id = dept.level_id;
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

        public classviewmodel getall(int id)
        {
                var dept = context.classes.FirstOrDefault(x => x.id == id);
                classviewmodel obj = new classviewmodel();
                obj.id = dept.id;
                obj.class_name = dept.class_name;
                obj.level_id = dept.level_id; ;
                obj.seat = dept.seat;
                
                return obj;
            
           
        }

        public IEnumerable<classviewmodel> GetAll()
        {
            List<classviewmodel> obj = new List<classviewmodel>();
            foreach (var item in context.classes)
            {
                classviewmodel dept = new classviewmodel();
                dept.class_name = item.class_name;
                dept.id = item.id;
                dept.LevelName= item.Level.leval_name;
                dept.seat = item.seat;
                obj.Add(dept);

            }
            return obj;
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

    }

}

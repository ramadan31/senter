using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datamodels1;
using BLL;

namespace DAL
{
 
        interface level2
        {
            bool Add(levelviewmodel dept);
            levelviewmodel GetByID(int id);
            bool Delet2(int id);
            bool updata(levelviewmodel dept);
            IEnumerable<levelviewmodel> GetAll();
        }
        public class levels : level2
        {
            Class_studentEntities context = new Class_studentEntities();
            public bool Add(levelviewmodel dept)
            {
               
                    Level obj = new Level();
                    obj.leval_name = dept.leval_name;
                    context.Levels.Add(obj);
                    context.SaveChanges();
                    return true;
                
              

            }

            public levelviewmodel GetByID(int id)
            {
               var dept = context.Levels.FirstOrDefault(x => x.level_id == id);
               levelviewmodel obj = new levelviewmodel();
                obj.leval_name= dept.leval_name;
                obj.level_id = dept.level_id;
                return obj;
            }

            public bool Delet2(int id)
            {
                try
                {
                    if (id > 0)
                    {
                        
                        var obj = context.Levels.FirstOrDefault(x =>x.level_id==id);
                        if (obj != null)
                        {
                            context.Levels.Remove(obj);
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

            public IEnumerable<levelviewmodel> GetAll()
            {
                List<levelviewmodel> depts = new List<levelviewmodel>();
                foreach (var item in context.Levels)
                {
                    levelviewmodel obj = new levelviewmodel();
                    obj.level_id= item.level_id;
                    obj.leval_name = item.leval_name;
                    depts.Add(obj);
                }
                return depts;
            }

            public bool updata(levelviewmodel dept)
            {
                try
                {
                    var obj = context.Levels.FirstOrDefault(x=>x.level_id == dept.level_id);
                    if (obj != null)
                    {
                        obj.leval_name=dept.leval_name;
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

        }

}



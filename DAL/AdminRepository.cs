using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Datamodels1;



namespace DAL
{
    interface IAdminRepository{
        bool login(Adminviewmodel adim);
    }
   public  class AdminRepositor : IAdminRepository
    {
        public bool login(Adminviewmodel adim)
        {
            Class_studentEntities dd = new Class_studentEntities();
        if (adim!=null)
       {
            var old = dd.Admins.FirstOrDefault(x=> x.name==adim.name&&x.password==adim.password);
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

    }

  
}

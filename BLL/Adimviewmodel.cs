using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BLL
{
   public class Adminviewmodel
    {[Key]
        public int id { get; set; }
         [Display(Name = "Name")]
         [Required(ErrorMessage = " name is required!")]
        public string name { get; set; }
          [Required(ErrorMessage = "password is required!")]
          [Display(Name = "Password")]
    public Nullable<int> password { get; set; }
    
    }
}

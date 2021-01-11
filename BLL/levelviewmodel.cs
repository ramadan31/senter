using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Datamodels1;

namespace BLL
{
    public class levelviewmodel
    {
       [Required(ErrorMessage = "level name is required!")]
        public string leval_name { get; set; }
          [Required(ErrorMessage = "id is required!")]
        [Key]
        public int level_id { get; set; }
        
      
    }
}

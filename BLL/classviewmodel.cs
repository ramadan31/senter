using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Datamodels1;


namespace BLL
{
    public class classviewmodel
    {
        [Key]
        [Required(ErrorMessage = "class name is required!")]
        public string class_name { get; set; }

        public int id { get; set; }
        [Required(ErrorMessage = "seat is required!")]
        public int seat { get; set; }
        public int level_id { get; set; }

        public string LevelName { get; set; }

    }
}

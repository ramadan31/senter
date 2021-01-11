using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Datamodels1;


namespace BLL
{
    public class teacherviewmodel
    {
        [Required(ErrorMessage = "teacher_name  is required!")]
        public string teacher_name { get; set; }
        [Required(ErrorMessage = " Email is required!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "mobile  is required!")]
        public Nullable<int> mobile { get; set; }
        [Required(ErrorMessage = "addres is required!")]
        public string addres { get; set; }
        [Required(ErrorMessage = "city required!")]
        public string city { get; set; }
        [Required(ErrorMessage = "cender is required!")]
        public string cender { get; set; }
        [Required(ErrorMessage = "photo is required!")]
        public byte[] photo { get; set; }
        [Required(ErrorMessage = "user_name is required!")]
        public string user_name { get; set; }
        [Required(ErrorMessage = "passwordis required!")]
        public Nullable<int> password { get; set; }
        public Nullable<int> newpassword { get; set; }   
        [Required(ErrorMessage = "comfer_password is required!")]
        public Nullable<int> comfer_password { get; set; }
        public Nullable<int> leval_id { get; set; }
        [Key]
        public int id { get; set; }

        public virtual Level Level { get; set; }
    }
}

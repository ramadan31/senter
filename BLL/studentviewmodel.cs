using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datamodels1;

namespace BLL
{
  public class studentviewmodel
  {
      public Nullable<int> newpassword { get; set; } 
        public string student_name { get; set; }
        public int seat { get; set; }
        public int result { get; set; }
        public int result1 { get; set; }
        public int count { get; set; }
        public Nullable<int> attendanceid { get; set; }
        public virtual Attendance Attendance { get; set; }
        public int Remaining { get; set; }
        public int admitted{ get; set; }
        public string student_data { get; set; }
        public int studentid { get; set; }
        public string Email { get; set; }
        public Nullable<int> mobile { get; set; }
        public Nullable<int> age { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string username { get; set; }
        public Nullable<int> password { get; set; }
        public Nullable<int> comfirm_password { get; set; }
        public byte[] photo { get; set; }
        public string attendance1 { get; set; }
        public string teacher_name { get; set; }
        public Nullable<int> level_id { get; set; }
        public Nullable<int> id { get; set; }

        public virtual @class @class { get; set; }
        public virtual Level Level { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datamodels1;

namespace BLL
{
   public class Attendanceviewmodel
    {
        public Nullable<int> studentid { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public int attendanceid { get; set; }
        public string Attendance1 { get; set; }
        public string student_name { get; set; }
        public string data_Attendance { get; set; }

        public virtual Student Student { get; set; }
    }
}

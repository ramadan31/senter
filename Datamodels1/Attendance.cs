//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datamodels1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Attendance
    {
        public Attendance()
        {
            this.Students = new HashSet<Student>();
        }
    
        public Nullable<int> studentid { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public int attendanceid { get; set; }
        public string Attendance1 { get; set; }
        public string student_name { get; set; }
        public string data_Attendance { get; set; }
    
        public virtual Student Student { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}

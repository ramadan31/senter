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
    
    public partial class Teacher
    {
        public Teacher()
        {
            this.Students = new HashSet<Student>();
        }
    
        public string teacher_name { get; set; }
        public string Email { get; set; }
        public Nullable<int> mobile { get; set; }
        public string addres { get; set; }
        public string city { get; set; }
        public string cender { get; set; }
        public byte[] photo { get; set; }
        public string user_name { get; set; }
        public Nullable<int> password { get; set; }
        public Nullable<int> comfer_password { get; set; }
        public Nullable<int> leval_id { get; set; }
        public int id { get; set; }
    
        public virtual Level Level { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}

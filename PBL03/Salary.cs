//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PBL03
{
    using System;
    using System.Collections.Generic;
    
    public partial class Salary
    {
        public string ID_Salary { get; set; }
        public string IDEmployee { get; set; }
        public int IDSchedule { get; set; }
        public float SalaryBasic { get; set; }
        public float WorkingHours { get; set; }
        public float SalaryTotal { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual WorkSchedule WorkSchedule { get; set; }
    }
}

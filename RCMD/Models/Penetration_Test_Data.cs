//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RCMD.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Penetration_Test_Data
    {
        public int ID { get; set; }
        public Nullable<decimal> Ring_Factor { get; set; }
        public Nullable<decimal> Penetration { get; set; }
        public Nullable<decimal> No_Of_Blows { get; set; }
        public Nullable<decimal> Dialrdg { get; set; }
        public Nullable<decimal> Penetration_Load { get; set; }
        public Nullable<decimal> Cor_Load { get; set; }
        public Nullable<decimal> CBR { get; set; }
        public Nullable<decimal> RDG_Before_Soaking { get; set; }
        public Nullable<decimal> RDG_After_Soaking { get; set; }
        public Nullable<decimal> Percent_Swell { get; set; }
        public Nullable<decimal> Average_Percent_Swell { get; set; }
        public string Unit { get; set; }
        public Nullable<decimal> Blow_No { get; set; }
        public Nullable<int> Material_Description_ID { get; set; }
    
        public virtual Material_Description Material_Description { get; set; }
    }
}
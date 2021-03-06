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
    
    public partial class Moisture_Determination
    {
        public int ID { get; set; }
        public Nullable<int> Material_Determination_No { get; set; }
        public string Soaking_Condition { get; set; }
        public string Container_Type { get; set; }
        public string Container_No { get; set; }
        public Nullable<decimal> Wet_Soil_Plus_Container { get; set; }
        public Nullable<decimal> Dry_Soil_Plus_Container { get; set; }
        public Nullable<decimal> Weight_Of_Water { get; set; }
        public Nullable<decimal> Weight_Of_Container { get; set; }
        public Nullable<decimal> Weight_of_Dry_Soil { get; set; }
        public Nullable<decimal> Moisture_Content { get; set; }
        public Nullable<decimal> AVG_Moisture_Content { get; set; }
    
        public virtual Material_Description Material_Description { get; set; }
    }
}

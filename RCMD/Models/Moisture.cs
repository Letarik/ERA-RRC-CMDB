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
    
    public partial class Moisture
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Moisture()
        {
            this.Density_Determination = new HashSet<Density_Determination>();
        }
    
        public int ID { get; set; }
        public Nullable<int> Density_ID { get; set; }
        public string Container_No { get; set; }
        public string Wet_Soil_Container { get; set; }
        public string Dry_Soil_Container { get; set; }
        public string Weight_of_Water { get; set; }
        public string Weight_of_Container { get; set; }
        public string Weight_of_Dry_Soil { get; set; }
        public string Moisture_Content { get; set; }
        public Nullable<decimal> OMC { get; set; }
        public string Remark { get; set; }
        public Nullable<int> Material_Description_ID { get; set; }
    
        public virtual Density Density { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Density_Determination> Density_Determination { get; set; }
        public virtual Material_Description Material_Description { get; set; }
    }
}

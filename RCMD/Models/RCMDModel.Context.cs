﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NRCMDBEntities : DbContext
    {
        public NRCMDBEntities()
            : base("name=NRCMDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Density> Densities { get; set; }
        public virtual DbSet<Density_Determination> Density_Determination { get; set; }
        public virtual DbSet<Determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine> Determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine { get; set; }
        public virtual DbSet<Material_Description> Material_Description { get; set; }
        public virtual DbSet<Moisture> Moistures { get; set; }
        public virtual DbSet<Particle_Size_Distribution> Particle_Size_Distribution { get; set; }
        public virtual DbSet<Penetration_Test_Data> Penetration_Test_Data { get; set; }
        public virtual DbSet<Determination_Of_Flakiness_Index> Determination_Of_Flakiness_Index { get; set; }
        public virtual DbSet<Moisture_Determination> Moisture_Determination { get; set; }
        public virtual DbSet<Aggregate_Crushing_Value_Test> Aggregate_Crushing_Value_Test { get; set; }
        public virtual DbSet<Ten_Percent_Fines_Value> Ten_Percent_Fines_Value { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Determination_OF_LL_PL> Determination_OF_LL_PL { get; set; }
        public virtual DbSet<Summary_Report> Summary_Report { get; set; }
        public virtual DbSet<Summary_Report_View> Summary_Report_View { get; set; }
        public virtual DbSet<Determination_0f_LL_PL_End_Resutl_View> Determination_0f_LL_PL_End_Resutl_View { get; set; }
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp11
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Clinic2Entities : DbContext
    {
        public Clinic2Entities()
            : base("name=Clinic2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Appointments> Appointments { get; set; }
        public virtual DbSet<Doctors> Doctors { get; set; }
        public virtual DbSet<Patients> Patients { get; set; }
        public virtual DbSet<AppointmentsView> AppointmentsView { get; set; }
        public virtual DbSet<DoctorsView> DoctorsView { get; set; }
        public virtual DbSet<PatientsView> PatientsView { get; set; }
        public virtual DbSet<DoctorsView2> DoctorsView2 { get; set; }
        public virtual DbSet<PatientsView2> PatientsView2 { get; set; }
    }
}

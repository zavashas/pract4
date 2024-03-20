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
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Clinic3Entities : DbContext
    {
        public Clinic3Entities()
            : base("name=Clinic3Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Appointments> Appointments { get; set; }
        public virtual DbSet<Doctors> Doctors { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Patients> Patients { get; set; }
        public virtual DbSet<Specializations> Specializations { get; set; }
        public virtual DbSet<AppointmentsView> AppointmentsView { get; set; }
        public virtual DbSet<DoctorsView> DoctorsView { get; set; }
        public virtual DbSet<PatientsView> PatientsView { get; set; }
        public virtual DbSet<PatientsView2> PatientsView2 { get; set; }
        public virtual DbSet<AppointmentsView2> AppointmentsView2 { get; set; }
        public virtual DbSet<ClinicView> ClinicView { get; set; }
        public virtual DbSet<DoctorsView2> DoctorsView2 { get; set; }
    
        public virtual int UpdatePatient(Nullable<int> patientID, string surname, string name, string middleName, Nullable<System.DateTime> dateOfBirth, Nullable<int> genderID)
        {
            var patientIDParameter = patientID.HasValue ?
                new ObjectParameter("PatientID", patientID) :
                new ObjectParameter("PatientID", typeof(int));
    
            var surnameParameter = surname != null ?
                new ObjectParameter("Surname", surname) :
                new ObjectParameter("Surname", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var middleNameParameter = middleName != null ?
                new ObjectParameter("MiddleName", middleName) :
                new ObjectParameter("MiddleName", typeof(string));
    
            var dateOfBirthParameter = dateOfBirth.HasValue ?
                new ObjectParameter("DateOfBirth", dateOfBirth) :
                new ObjectParameter("DateOfBirth", typeof(System.DateTime));
    
            var genderIDParameter = genderID.HasValue ?
                new ObjectParameter("GenderID", genderID) :
                new ObjectParameter("GenderID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdatePatient", patientIDParameter, surnameParameter, nameParameter, middleNameParameter, dateOfBirthParameter, genderIDParameter);
        }
    }
}
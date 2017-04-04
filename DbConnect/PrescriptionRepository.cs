using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DbConnect.Poco;

namespace DbConnect
{
    public class PrescriptionRepository<Entity> where Entity : Prescription
    {
        
        #region Private member variables
        internal PrimaryDataContext Context;
        internal DbSet<Entity> DbSet;
        #endregion

        #region Public Constructor
        public PrescriptionRepository(PrimaryDataContext context)
        {
            this.Context = context;
            this.DbSet = context.Set<Entity>();
        }
        #endregion

        #region Public Methods
        public List<Prescription> GetPrescriptionWithDoctorAndPatient()
        {
            List<Prescription> prescriptionList = new List<Prescription>();
            var list = from prescription in Context.Prescription
                       from doctor in Context.Doctor
                        .Where(ad => ad.Id == prescription.DoctorId)
                       from patient in Context.Patient
                        .Where(ad => ad.Id == prescription.PatientId)
                       select new
                       {
                           prescription,
                           doctor,
                           patient
                       };
            foreach (var item in list)
            {
                if (item.doctor != null)
                {
                    item.prescription.Doctor = item.doctor;
                    item.prescription.Patient = item.patient;
                    prescriptionList.Add(item.prescription);
                }
            }
            return prescriptionList;
        }
        #endregion
    }
}

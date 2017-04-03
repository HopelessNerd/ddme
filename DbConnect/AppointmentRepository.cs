using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DbConnect.Poco;

namespace DbConnect
{
    public class AppointmentRepository<Entity> where Entity : Appointment
    {

        #region Private member variables
        internal PrimaryDataContext Context;
        internal DbSet<Entity> DbSet;
        #endregion

        #region Public Constructor
        public AppointmentRepository(PrimaryDataContext context)
        {
            this.Context = context;
            this.DbSet = context.Set<Entity>();
        }
        #endregion

        #region Public Methods
        public List<Appointment> GetAppointmentsWithDoctor()
        {
            List<Appointment> appointmentList = new List<Appointment>();
            var list = from appointment in Context.Appointment
                       from doctor in Context.Doctor
                        .Where(ad => ad.Id == appointment.DoctorId)
                       select new
                       {
                           appointment,
                           doctor
                       };
            foreach (var item in list)
            {
                if (item.doctor != null)
                {
                    item.appointment.Doctor = item.doctor;
                    appointmentList.Add(item.appointment);
                }
            }
            return appointmentList;
        }
        #endregion
    }
}

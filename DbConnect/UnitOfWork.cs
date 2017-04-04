using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Data.Entity.Validation;
using DbConnect.Poco;

namespace DbConnect
{
    /// <summary>
    /// Unit of Work class responsible for DB transactions
    /// </summary>
    public class UnitOfWork : IDisposable
    {
        #region Private member variables

        private PrimaryDataContext _context = null;

        #region Generic Repositories
        private GenericRepository<Appointment> _genericAppointmentRepo;
        private GenericRepository<Doctor> _genericDoctorRepo;
        private GenericRepository<Event> _genericEventRepo;
        private GenericRepository<Patient> _genericPatientRepo;
        private GenericRepository<Pharmacist> _genericPharmacistRepo;
        private GenericRepository<Prescription> _genericPrescriptionRepo;
        private GenericRepository<TestResult> _genericTestResultRepo;
        private GenericRepository<User> _genericUserRepo;
        #endregion

        #region Specific Repository

        private AppointmentRepository<Appointment> _appointmentRepository;
        private PrescriptionRepository<Prescription> _prescriptionRepository;
        #endregion
        #endregion

        public UnitOfWork()
        {
            _context = new PrimaryDataContext();
        }

        #region Public Repository Creation properties...

        #region Generic Repositories
        /// <summary>
        /// Get/Set property Appointment repository.
        /// </summary>
        public GenericRepository<Appointment> GenericAppointmentRepo
        {
            get
            {
                if (this._genericAppointmentRepo == null)
                    this._genericAppointmentRepo = new GenericRepository<Appointment>(_context);
                return _genericAppointmentRepo;
            }
        }

        /// <summary>
        /// Get/Set property Doctor repository.
        /// </summary>
        public GenericRepository<Doctor> GenericDoctorRepo
        {
            get
            {
                if (this._genericDoctorRepo == null)
                    this._genericDoctorRepo = new GenericRepository<Doctor>(_context);
                return _genericDoctorRepo;
            }
        }

        /// <summary>
        /// Get/Set property Event repository.
        /// </summary>
        public GenericRepository<Event> GenericEventRepo
        {
            get
            {
                if (this._genericEventRepo == null)
                    this._genericEventRepo = new GenericRepository<Event>(_context);
                return _genericEventRepo;
            }
        }

        /// <summary>
        /// Get/Set property Patient repository.
        /// </summary>
        public GenericRepository<Patient> GenericPatientRepo
        {
            get
            {
                if (this._genericPatientRepo == null)
                    this._genericPatientRepo = new GenericRepository<Patient>(_context);
                return _genericPatientRepo;
            }
        }

        /// <summary>
        /// Get/Set property Pharmacist repository.
        /// </summary>
        public GenericRepository<Pharmacist> GenericPharmacistRepo
        {
            get
            {
                if (this._genericPharmacistRepo == null)
                    this._genericPharmacistRepo = new GenericRepository<Pharmacist>(_context);
                return _genericPharmacistRepo;
            }
        }

        /// <summary>
        /// Get/Set property TestResult repository.
        /// </summary>
        public GenericRepository<TestResult> GenericTestResultRepo
        {
            get
            {
                if (this._genericTestResultRepo == null)
                    this._genericTestResultRepo = new GenericRepository<TestResult>(_context);
                return _genericTestResultRepo;
            }
        }

        /// <summary>
        /// Get/Set property User repository.
        /// </summary>
        public GenericRepository<User> GenericUserRepo
        {
            get
            {
                if (this._genericUserRepo == null)
                    this._genericUserRepo = new GenericRepository<User>(_context);
                return _genericUserRepo;
            }
        }

        /// <summary>
        /// Get/Set property Prescription repository.
        /// </summary>
        public GenericRepository<Prescription> GenericPrescriptionRepo
        {
            get
            {
                if (this._genericPrescriptionRepo == null)
                    this._genericPrescriptionRepo = new GenericRepository<Prescription>(_context);
                return _genericPrescriptionRepo;
            }
        }

        #endregion

        #endregion

        #region Private Repository Creation Properties
        public AppointmentRepository<Appointment> AppointmentRepo
        {
            get
            {
                if (this._appointmentRepository == null)
                    this._appointmentRepository = new AppointmentRepository<Appointment>(_context);
                return _appointmentRepository;
            }
        }

        public PrescriptionRepository<Prescription> PrescriptionRepo
        {
            get
            {
                if (this._prescriptionRepository == null)
                    this._prescriptionRepository = new PrescriptionRepository<Prescription>(_context);
                return _prescriptionRepository;
            }
        }
        #endregion

        #region Public member methods...
        /// <summary>
        /// Save method.
        /// </summary>
        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                    throw ex;
            }
        }

        #endregion

        #region Implementing IDiosposable...

        #region private dispose variable declaration...
        private bool disposed = false;
        #endregion

        /// <summary>
        /// Protected Virtual Dispose method
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        /// <summary>
        /// Dispose method
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
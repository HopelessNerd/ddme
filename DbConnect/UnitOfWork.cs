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
        private GenericRepository<User> _genericUserRepo;
        #endregion

        #region Specific Repository


        #endregion
        #endregion

        public UnitOfWork()
        {
            _context = new PrimaryDataContext();
        }

        #region Public Repository Creation properties...

        #region Generic Repositories
        /// <summary>
        /// Get/Set property user repository.
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

        #endregion

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
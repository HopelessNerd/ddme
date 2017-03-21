using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace DbConnect
{
    /// <summary>
    /// A class for business entities to perform generic operations.
    /// </summary>
    /// <typeparam name="Entity">Bussiness Entities</typeparam>
    public class GenericRepository<Entity> : IGenericRepository<Entity> where Entity : class
    {
        #region Private member variables
        internal PrimaryDataContext Context;
        internal DbSet<Entity> DbSet;
        #endregion

        #region Public Constructor
        /// <summary>
        /// Initialize private variables.
        /// </summary>
        /// <param name="context">Data context in use.</param>
        public GenericRepository(PrimaryDataContext context)
        {
            this.Context = context;
            this.DbSet = context.Set<Entity>();
        }
        #endregion

        #region Public member methods...

        /// <summary>
        /// Retrieves a list of entities.
        /// </summary>
        /// <returns>A list of an entity.</returns>
        public virtual IEnumerable<Entity> Get()
        {
            IQueryable<Entity> query = DbSet;
            return query.ToList();
        }

        /// <summary>
        /// Retrieves a single entity searched by id.
        /// </summary>
        /// <param name="id">Primary key of an entity.</param>
        /// <returns>A single entity.</returns>
        public virtual Entity GetByID(object id)
        {
            return DbSet.Find(id);
        }

        /// <summary>
        /// Add a single entity to repository.
        /// </summary>
        /// <param name="entity">Entity with new data.</param>
        public virtual void Insert(Entity entity)
        {
            DbSet.Add(entity);
            Context.Entry(entity).State = System.Data.Entity.EntityState.Added;
        }

        /// <summary>
        /// Delete an entity from repository using ID.
        /// </summary>
        /// <param name="id">Primary key of an entity.</param>
        public virtual void Delete(object id)
        {
            Entity entityToDelete = DbSet.Find(id);
            Delete(entityToDelete);
        }

        /// <summary>
        /// Delete a record of an entity from repository using entity's state.
        /// </summary>
        /// <param name="entityToDelete">A single entity.</param>
        public virtual void Delete(Entity entityToDelete)
        {
            if (Context.Entry(entityToDelete).State == System.Data.Entity.EntityState.Detached)
            {
                DbSet.Attach(entityToDelete);
            }
            DbSet.Remove(entityToDelete);
        }

        /// <summary>
        /// Update a record of an entity in the repository using an entity's state.
        /// </summary>
        /// <param name="entityToUpdate">A single entity with updated data.</param>
        public virtual void Update(Entity entityToUpdate)
        {
            DbSet.Attach(entityToUpdate);
            Context.Entry(entityToUpdate).State = System.Data.Entity.EntityState.Modified;
        }

        /// <summary>
        /// Retrieves many records of an entity with provided conditions.
        /// </summary>
        /// <param name="where">Condition on which list is required.</param>
        /// <returns>List of records of an entity</returns>
        public virtual IEnumerable<Entity> GetMany(Func<Entity, bool> condition)
        {
            return DbSet.Where(condition).ToList();
        }

        /// <summary>
        /// Retrieves many queryable records of an entity with provided conditions.
        /// </summary>
        /// <param name="where">Condition on which list is required.</param>
        /// <returns>List of records of an entity</returns>
        public virtual IQueryable<Entity> GetManyQueryable(Func<Entity, bool> condition)
        {
            return DbSet.Where(condition).AsQueryable();
        }

        /// <summary>
        /// Retrieves first or default queryable record of an entity with provided conditions.
        /// </summary>
        /// <param name="where">Condition on which first entity is required.</param>
        /// <returns>A single entity.</returns>
        public Entity Get(Func<Entity, Boolean> condition)
        {
            return DbSet.Where(condition).FirstOrDefault<Entity>();
        }

        /// <summary>
        /// Delete many records of an entity with provided conditions.
        /// </summary>
        /// <param name="where">Condition on which many records required to be deleted.</param>
        /// <returns></returns>
        public void Delete(Func<Entity, Boolean> where)
        {
            IQueryable<Entity> objects = DbSet.Where<Entity>(where).AsQueryable();
            foreach (Entity obj in objects)
                DbSet.Remove(obj);
        }

        /// <summary>
        /// Retrieves all the records of an entity.
        /// </summary>
        /// <returns>List of all records of an entity</returns>
        public virtual IEnumerable<Entity> GetAll()
        {
            return DbSet.ToList();
        }

        /// <summary>
        /// Includes many records of multiple entities.
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="include"></param>
        /// <returns></returns>
        public IQueryable<Entity> GetWithInclude(Expression<Func<Entity, bool>> predicate, params string[] include)
        {
            IQueryable<Entity> query = this.DbSet;
            query = include.Aggregate(query, (current, inc) => current.Include(inc));
            return query.Where(predicate);
        }

        /// <summary>
        /// Generic method to check if entity exists.
        /// </summary>
        /// <param name="primaryKey">Primary key of an entity.</param>
        /// <returns>True if Exists, False if doesn't exists</returns>
        public bool Exists(object primaryKey)
        {
            return DbSet.Find(primaryKey) != null;
        }

        /// <summary>
        /// Generic method to retrieve a single record of an entity with provided conditions.
        /// </summary>
        /// <param name="predicate">Criteria to match on.</param>
        /// <returns>A single entity.</returns>
        public Entity GetSingle(Func<Entity, bool> predicate)
        {
            return DbSet.Single<Entity>(predicate);
        }

        /// <summary>
        /// Generic method to retrieve first record of an entity with provided conditions.
        /// </summary>
        /// <param name="predicate">Criteria to match on</param>
        /// <returns>A single entity.</returns>
        public Entity GetFirst(Func<Entity, bool> predicate)
        {
            return DbSet.First<Entity>(predicate);
        }
        #endregion
    }
}

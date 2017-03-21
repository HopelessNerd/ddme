using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DbConnect
{
    interface IGenericRepository<Entity> where Entity : class
    {
        void Delete(Entity entityToDelete);
        void Delete(Func<Entity, bool> where);
        void Delete(object id);
        bool Exists(object primaryKey);
        IEnumerable<Entity> Get();
        Entity Get(Func<Entity, bool> condition);
        IEnumerable<Entity> GetAll();
        Entity GetByID(object id);
        Entity GetFirst(Func<Entity, bool> predicate);
        IEnumerable<Entity> GetMany(Func<Entity, bool> condition);
        IQueryable<Entity> GetManyQueryable(Func<Entity, bool> condition);
        Entity GetSingle(Func<Entity, bool> predicate);
        IQueryable<Entity> GetWithInclude(Expression<Func<Entity, bool>> predicate, params string[] include);
        void Insert(Entity entity);
        void Update(Entity entityToUpdate);
    }
}

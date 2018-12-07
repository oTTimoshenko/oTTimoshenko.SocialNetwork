using oTTimoshenko.SocialNetwork.Domain;
using System.Collections.Generic;
using System.Data.Entity;

namespace oTTimoshenko.SocialNetwork.DataAccess.EntityFramework.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        public readonly DbContext Context;

        public virtual void Add(T entityObject)
            => Context.Set<T>().Add(entityObject);

        public virtual void Update(T entityObject)
            => Context.Entry(entityObject).State = EntityState.Modified;

        public virtual T GetById(int id)
            => Context.Set<T>().Find(id);

        public virtual IEnumerable<T> GetAll()
            => Context.Set<T>();

        public virtual void Delete(int id)
        {
            var entity = Context.Set<T>().Find(id);

            if (entity != null)
                Context.Set<T>().Remove(entity);
        }
    }
}

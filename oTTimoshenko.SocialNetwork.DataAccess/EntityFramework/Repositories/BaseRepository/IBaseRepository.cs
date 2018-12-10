using oTTimoshenko.SocialNetwork.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oTTimoshenko.SocialNetwork.DataAccess.EntityFramework.Repositories
{
    public interface IBaseRepository<T> where T: BaseEntity
    {
        void Add(T entityObject);
        void Update(T entityObject);
        void Delete(int id);
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Save();
    }
}

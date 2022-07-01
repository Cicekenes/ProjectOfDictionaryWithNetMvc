using ProjectOfDictionaryWithNetMvc.Dal.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOfDictionaryWithNetMvc.Dal.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        DictionaryContext _db = new DictionaryContext();
        DbSet<T> _object;

        public GenericRepository()
        {
            _object = _db.Set<T>();
        }

        public void Delete(T t)
        {
            var deletedEntity = _db.Entry(t);
            deletedEntity.State = EntityState.Deleted;
            //_object.Remove(t);
            _db.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            //Find işlemi, bir tane değer döndürür.
            return _object.SingleOrDefault(filter);
        }

        public void Insert(T t)
        {
            var addedEntity = _db.Entry(t);
            addedEntity.State= EntityState.Added;
           // _object.Add(t);
            _db.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T t)
        {
            var updatedEntity = _db.Entry(t);
            updatedEntity.State = EntityState.Modified;
            _db.SaveChanges();
        }
    }
}

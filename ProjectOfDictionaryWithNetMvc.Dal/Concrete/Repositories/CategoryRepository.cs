using ProjectOfDictionaryWithNetMvc.Dal.Abstract;
using ProjectOfDictionaryWithNetMvc.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOfDictionaryWithNetMvc.Dal.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
       DictionaryContext _db= new DictionaryContext();
        DbSet<Category> _object;
        public void Delete(Category p)
        {
            _object.Remove(p);
            _db.SaveChanges();
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Category p)
        {
            _object.Add(p);
            _db.SaveChanges(); //ExecuteNonQuery();
        }

        public List<Category> List()
        {
            return _object.ToList();
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category p)
        {
            _db.SaveChanges();
        }
    }
}

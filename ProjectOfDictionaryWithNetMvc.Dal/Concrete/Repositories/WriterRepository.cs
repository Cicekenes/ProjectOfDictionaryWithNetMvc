using ProjectOfDictionaryWithNetMvc.Dal.Abstract;
using ProjectOfDictionaryWithNetMvc.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOfDictionaryWithNetMvc.Dal.Concrete.Repositories
{
    public class WriterRepository : IWriterDal
    {
        public void Delete(Writer t)
        {
            throw new NotImplementedException();
        }

        public Writer Get(Expression<Func<Writer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Writer t)
        {
            throw new NotImplementedException();
        }

        public List<Writer> List()
        {
            throw new NotImplementedException();
        }

        public List<Writer> List(Expression<Func<Writer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Writer t)
        {
            throw new NotImplementedException();
        }
    }
}

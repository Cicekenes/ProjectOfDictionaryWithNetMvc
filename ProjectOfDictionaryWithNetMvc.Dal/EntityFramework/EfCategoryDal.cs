using ProjectOfDictionaryWithNetMvc.Dal.Abstract;
using ProjectOfDictionaryWithNetMvc.Dal.Concrete.Repositories;
using ProjectOfDictionaryWithNetMvc.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOfDictionaryWithNetMvc.Dal.EntityFramework
{
    public class EfCategoryDal:GenericRepository<Category>,ICategoryDal
    {
    }
}

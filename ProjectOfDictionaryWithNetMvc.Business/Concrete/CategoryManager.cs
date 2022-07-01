using ProjectOfDictionaryWithNetMvc.Business.Abstract;
using ProjectOfDictionaryWithNetMvc.Dal.Abstract;
using ProjectOfDictionaryWithNetMvc.Dal.Concrete.Repositories;
using ProjectOfDictionaryWithNetMvc.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOfDictionaryWithNetMvc.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void CategoryAdd(Category category)
        {
            _categoryDal.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
           _categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);
        }

        public Category GetById(int id)
        {
            //lambda expression linq sorgusu
            return _categoryDal.Get(x=>x.CategoryID==id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }

        //public void CategoryAddBL(Category p)
        //{
        //    if (p.CategoryName=="" || p.CategoryStatus==false||p.CategoryName.Length<=2)
        //    {
        //        // hata mesajı
        //    }else
        //    {
        //        _categoryDal.Insert(p);
        //    }
        //}

    }

}
using ProjectOfDictionaryWithNetMvc.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOfDictionaryWithNetMvc.Business.Abstract
{
    public interface IContentService
    {
        List<Content> GetList();
        List<Content> GetListByHeadingId(int id);
        void ContentAdd(Content content);
        Content GetById(int id);
        void ContentDelete(Content content);
        void ContentUpdate(Content content);
    }
}

using ProjectOfDictionaryWithNetMvc.Business.Abstract;
using ProjectOfDictionaryWithNetMvc.Dal.Abstract;
using ProjectOfDictionaryWithNetMvc.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOfDictionaryWithNetMvc.Business.Concrete
{
    public class ContentManager : IContentService
    {
        IContentDal _contentDal;
        public ContentManager(IContentDal contentDal)
        {
            _contentDal= contentDal;
        }
        public void ContentAdd(Content content)
        {
            throw new NotImplementedException();
        }

        public void ContentDelete(Content content)
        {
            throw new NotImplementedException();
        }

        public void ContentUpdate(Content content)
        {
            throw new NotImplementedException();
        }

        public Content GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Content> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Content> GetListByHeadingId(int id)
        {
            //İçerikler başlığın Id'sine göre gelsin
            return _contentDal.List(x => x.HeadingID == id);
        }
    }
}

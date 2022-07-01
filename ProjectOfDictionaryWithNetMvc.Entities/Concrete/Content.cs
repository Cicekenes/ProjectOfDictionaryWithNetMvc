using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOfDictionaryWithNetMvc.Entities.Concrete
{
    //İçerik sınıfı
    public class Content
    {
        [Key]
        public int ContentID { get; set; }
        [StringLength(1000)]
        public string ContentValue { get; set; } // İçerik
        public DateTime ContentDate { get; set; }
        public bool ContentStatus { get; set; }
        //1 heading'de birden fazla content olabilir
        public int HeadingID { get; set; }
        public virtual Heading Heading { get; set; }
        // bir yazar birden fazla içerik yazabilir
        public int? WriterID { get; set; }
        public virtual Writer Writer { get; set; }
    }
}

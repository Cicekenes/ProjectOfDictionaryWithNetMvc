using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOfDictionaryWithNetMvc.Entities.Concrete
{
    // Başlık sınıfı

    public class Heading
    {
        [Key]
        public int HeadingID { get; set; }
        [StringLength(50)]
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }
        public bool HeadingStatus { get; set; }
        // 1 kategori sınıfında bir çok başlık olabilir
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        //1 başlık sınıfında bir çok içerik olabilir
        public ICollection<Content> Contents { get; set; }

        //Her başlığın bir yazarı olmak zorundadır
        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }
    }
}

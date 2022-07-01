﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOfDictionaryWithNetMvc.Entities.Concrete
{
    //Yazar alanıdır
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }
        [StringLength(50)]
        public string WriterName { get; set; }
        [StringLength(50)]
        public string WriterSurname { get; set; }
        [StringLength(250)]
        public string WriterImage { get; set; }
        [StringLength(100)]
        public string WriterAbout { get; set; }
        [StringLength(200)]
        public string WriterMail { get; set; }
        [StringLength(200)]
        public string WriterPassword { get; set; }
        [StringLength(50)]
        public string WriterTitle { get; set; }
        public bool WriterStatus { get; set; }
        //Bir yazar birden fazla başlık oluşturabilir
        public ICollection<Heading> Headings { get; set; }
        //bir yazar birden fazla içerik yazabilir
        public ICollection<Content> Contents  { get; set; }
    }
}

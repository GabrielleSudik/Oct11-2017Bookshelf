using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Oct11_2017Bookshelf.Models
{
    public class Author2
    {
        [Key]
        public int ID { get; set; } //first item under key is the primary key (I think)
        public string Name { get; set; }
        public string Language { get; set; }
        public virtual ICollection<Book> Books { get; set; }
        
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Oct11_2017Bookshelf.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
            //this last line makes this info available ONLY when needed
            //not when the program starts
            //here, it means we might have a book in category horror
            //all of the info about the books is easy to get
            //but all of the info about the whole category is burdensome
            //so it's only gotten when needed
    }
}
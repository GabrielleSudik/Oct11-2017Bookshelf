using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Oct11_2017Bookshelf.Models
{
    public class Book
    {
        [Key]
        public int ID { get; set; } //first item under key is the primary key (I think)
        public string Title { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }
        public DateTime DatePublished { get; set; }

        //later: add Authors, to practice migration
        public string Author { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
            //this line -- you need to create a class called Category
            //before you create it, the first Category had red squiggles
            //after, you can see it's a class by its color
            //why are we doing this?
            //it's using the foreign key Category
            //the whole line is called a "navigation property"
            //here, it's part of a one-to-many relationship
            //one category to many books

    }
}
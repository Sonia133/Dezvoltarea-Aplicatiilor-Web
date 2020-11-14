﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LabApp.Models
{
    public class Book
    {
        [Key]
        [Column("book_id")]
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime DateCreation { get; set; }
        public string Summary { get; set; }

        // one to many
        [Column("publisher_id")]
        public int PublisherId { get; set; }
        public virtual Publisher Publisher { get; set; }

        // many to many 
        public virtual ICollection<Genre> Genres { get; set; }
    }
}
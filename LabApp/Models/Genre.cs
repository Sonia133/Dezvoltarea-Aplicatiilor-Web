using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LabApp.Models
{
    public class Genre
    {
        [Key]
        [Column("genre_id")]
        public int GenreId { get; set; }
        public string Name { get; set; }

        // many to many
        public virtual ICollection<Book> books { get; set; }
    }
}
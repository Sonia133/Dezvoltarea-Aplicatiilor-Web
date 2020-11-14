using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabApp.Models
{
    public class Publisher
    {
        
        [Key]
        [Column("publisher_id")]
        public int PublisherId { get; set; }
        public string Name { get; set; }

        // many to one
        public virtual ICollection<Book> Books { get; set; }

        // one to one 
        [Required]
        public virtual ContactInfo ContactInfo { get; set; }
    }
}
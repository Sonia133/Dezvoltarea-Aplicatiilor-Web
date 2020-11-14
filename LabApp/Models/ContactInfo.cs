using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LabApp.Models
{
    public class ContactInfo
    {
        [Key]
        [Column("contactInfo_id")]
        public int ContactInfoId { get; set; }
        public string PhoneNumber { get; set; }

        // one to one
        public virtual Publisher Publisher { get; set; }
    }
}
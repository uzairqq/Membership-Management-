using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Memberships.Models
{
    [Table("Section")]
    //used to create the table in the database
    public class Section
    {
        //for identity of increment of 1 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(100)]//Max Length of this input
        [Required] // required for this feild
        public string Title { get; set; }
    }
}
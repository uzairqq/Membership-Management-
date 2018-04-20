using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Memberships.Models
{
    [Table("Product Item")]
    public class ProductItem
    {
      [Required]
      [Key,Column(Order = 1)] // remember the order that which primary key is first and second
      public int ProductId { get; set; }

        [Required]
        [Key,Column(Order = 2)] // remember the order 
        public int ItemId { get; set; }

        [NotMapped]
        public int OldProductId { get; set; }

        [NotMapped]
        public int OldItemId { get; set; }
    }
}
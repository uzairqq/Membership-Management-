using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Memberships.Models
{
    [Table("Subscription Product")]
    public class SubscriptionProduct
    {
        [Key,Column(Order = 1)]
        [Required]
        public int ProductId { get; set; }

        [Key, Column(Order = 2)]
        [Required]
        public int SubscriptionId { get; set; }

        [NotMapped]
        public int OldProductId { get; set; }

        [NotMapped]
        public int OldSubscriptionId { get; set; }
    }
}
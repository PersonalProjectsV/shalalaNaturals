namespace shalalaNaturals.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CART")]
    public partial class CART
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string ClientID { get; set; }

        public int ProductID { get; set; }

        public int Amount { get; set; }

        public DateTime? DatePurchased { get; set; }

        public bool IsInCart { get; set; }
    }
}

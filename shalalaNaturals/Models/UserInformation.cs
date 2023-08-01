namespace shalalaNaturals.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserInformation")]
    public partial class UserInformation
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string mail { get; set; }

        [Required]
        [StringLength(50)]
        public string FirtsName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(100)]
        public string street1 { get; set; }

        [StringLength(100)]
        public string street2 { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(50)]
        public string Province { get; set; }

        public int zipCode { get; set; }

        [Required]
        [StringLength(100)]
        public string GUID { get; set; }

        [Required]
        [StringLength(10)]
        public string number { get; set; }
    }
}

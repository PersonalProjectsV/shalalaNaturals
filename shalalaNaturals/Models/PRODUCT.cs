namespace shalalaNaturals.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRODUCT")]
    public partial class PRODUCT
    {
        public int Id { get; set; }

        public int TypeId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public int? Price { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        [StringLength(150)]
        public string Image { get; set; }
    }
}

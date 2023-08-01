namespace shalalaNaturals.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class shalalaModel : DbContext
    {
        public shalalaModel()
            : base("name=shalalaModel")
        {
        }

        public virtual DbSet<CART> CARTs { get; set; }
        public virtual DbSet<PRODUCT> PRODUCTs { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }
        public virtual DbSet<UserInformation> UserInformations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PRODUCT>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCT>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCT>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<ProductType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<UserInformation>()
                .Property(e => e.mail)
                .IsUnicode(false);

            modelBuilder.Entity<UserInformation>()
                .Property(e => e.FirtsName)
                .IsUnicode(false);

            modelBuilder.Entity<UserInformation>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<UserInformation>()
                .Property(e => e.street1)
                .IsUnicode(false);

            modelBuilder.Entity<UserInformation>()
                .Property(e => e.street2)
                .IsUnicode(false);

            modelBuilder.Entity<UserInformation>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<UserInformation>()
                .Property(e => e.Province)
                .IsUnicode(false);

            modelBuilder.Entity<UserInformation>()
                .Property(e => e.number)
                .IsUnicode(false);
        }
    }
}

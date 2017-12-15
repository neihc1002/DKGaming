namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DKGamingDBContext : DbContext
    {
        public DKGamingDBContext()
            : base("name=DKGamingDBContext")
        {
        }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<ContentConfig> ContentConfig { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>()
                .Property(e => e.MetaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Categories>()
                .Property(e => e.CreateBy)
                .IsUnicode(false);

            modelBuilder.Entity<Categories>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Categories>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.Categories)
                .HasForeignKey(e => e.CateId);

            modelBuilder.Entity<ContentConfig>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.MetaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Products>()
                .Property(e => e.WholesalePrices)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Products>()
                .Property(e => e.PromotionPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Products>()
                .Property(e => e.CreateBy)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Categories)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.CreateBy);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Categories1)
                .WithOptional(e => e.Users1)
                .HasForeignKey(e => e.ModifiedBy);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.CreateBy);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Products1)
                .WithOptional(e => e.Users1)
                .HasForeignKey(e => e.ModifiedBy);
        }
    }
}

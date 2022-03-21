using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Investors_API.Models
{
    public partial class InvestorsAPIContext : DbContext
    {
        public InvestorsAPIContext()
        {
        }

        public InvestorsAPIContext(DbContextOptions<InvestorsAPIContext> options)
            : base(options)
        {
        }


        public virtual DbSet<MaleInvestors> MaleInvestors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=InvestorsAPI;Integrated security=true ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<MaleInvestors>(entity =>
            {
                entity.ToTable("Male_Investors");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Contact).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ProfilePic).HasMaxLength(50);

                entity.Property(e => e.Total_Investment)
                    .HasColumnName("Total_Investment")
                    .HasColumnType("decimal(18, 0)");
                entity.Property(e => e.Gender).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

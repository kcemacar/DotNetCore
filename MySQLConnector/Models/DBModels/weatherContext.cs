using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MySQLConnectionWithDotNetCore.Models.DBModels
{
    public partial class weatherContext : DbContext
    {
        public weatherContext()
        {
        }

        public weatherContext(DbContextOptions<weatherContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Turkey> Turkey { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;port=3306;user=root;password=kadriocak123;database=weather", x => x.ServerVersion("8.0.20-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Turkey>(entity =>
            {
                entity.ToTable("turkey");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Rain).HasColumnName("rain");

                entity.Property(e => e.Temp).HasColumnName("temp");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

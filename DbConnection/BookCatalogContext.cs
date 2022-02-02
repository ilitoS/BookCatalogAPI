using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DbConnection
{
    public partial class BookCatalogContext : DbContext
    {
        public BookCatalogContext()
        {
        }

        public BookCatalogContext(DbContextOptions<BookCatalogContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Books> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseMySQL("server=localhost;database=BookCatalog;uid=root;pwd=maha08082007;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Books>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Books", "BookCatalog");

                entity.Property(e => e.Authors).HasColumnName("authors");

                entity.Property(e => e.AverageRating).HasColumnName("average_rating");

                entity.Property(e => e.Categories).HasColumnName("categories");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Isbn10).HasColumnName("isbn10");

                entity.Property(e => e.Isbn13).HasColumnName("isbn13");

                entity.Property(e => e.NumPages).HasColumnName("num_pages");

                entity.Property(e => e.PublishedYear).HasColumnName("published_year");

                entity.Property(e => e.RatingsCount).HasColumnName("ratings_count");

                entity.Property(e => e.Subtitle).HasColumnName("subtitle");

                entity.Property(e => e.Thumbnail).HasColumnName("thumbnail");

                entity.Property(e => e.Title).HasColumnName("title");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

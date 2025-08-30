using Microsoft.EntityFrameworkCore;
using Library_Management.Models.Data;

namespace Library_Management.Data
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options)
            : base(options)
        {
        }

        public DbSet<BookList> BookLists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookList>(entity =>
            {
                entity.HasKey(e => e.BookId).HasName("PK_BookList");

                entity.ToTable("BookList");

                entity.Property(e => e.BookId).ValueGeneratedNever();
                entity.Property(e => e.AuthorName).HasMaxLength(255);
                entity.Property(e => e.AuthorProfileImageUrl).HasMaxLength(500);
                entity.Property(e => e.CoverImageUrl).HasMaxLength(500);
                entity.Property(e => e.Genre).HasMaxLength(100);
                entity.Property(e => e.Isbn)
                      .HasMaxLength(50)
                      .HasColumnName("ISBN");
                entity.Property(e => e.PublishedDate).HasColumnType("datetime");
                entity.Property(e => e.Title).HasMaxLength(255);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
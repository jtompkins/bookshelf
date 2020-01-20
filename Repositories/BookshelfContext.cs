using bookshelf.Models;
using Microsoft.EntityFrameworkCore;

namespace bookshelf.Repositories {
  public class BookshelfContext : DbContext {
    public DbSet<User> Users { get; set; }
    public DbSet<Book> Books { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
      optionsBuilder
        .UseNpgsql("Host=localhost;Database=bookshelf;Username=bookshelf;Password=bookshelf")
        .UseSnakeCaseNamingConvention();
  }
}

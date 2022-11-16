using Microsoft.EntityFrameworkCore;

namespace Library
{
    public class LibraryDBContext : DbContext
    {
        public DbSet<Book> Books => Set<Book>();
        public DbSet<Author> Authors => Set<Author>();
        public DbSet<Member> Members => Set<Member>();

       public LibraryDBContext(DbContextOptions<LibraryDBContext> options)
         : base(options)
       {
       }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author()
                {
                    Id = -1,
                    FirstName = "Umberto",
                    LastName = "Eco"
                },
                new Author()
                {
                    Id = -2,
                    FirstName = "Haruki",
                    LastName = "Murakami"
                }
            );

            modelBuilder.Entity<Member>().HasData(
                new Member()
                {
                    Id = -1,
                    FirstName = "John",
                    LastName = "Smith",
                    Email = "jsmith@example.com",
                });

            modelBuilder.Entity<Book>().HasData(
                new Book()
                {
                    Id = -1,
                    Name = "The Name of the Rose",
                    Publisher = "Fixed House",
                    AuthorId = -1,
                    RentedToId = -1
                },
                new Book()
                {
                    Id = -2,
                    Name = "The Limits of Interpretation",
                    Publisher = "Fixed House",
                    AuthorId = -1
                },
                new Book()
                {
                    Id = -3,
                    Name = "Kafka on the Shore",
                    Publisher = "Arctic Editions",
                    AuthorId = -2
                });


        }

    }
}

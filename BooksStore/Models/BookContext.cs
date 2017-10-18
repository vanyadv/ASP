using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace BooksStore.Models
{
    public class BookContext: DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }

    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "Преступлени и наказание", Author = "Достоевский", Price = 200 });
            db.Books.Add(new Book { Name = "Эрагон", Author = "Паолини", Price = 400 });
            base.Seed(db);
        }
    }
}
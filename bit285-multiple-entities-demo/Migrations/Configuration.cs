namespace bit285_multiple_entities_demo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using IndyBooks.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<IndyBooks.Models.BookstoreDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "IndyBooks.Models.BookstoreDbContext";
        }

        protected override void Seed(IndyBooks.Models.BookstoreDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.Books.AddOrUpdate(b => b.BookID,
                new Book()
                {
                    BookID = 1,
                    Title = "Pride and Prejudice",
                    AuthorID = 1,
                    Price = 9.99M
                },
                new Book()
                {
                    BookID = 2,
                    Title = "Northanger Abbey",
                    AuthorID = 1,
                    Price = 12.95M
                },
                new Book()
                {
                    BookID = 3,
                    Title = "David Copperfield",
                    AuthorID = 2,
                    Price = 15.00M
                },
                new Book()
                {
                    BookID = 4,
                    Title = "The Wizard of EarthSea",
                    AuthorID = 3,
                    Price = 8.95M
                },
                new Book()
                {
                    BookID = 5,
                    Title = "The Tombs of Atuan",
                    AuthorID = 3,
                    Price = 7.95M
                },
                new Book()
                {
                    BookID = 6,
                    Title = "The Farthest Shore",
                    AuthorID = 3,
                    Price = 9.95M

                },
                new Book()
                {
                    BookID = 7,
                    Title = "Thee",
                    AuthorID = 4,
                    Price = 9.80M

                }
                ,
                new Book()
                {
                    BookID = 8,
                    Title = "There",
                    AuthorID = 4,
                    Price = 9.29M

                }
                ,
                new Book()
                {
                    BookID = 9,
                    Title = "The art",
                    AuthorID = 5,
                    Price = 9.10M

                });
            // Added several Author records
            context.Authors.AddOrUpdate(a => a.AuthorID,
                new Author()
                {
                    AuthorID = 1,
                    FirstName = "Jane",
                    LastName = "Austen"
                }, 
                new Author()
                {
                    AuthorID = 2,
                    FirstName = "Charles",
                    LastName = "Dickens"
                },
                new Author()
                {
                    AuthorID = 3,
                    FirstName = "Ursula",
                    LastName = "Le Guin"
                },
                new Author()
                {
                    AuthorID = 4,
                    FirstName = "Ur",
                    LastName = "Lin"
                },
                new Author()
                {
                    AuthorID = 5,
                    FirstName = "Johnny",
                    LastName = "Baba"
                },
                new Author()
                {
                    AuthorID = 6,
                    FirstName = "baba",
                    LastName = "coulfield"
                });
            //TODO: Seed a few more Member records
            context.Members.AddOrUpdate(m => m.MemberID,
                new Member()
                {
                    MemberID = 1,
                    FirstName = "Ian",
                    LastName = "Bansenauer"
                },
                new Member()
                {
                    MemberID = 2,
                    FirstName = "robbie",
                    LastName = "smidth"
                },
                new Member()
                {
                    MemberID = 3,
                    FirstName = "robe",
                    LastName = "smith"
                },
                new Member()
                {
                    MemberID = 4,
                    FirstName = "chris",
                    LastName = "wayde"
                });
            //TODO: Seed a few more Purchase records
            context.Purchases.AddOrUpdate(p => p.PurchaseID,
                new Purchase()
                {
                    PurchaseID = 1,
                    Amount = 11.39M,
                    BookID = 6,
                    MemberID = 1
                }, new Purchase()
                {
                    PurchaseID = 2,
                    Amount = 50.00M,
                    BookID = 5,
                    MemberID = 2
                }, new Purchase()
                {
                    PurchaseID = 3,
                    Amount = 10.80M,
                    BookID = 4,
                    MemberID = 3
                }, new Purchase()
                {
                    PurchaseID = 4,
                    Amount = 20.80M,
                    BookID = 3,
                    MemberID = 4
                });

        }
    }
}

using System.Collections.Generic;
using LostAndFound.Data.Models;
using LostAndFound.Data.Models.Lookups;

namespace LostAndFound.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LostAndFound.Data.LostAndFoundContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LostAndFound.Data.LostAndFoundContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            // using (var dataContext = new DataModelContainer())
           using (var transaction = context.Database.BeginTransaction())
            {
             

                context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Species] ON");

                SeedSpecies(context);
                context.SaveChanges();

                context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Species] OFF");

                transaction.Commit();
           }

        

    
        }

        private void SeedSpecies(LostAndFoundContext context)
        {




          
            context.Species.AddOrUpdate(s=>s.Id, 
                new Species() { Id = -1, DateCreated = DateTime.Now, DateModified = DateTime.Now, Name = "Unknown", DisplayName = "Unknown", Description = "Unknown", Status = true },
                new Species() { Id = 0, DateCreated = DateTime.Now, DateModified = DateTime.Now, Name = "Dog", DisplayName = "Dog", Description = "Dog", Status = true },
                new Species() { Id = 1, DateCreated = DateTime.Now, DateModified = DateTime.Now, Name = "Cat", DisplayName = "Cat", Description = "Cat", Status = true },
                new Species() { Id = 2, DateCreated = DateTime.Now, DateModified = DateTime.Now, Name = "Horse", DisplayName = "Horse", Description = "Horse", Status = true },
                new Species() { Id = 3, DateCreated = DateTime.Now, DateModified = DateTime.Now, Name = "Cattle", DisplayName = "Cattle", Description = "Cattle", Status = true },
                new Species() { Id = 4, DateCreated = DateTime.Now, DateModified = DateTime.Now, Name = "Goat", DisplayName = "Goat", Description = "Goat", Status = true },
                new Species() { Id = 5, DateCreated = DateTime.Now, DateModified = DateTime.Now, Name = "GuineaPig", DisplayName = "Guinea Pig", Description = "Guinea Pig", Status = true },
                new Species() { Id = 6, DateCreated = DateTime.Now, DateModified = DateTime.Now, Name = "Rabbit", DisplayName = "Rabbit", Description = "Rabbit", Status = true },
                new Species() { Id = 7, DateCreated = DateTime.Now, DateModified = DateTime.Now, Name = "Bird", DisplayName = "Bird", Description = "Bird", Status = true }
                );

      

        }
    }
}

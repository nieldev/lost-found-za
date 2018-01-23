using System.Collections.Generic;
using LostAndFound.Data.Models;
using LostAndFound.Data.Models.Lookups;
using LostAndFound.External;
using Newtonsoft.Json;

namespace LostAndFound.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LostAndFound.Data.LostAndFoundContext>
    {
        private int categoryCount = 0;
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
            return;
           using (var transaction = context.Database.BeginTransaction())
            {
             

                context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Species] ON");
              //  context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[LostAndFoundTypes] ON");

                SeedSpecies(context);
                //SeedLostAndFOundTypes(context);
                context.SaveChanges();

                context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Species] OFF");
             //   context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[LostAndFoundTypes] OFF");

                transaction.Commit();
           }

        

    
        }

        //private void SeedLostAndFOundTypes(LostAndFoundContext context)
        //{

        //    try
        //    {

        //        var types = new List<LostAndFoundType>();

        //        InternetLostAndFoundApi api = new InternetLostAndFoundApi();
        //        dynamic result =  api.GetResult("Get_categories");
        //        var id = -1;
        //      //  var unknown = new LostAndFoundType()
        //      //  {
        //      //      Id = -1,
        //      //      DateCreated = DateTime.Now,
        //      //      DateModified = DateTime.Now,
        //      //      Name = "Unknown",
        //      //      DisplayName = "Unknown",
        //      //      Description = "Unknown",
        //      //      Status = true,
        //      //      ExternalId = -1
        //      //  };
        //      ////  types.Add(unknown);
        //        id++;

        //        //var unknownCategory = new Category()
        //        //{
        //        //    Id = -1,
        //        //    DateCreated = DateTime.Now,
        //        //    DateModified = DateTime.Now,
        //        //    Name = "Unknown",
        //        //    DisplayName = "Unknown",
        //        //    Description = "Unknown",
        //        //    Status = true,
        //        //    ExternalId = -1,
        //        //    Type = unknown
        //        //};
        //       // context.Categories.AddOrUpdate(unknownCategory);
        //        foreach (var item in result.data)
        //        {
        //            int cat = item.category_id;
        //            if (cat == 0) continue;
        //            var name = item.category_hashtag;
        //            if (string.IsNullOrWhiteSpace(name.ToString()))
        //            {
        //                name = item.category_name.ToString();
        //                name = name.Replace("/", "");
        //                name = name.Replace(" ", "");
        //                name = name.Trim();
        //            }
        //            int catId = int.Parse(item.category_id.ToString());
        //            List<Category> categories = GetCategoriesForId(catId);
                   
        //            types.Add(new LostAndFoundType()
        //            {
        //                Id = id,
        //                DateCreated = DateTime.Now,
        //                DateModified = DateTime.Now,
        //                Name = name,
        //                DisplayName = item.category_name,
        //                Description = item.category_name,
        //                Status = true,
        //                ExternalId = item.category_id,
        //                Categories = categories

        //            });
        //            id++;
        //        }

        //        context.LostAndFoundTypes.AddOrUpdate(types.ToArray());

        //    }
        //    catch (Exception e)
        //    {
            
        //        throw;
        //    }


        //}

        private List<Category> GetCategoriesForId(int categoryId)
        {
            var categories = new List<Category>();


           

            InternetLostAndFoundApi api = new InternetLostAndFoundApi();
            dynamic result = api.GetResult($"Get_sub_categories/{categoryId}");

            foreach (var item in result.data)
            {
                int cat = item.category_id;
                if (cat == 0) continue;
                var name = item.category_hashtag;
                if (string.IsNullOrWhiteSpace(name.ToString()))
                {
                    name = item.category_name.ToString();
                    name = name.Replace("/", "");
                    name = name.Replace(" ", "");
                    name = name.Trim();
                }
          
           
                categories.Add(new Category()
                {
                    Id = categoryCount,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now,
                    Name = name,
                    DisplayName = item.category_name,
                    Description = item.category_name,
                    Status = true,
                    ExternalId = item.category_id

                });
                categoryCount++;
            }

            return categories;




        }

        private void SeedSpecies(LostAndFoundContext context)
        {

            


          
            //context.Species.AddOrUpdate(s=>s.Name, 
            //    new Species() { Id = -1, DateCreated = DateTime.Now, DateModified = DateTime.Now, Name = "Unknown", DisplayName = "Unknown", Description = "Unknown", Status = true },
            //    new Species() { Id = 0, DateCreated = DateTime.Now, DateModified = DateTime.Now, Name = "Dog", DisplayName = "Dog", Description = "Dog", Status = true },
            //    new Species() { Id = 1, DateCreated = DateTime.Now, DateModified = DateTime.Now, Name = "Cat", DisplayName = "Cat", Description = "Cat", Status = true },
            //    new Species() { Id = 2, DateCreated = DateTime.Now, DateModified = DateTime.Now, Name = "Horse", DisplayName = "Horse", Description = "Horse", Status = true },
            //    new Species() { Id = 3, DateCreated = DateTime.Now, DateModified = DateTime.Now, Name = "Cattle", DisplayName = "Cattle", Description = "Cattle", Status = true },
            //    new Species() { Id = 4, DateCreated = DateTime.Now, DateModified = DateTime.Now, Name = "Goat", DisplayName = "Goat", Description = "Goat", Status = true },
            //    new Species() { Id = 5, DateCreated = DateTime.Now, DateModified = DateTime.Now, Name = "GuineaPig", DisplayName = "Guinea Pig", Description = "Guinea Pig", Status = true },
            //    new Species() { Id = 6, DateCreated = DateTime.Now, DateModified = DateTime.Now, Name = "Rabbit", DisplayName = "Rabbit", Description = "Rabbit", Status = true },
            //    new Species() { Id = 7, DateCreated = DateTime.Now, DateModified = DateTime.Now, Name = "Bird", DisplayName = "Bird", Description = "Bird", Status = true }
            //    );

                

        }
    }
}

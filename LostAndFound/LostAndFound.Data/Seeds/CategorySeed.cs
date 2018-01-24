using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LostAndFound.Data.Interfaces;
using LostAndFound.Data.Models.Lookups;
using LostAndFound.Framework.Enums.Enumerations;

namespace LostAndFound.Data.Seeds
{

    public class CategorySeed : IEntitySeed
    {
        public void RunSeed(LostAndFoundContext context)
        {

            context.Categories.AddOrUpdate(
                  p => p.Id,
                  new Category() { Id = LostAndFoundCategory.Unknown.Id, Name = LostAndFoundCategory.Unknown.Name, DisplayName = LostAndFoundCategory.Unknown.DisplayName, Description = LostAndFoundCategory.Unknown.Description, DateModified = DateTime.Now,DateCreated = DateTime.Now, IsTopLevel = true},
                  new Category() { Id = LostAndFoundCategory.Animal.Id, Name = LostAndFoundCategory.Animal.Name, DisplayName = LostAndFoundCategory.Animal.DisplayName, Description = LostAndFoundCategory.Animal.Description, DateModified = DateTime.Now, DateCreated = DateTime.Now, IsTopLevel = true },
                  new Category() { Id = LostAndFoundCategory.Electronics.Id, Name = LostAndFoundCategory.Electronics.Name, DisplayName = LostAndFoundCategory.Electronics.DisplayName, Description = LostAndFoundCategory.Electronics.Description, DateModified = DateTime.Now, DateCreated = DateTime.Now, IsTopLevel = true },
                  new Category() { Id = 1000, Name = "Dog", DisplayName = "Dog", Description = "Dog", DateModified = DateTime.Now, DateCreated = DateTime.Now, IsTopLevel = false, ParentCategoryId = 0},
                  new Category() { Id = 2000, Name = "Cat", DisplayName = "Cat", Description = "Cat", DateModified = DateTime.Now, DateCreated = DateTime.Now, IsTopLevel = false, ParentCategoryId = 0 },
                  new Category() { Id = 1001, Name = "Alsation", DisplayName = "Alsation", Description = "Alsation", DateModified = DateTime.Now, DateCreated = DateTime.Now, IsTopLevel = false, ParentCategoryId = 1000 },
                  new Category() { Id = 1002, Name = "Beagle", DisplayName = "Beagle", Description = "Beagle", DateModified = DateTime.Now, DateCreated = DateTime.Now, IsTopLevel = false, ParentCategoryId = 1000 },
                  new Category() { Id = 2001, Name = "Siamese", DisplayName = "Siamese", Description = "Siamese", DateModified = DateTime.Now, DateCreated = DateTime.Now, IsTopLevel = false, ParentCategoryId = 2000 },
                  new Category() { Id = 2002, Name = "Persian", DisplayName = "Persian", Description = "Persian", DateModified = DateTime.Now, DateCreated = DateTime.Now, IsTopLevel = false, ParentCategoryId = 2000 }

                  );
        }
    }
}

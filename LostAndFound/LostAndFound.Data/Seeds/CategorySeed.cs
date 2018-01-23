using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LostAndFound.Data.Interfaces;
using LostAndFound.Data.Models.Lookups;

namespace LostAndFound.Data.Seeds
{

    public class CategorySeed : IEntitySeed
    {
        public void RunSeed(LostAndFoundContext context)
        {

            context.Categories.AddOrUpdate(
                  p => p.Id,
                  new Category() { Id = -1, Name = "Unknown" ,DisplayName = "Unknown Category",DateModified = DateTime.Now,DateCreated = DateTime.Now, IsTopLevel = true},
                  new Category() { Id = 0, Name = "Animals", DisplayName = "Animals / Pets", DateModified = DateTime.Now, DateCreated = DateTime.Now, IsTopLevel = true },
                  new Category() { Id = 1, Name = "Electonics", DisplayName = "Electonics", DateModified = DateTime.Now, DateCreated = DateTime.Now, IsTopLevel = true }
                );
        }
    }
}

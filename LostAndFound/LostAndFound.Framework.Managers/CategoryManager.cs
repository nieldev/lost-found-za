using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using LostAndFound.Data;
using LostAndFound.Data.Models.Lookups;
using LostAndFound.Framework.Interfaces.Managers;
using LostAndFound.Framework.Managers.BaseClasses;

namespace LostAndFound.Framework.Managers
{
    public class CategoryManager :BaseManager, ICategoryManager
    {
        public CategoryManager(LostAndFoundContext context) : base(context)
        {
        }

        public async Task<List<Category>> GetCategories()
        {
            return 
                await Context.Categories.Where(c => c.IsTopLevel).ToListAsync();
       
        }

        public async Task<List<Category>> GetCategories(long parentCategoryId)
        {
            return
                await Context.Categories.Where(c => c.ParentCategoryId == parentCategoryId).ToListAsync();

        }
    }
}

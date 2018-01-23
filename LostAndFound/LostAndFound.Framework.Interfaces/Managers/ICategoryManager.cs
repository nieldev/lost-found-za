using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LostAndFound.Data.Models.Lookups;

namespace LostAndFound.Framework.Interfaces.Managers
{
    public interface ICategoryManager
    {
        Task<List<Category>> GetCategories();
        Task<List<Category>> GetCategories(long parentCategoryId);
    }
}

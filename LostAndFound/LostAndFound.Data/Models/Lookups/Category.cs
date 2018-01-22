using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LostAndFound.Data.BaseModels;

namespace LostAndFound.Data.Models.Lookups
{
    public class Category : BaseLookup
    {
        public int ExternalId { get; set; }
        public LostAndFoundType Type { get; set; }
        public virtual List<SubCategory> SubCategories { get; set; }
    }
}

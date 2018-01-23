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
        public long? ParentCategoryId { get; set; }
        public Category ParentCategory { get; set; }
        public bool IsTopLevel { get; set; }
    }
}

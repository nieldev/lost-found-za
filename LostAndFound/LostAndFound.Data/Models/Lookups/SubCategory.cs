using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LostAndFound.Data.BaseModels;

namespace LostAndFound.Data.Models.Lookups
{
    public class SubCategory:BaseLookup
    {
        public int ExternalId { get; set; }
        public Category Category { get; set; }
    }
}

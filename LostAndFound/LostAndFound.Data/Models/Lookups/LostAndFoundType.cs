using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LostAndFound.Data.BaseModels;

namespace LostAndFound.Data.Models.Lookups
{
    public class LostAndFoundType : BaseLookup
    {
        public int ExternalId { get; set; }
        public virtual List<Category> Categories { get; set; }

    }
}

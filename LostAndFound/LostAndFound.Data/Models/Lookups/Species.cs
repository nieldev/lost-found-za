using System.Collections.Generic;
using LostAndFound.Data.BaseModels;

namespace LostAndFound.Data.Models.Lookups
{
    public class Species :BaseLookup
    {
        public virtual List<Breed> Breeds { get; set; }
    }
}

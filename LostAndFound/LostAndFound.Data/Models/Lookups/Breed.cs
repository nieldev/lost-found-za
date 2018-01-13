using LostAndFound.Data.BaseModels;

namespace LostAndFound.Data.Models.Lookups
{
    public class Breed : BaseLookup
    {
        public Species Species { get; set; }
    }
}

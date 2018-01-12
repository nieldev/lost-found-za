using System.Collections.Generic;

namespace LostAndFound.Data.Models
{
    public class Species :BaseModel
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public virtual List<Breed> Breeds { get; set; }
    }
}

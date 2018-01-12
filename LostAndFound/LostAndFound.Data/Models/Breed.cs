namespace LostAndFound.Data.Models
{
    public class Breed : BaseModel
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public Species Species { get; set; }
    }
}

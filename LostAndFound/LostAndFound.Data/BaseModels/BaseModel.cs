using System;

namespace LostAndFound.Data.BaseModels
{
    public abstract class BaseModel
    {
        public long Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool Status { get; set; }
    }
}

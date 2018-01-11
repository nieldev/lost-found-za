using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostAndFound.Data.Models
{
    public class LostFoundReport : BaseModel
    {
        public Location Location { get; set; }
        public Pet Pet { get; set; }
        public DateTime Date { get; set; }
        public Person ReportedBy { get; set; }
        public List<string> ImageUris { get; set; }
        public string AdditionalInfo { get; set; }
        public Contact Contact { get; set; }

    }
}

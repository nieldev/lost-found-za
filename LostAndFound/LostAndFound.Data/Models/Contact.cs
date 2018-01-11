using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostAndFound.Data.Models
{
    public class Contact : BaseModel
    {
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public Location Address { get; set; }
        public List<string> AdditionalContactNumbers { get; set; }
        public List<string> AdditionalEmailAddresses { get; set; }

    }
}

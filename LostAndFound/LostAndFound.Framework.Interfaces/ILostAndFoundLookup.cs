using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostAndFound.Framework.Interfaces
{
    public interface ILostAndFoundLookup
    {
        long Id { get; set; }
        DateTime DateCreated { get; set; }
        DateTime DateModified { get; set; }
        bool Status { get; set; }
        string Name { get; set; }
        string DisplayName { get; set; }
        string Description { get; set; }
    }
}

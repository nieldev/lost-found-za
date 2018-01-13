using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LostAndFound.Framework.Interfaces;

namespace LostAndFound.Data.BaseModels
{
    public class BaseLookup : BaseModel, ILostAndFoundLookup
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
    }
}

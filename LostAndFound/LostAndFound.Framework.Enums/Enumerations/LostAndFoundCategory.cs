using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LostAndFound.Framework.Enums.BaseClasses;

namespace LostAndFound.Framework.Enums.Enumerations
{
    public class LostAndFoundCategory : Enumeration
    {
        public static LostAndFoundCategory Unknown = new LostAndFoundCategory(-1, "Unknown", "Unknown", "Unknown");
        public static LostAndFoundCategory Animal = new LostAndFoundCategory(0, "Animal", "Animal", "Animal");
        public static LostAndFoundCategory Electronics = new LostAndFoundCategory(1, "Electronics", "Electronics", "Electronics");
        public static LostAndFoundCategory Vehicle = new LostAndFoundCategory(2, "Vehicle", "Vehicle", "Vehicle");
        protected LostAndFoundCategory(long id, string name,string displayName, string description) : base(id, name,displayName,description)
        {
        }
        public static IEnumerable<LostAndFoundCategory> List()
        {
            return new[] { Unknown,Animal, Electronics, Vehicle };
        }
    }
}

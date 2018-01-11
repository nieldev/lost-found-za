using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostAndFound.Data.Models
{
    public class Pet : Animal
    {
        public string Name { get; set; }
        public List<string> NickNames { get; set; }
    }
}

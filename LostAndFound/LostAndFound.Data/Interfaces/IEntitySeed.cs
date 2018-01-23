using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostAndFound.Data.Interfaces
{
    public interface IEntitySeed
    {
        void RunSeed(LostAndFoundContext context);
    }
}

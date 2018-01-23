using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LostAndFound.Data;

namespace LostAndFound.Framework.Managers.BaseClasses
{
    public abstract class BaseManager
    {
        protected LostAndFoundContext Context;
        protected BaseManager(LostAndFoundContext context)
        {
            Context = context;
        }
    }
}

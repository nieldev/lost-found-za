using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LostAndFound.Data;

namespace LostAndFound.Framework.Managers
{
    public class LookupManager
    {
        private LostAndFoundContext _context;
        public LookupManager(LostAndFoundContext context)
        {

            _context = context;
        }

        //public Task<List<T>> GetLookupAsync<T>()
        //{
        //    var dbContext = (DbContext)_context

        //}

    }
}

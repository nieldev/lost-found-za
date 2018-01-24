using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LostAndFound.Data;
using LostAndFound.Framework.Enums.Enumerations;

namespace LostAndFound.Framework.Managers
{
    public class LookupManager
    {
        private LostAndFoundContext _context;
        public LookupManager(LostAndFoundContext context)
        {
            var text = CardType.Amex.Name;
            _context = context;
        }

        //public Task<List<T>> GetLookupAsync<T>()
        //{
        //    var dbContext = (DbContext)_context

        //}

    }
}
